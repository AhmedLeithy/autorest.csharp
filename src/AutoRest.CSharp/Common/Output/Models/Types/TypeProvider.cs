// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Builders;
using Microsoft.CodeAnalysis;

namespace AutoRest.CSharp.Output.Models.Types
{
    internal abstract class TypeProvider
    {
        private readonly Lazy<INamedTypeSymbol?> _existingType;
        private TypeDeclarationOptions? _type;

        protected TypeProvider(BuildContext context)
        {
            Context = context;
            _existingType = new Lazy<INamedTypeSymbol?>(() => Context.SourceInputModel?.FindForType(DefaultNamespace, DefaultName));
        }

        public CSharpType Type => new CSharpType(
            this,
            Declaration.Namespace,
            Declaration.Name,
            TypeKind == TypeKind.Struct || TypeKind == TypeKind.Enum);
        public TypeDeclarationOptions Declaration => _type ??= BuildType();

        internal BuildContext Context { get; private set; }
        protected abstract string DefaultName { get; }
        protected virtual string DefaultNamespace => Context.DefaultNamespace;
        protected abstract string DefaultAccessibility { get; }
        protected virtual TypeKind TypeKind { get; } = TypeKind.Class;
        protected INamedTypeSymbol? ExistingType => _existingType.Value;

        internal virtual Type? SerializeAs => null;

        private TypeDeclarationOptions BuildType()
        {
            return BuilderHelpers.CreateTypeAttributes(
                DefaultName,
                DefaultNamespace,
                DefaultAccessibility,
                ExistingType,
                existingTypeOverrides: TypeKind == TypeKind.Enum);
        }

        public static string GetDefaultNamespace(string? namespaceExtension, BuildContext context)
        {
            var result = context.DefaultNamespace;
            if (namespaceExtension != default)
            {
                result = namespaceExtension;
            }
            else if (context.Configuration.ModelNamespace)
            {
                result = $"{context.DefaultNamespace}.Models";
            }
            return result;
        }
    }
}
