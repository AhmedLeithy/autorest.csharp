// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Mgmt.Generation;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.AutoRest.Plugins
{
    internal class MgmtTarget
    {
        private static ISet<string> _addedFilenames = new HashSet<string>();
        private static IList<string> _overridenFilenames = new List<string>();

        private static void AddGeneratedFile(GeneratedCodeWorkspace project, string filename, string text)
        {
            if (_addedFilenames.Contains(filename))
                _overridenFilenames.Add(filename);
            else
                _addedFilenames.Add(filename);
            project.AddGeneratedFile(filename, text);
        }

        public static void Execute(GeneratedCodeWorkspace project, CodeModel codeModel, SourceInputModel? sourceInputModel, Configuration configuration)
        {
            var addedFilenames = new HashSet<string>();
            BuildContext<MgmtOutputLibrary> context = new BuildContext<MgmtOutputLibrary>(codeModel, configuration, sourceInputModel);
            var serializeWriter = new SerializationWriter();

            foreach (var model in context.Library.Models)
            {
                if (ShouldSkipModelGeneration(model, context))
                    continue;

                var codeWriter = new CodeWriter();
                ReferenceTypeWriter.GetWriter(model).WriteModel(codeWriter, model);
                var name = model.Type.Name;
                AddGeneratedFile(project, $"Models/{name}.cs", codeWriter.ToString());

                if (model is MgmtReferenceType mgmtReferenceType)
                {
                    var extensions = mgmtReferenceType.ObjectSchema.Extensions;
                    if (extensions != null && extensions.MgmtReferenceType)
                        continue;
                }

                var serializerCodeWriter = new CodeWriter();
                serializeWriter.WriteSerialization(serializerCodeWriter, model);
                AddGeneratedFile(project, $"Models/{name}.Serialization.cs", serializerCodeWriter.ToString());
            }

            foreach (var client in context.Library.RestClients)
            {
                var restCodeWriter = new CodeWriter();
                new MgmtRestClientWriter().WriteClient(restCodeWriter, client);

                AddGeneratedFile(project, $"RestOperations/{client.Type.Name}.cs", restCodeWriter.ToString());
            }

            foreach (var resourceCollection in context.Library.ResourceCollections)
            {
                var codeWriter = new CodeWriter();
                new ResourceCollectionWriter(codeWriter, resourceCollection, context).Write();

                AddGeneratedFile(project, $"{resourceCollection.Type.Name}.cs", codeWriter.ToString());
            }

            foreach (var model in context.Library.ResourceData)
            {
                var codeWriter = new CodeWriter();
                ReferenceTypeWriter.GetWriter(model).WriteModel(codeWriter, model);

                var serializerCodeWriter = new CodeWriter();
                serializeWriter.WriteSerialization(serializerCodeWriter, model);

                var name = model.Type.Name;
                AddGeneratedFile(project, $"{name}.cs", codeWriter.ToString());
                AddGeneratedFile(project, $"Models/{name}.Serialization.cs", serializerCodeWriter.ToString());
            }

            foreach (var resource in context.Library.ArmResources)
            {
                var codeWriter = new CodeWriter();
                new ResourceWriter(codeWriter, resource, context).Write();

                AddGeneratedFile(project, $"{resource.Type.Name}.cs", codeWriter.ToString());
            }

            foreach (var operation in context.Library.LongRunningOperations)
            {
                var codeWriter = new CodeWriter();
                new MgmtLongRunningOperationWriter().Write(codeWriter, operation);

                AddGeneratedFile(project, $"LongRunningOperation/{operation.Type.Name}.cs", codeWriter.ToString());
            }

            foreach (var operation in context.Library.NonLongRunningOperations)
            {
                var codeWriter = new CodeWriter();
                new NonLongRunningOperationWriter().Write(codeWriter, operation);

                AddGeneratedFile(project, $"LongRunningOperation/{operation.Type.Name}.cs", codeWriter.ToString());
            }

            // we will write the ResourceGroupExtensions class even if it does not contain anything
            var resourceGroupExtensionsCodeWriter = new CodeWriter();
            new ResourceGroupExtensionsWriter(resourceGroupExtensionsCodeWriter, context.Library.ResourceGroupExtensions, context).Write();
            AddGeneratedFile(project, $"Extensions/{context.Library.ResourceGroupExtensions.Type.Name}.cs", resourceGroupExtensionsCodeWriter.ToString());

            // we will write the SubscriptionExtensions class even if it does not contain anything
            var subscriptionExtensionsCodeWriter = new CodeWriter();
            new SubscriptionExtensionsWriter(subscriptionExtensionsCodeWriter, context.Library.SubscriptionExtensions, context).Write();
            AddGeneratedFile(project, $"Extensions/{context.Library.SubscriptionExtensions.Type.Name}.cs", subscriptionExtensionsCodeWriter.ToString());

            if (!context.Library.ManagementGroupExtensions.IsEmpty)
            {
                var managementGroupExtensionsCodeWriter = new CodeWriter();
                new ManagementGroupExtensionsWriter(managementGroupExtensionsCodeWriter, context.Library.ManagementGroupExtensions, context).Write();
                AddGeneratedFile(project, $"Extensions/{context.Library.ManagementGroupExtensions.Type.Name}.cs", managementGroupExtensionsCodeWriter.ToString());
            }

            if (!context.Library.TenantExtensions.IsEmpty)
            {
                var tenantExtensionsCodeWriter = new CodeWriter();
                new TenantExtensionsWriter(tenantExtensionsCodeWriter, context.Library.TenantExtensions, context).Write();
                AddGeneratedFile(project, $"Extensions/{context.Library.TenantExtensions.Type.Name}.cs", tenantExtensionsCodeWriter.ToString());
            }

            if (!context.Library.ArmClientExtensions.IsEmpty)
            {
                var armClientExtensionsCodeWriter = new CodeWriter();
                new ArmClientExtensionsWriter(armClientExtensionsCodeWriter, context.Library.ArmClientExtensions, context).Write();
                AddGeneratedFile(project, $"Extensions/{context.Library.ArmClientExtensions.Type.Name}.cs", armClientExtensionsCodeWriter.ToString());
            }

            if (_overridenFilenames.Count != 0)
                throw new InvalidOperationException($"At least one file was overridden during the generation process. Filenames are: {string.Join(", ", _overridenFilenames)}");
        }

        private static bool ShouldSkipModelGeneration(TypeProvider model, BuildContext<MgmtOutputLibrary> context)
        {
            // TODO: A temporay fix for orphaned models in Resources SDK. These models are usually not directly used by ResourceData, but a descendant property of a PropertyReferenceType.
            // Can go way after full orphan fix https://dev.azure.com/azure-mgmt-ex/DotNET%20Management%20SDK/_workitems/edit/6000
            // The includeArmCore parameter should also be removed in FindForType() then.
            if (!context.Configuration.MgmtConfiguration.IsArmCore && context.SourceInputModel?.FindForType(model.Declaration.Namespace, model.Declaration.Name, includeArmCore: true) != null)
            {
                return true;
            }
            if (model is SchemaObjectType objSchema)
            {
                //TODO: we need to add logic to replace SubResource with ResourceIdentifier where appropriate until then we won't remove these types
                if (objSchema.ObjectSchema.Name.StartsWith("SubResource"))
                    return false;
                //skip things that had exact match replacements
                //TODO: Can go away after full orphan fix https://dev.azure.com/azure-mgmt-ex/DotNET%20Management%20SDK/_workitems/edit/6000
                //Since we forced the evaluation of inheritance and property match for all models before, here we can use the fully loaded cache to
                //get the information that whether the model has been used as a base class for inheritance and as a property.
                var usedAsInheritance = InheritanceChooser.TryGetCachedExactMatch(objSchema.ObjectSchema, out var inheritanceResult);
                var usedAsProperty = ReferenceTypePropertyChooser.TryGetCachedExactMatch(objSchema.ObjectSchema, out var propertyResult);
                if (usedAsInheritance && usedAsProperty)
                {
                    //If the model is used both as a base class for inheritance and a property, we only remove the model when it has matches in both cases.
                    if (inheritanceResult != null && propertyResult != null)
                        return true;
                }
                else if (inheritanceResult != null || propertyResult != null)
                    return true;
                else if (model is MgmtObjectType mgmtObjType && model.GetType() != typeof(MgmtReferenceType))
                {
                    //In the cache of ReferenceTypePropertyChooser, only models used as a direct property of another model is stored.
                    //There could be orphaned models that are not a direct property of another model and is not tracked by cache.
                    //TODO: Can go away after full orphan fix https://dev.azure.com/azure-mgmt-ex/DotNET%20Management%20SDK/_workitems/edit/6000
                    if (ReferenceTypePropertyChooser.GetExactMatch(mgmtObjType, context) != null)
                        return true;
                }
            }
            return false;
        }
    }
}
