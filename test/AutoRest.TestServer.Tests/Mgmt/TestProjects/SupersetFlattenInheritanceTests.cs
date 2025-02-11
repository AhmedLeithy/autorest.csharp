﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;
using SupersetFlattenInheritance;
using SupersetFlattenInheritance.Models;

namespace AutoRest.TestServer.Tests.Mgmt.TestProjects
{
    public class SupersetFlattenInheritanceTests : TestProjectTests
    {
        public SupersetFlattenInheritanceTests()
            : base("SupersetFlattenInheritance")
        {
        }

        [TestCase(typeof(object), typeof(CustomModel1))]
        [TestCase(typeof(object), typeof(CustomModel2))]
        [TestCase(typeof(Resource), typeof(ResourceModel1Data))]
        [TestCase(typeof(Resource), typeof(ResourceModel2))]
        [TestCase(typeof(TrackedResource), typeof(TrackedResourceModel1Data))]
        [TestCase(typeof(TrackedResource), typeof(TrackedResourceModel2))]
        [TestCase(typeof(object), typeof(NonResourceModel1))]
        public void ValidateInheritanceType(Type expectedBaseType, Type generatedClass)
        {
            Assert.AreEqual(expectedBaseType, generatedClass.BaseType);
            foreach (var property in generatedClass.BaseType.GetProperties())
            {
                Assert.IsFalse(generatedClass.GetProperty(property.Name).DeclaringType == generatedClass);
            }
        }

        [TestCase(typeof(CustomModel1), typeof(CustomModel2))]
        [TestCase(typeof(CustomModel1), typeof(SubResourceModel2))]
        [TestCase(typeof(CustomModel1), typeof(WritableSubResourceModel2))]
        [TestCase(typeof(SubResourceModel1), typeof(ResourceModel2))]
        [TestCase(typeof(ResourceModel1Data), typeof(TrackedResourceModel2))]
        [TestCase(typeof(CustomModel1), typeof(NonResourceModel1))]
        public void ValidateFlattenType(Type sourceType, Type targetType)
        {
            // source type is not the parent of the target type
            Assert.AreNotEqual(sourceType, targetType.BaseType);
            // all properties of source type should be in the target type
            foreach (var property in sourceType.GetProperties())
            {
                Assert.IsTrue(targetType.GetProperty(property.Name).GetType() == property.GetType() );
            }
        }

        [TestCase(typeof(CustomModel1), new string[] { "foo" }, new Type[] { typeof(string) })]
        [TestCase(typeof(CustomModel2), new string[] { "foo", "bar" }, new Type[] { typeof(string), typeof(string) })]
        [TestCase(typeof(SubResourceModel1), new string[] { "id", "foo" }, new Type[] { typeof(string), typeof(string) })]
        [TestCase(typeof(SubResourceModel2), new string[] { "id", "foo" }, new Type[] { typeof(string), typeof(string) })]
        [TestCase(typeof(WritableSubResourceModel1), new string[] { "id", "foo" }, new Type[] { typeof(string), typeof(string) })]
        [TestCase(typeof(WritableSubResourceModel2), new string[] { "id", "foo" }, new Type[] { typeof(string), typeof(string) })]
        [TestCase(typeof(ResourceModel1Data), new string[] { "id", "name", "type", "foo"}, new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) })]
        [TestCase(typeof(ResourceModel1Data), new string[] { "id", "name", "type", "foo"}, new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) })]
        [TestCase(typeof(TrackedResourceModel1Data), new string[] { "location" }, new Type[] { typeof(Location) })]
        [TestCase(typeof(TrackedResourceModel2), new string[] { "location" }, new Type[] { typeof(Location) })]
        [TestCase(typeof(NonResourceModel1), new string[] { "foo", "bar" }, new Type[] { typeof(string), typeof(string) })]
        public void ValidateCtor(Type model, string[] paramNames, Type[] paramTypes) => ValidatePublicCtor(model, paramNames, paramTypes);
    }
}
