﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System.Collections.Generic;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Models;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Mgmt.Output
{
    internal class SubscriptionExtensions : MgmtExtensions
    {
        public SubscriptionExtensions(IEnumerable<Operation> allOperations, BuildContext<MgmtOutputLibrary> context) : base(allOperations, context)
        {
        }

        public override string ResourceName => "Subscription";

        protected override string DefaultName => "SubscriptionExtensions";

        protected override RequestPath ContextualPath => RequestPath.Subscription;
    }
}
