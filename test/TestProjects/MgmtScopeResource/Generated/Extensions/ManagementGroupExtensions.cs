// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Management;

namespace MgmtScopeResource
{
    /// <summary> A class to add extension methods to ManagementGroup. </summary>
    public static partial class ManagementGroupExtensions
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="managementGroup"> The <see cref="ManagementGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentCollection" /> object. </returns>
        public static PolicyAssignmentCollection GetPolicyAssignments(this ManagementGroup managementGroup)
        {
            return new PolicyAssignmentCollection(managementGroup);
        }
        #endregion

        #region DeploymentExtended
        /// <summary> Gets an object representing a DeploymentExtendedCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="managementGroup"> The <see cref="ManagementGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DeploymentExtendedCollection" /> object. </returns>
        public static DeploymentExtendedCollection GetDeploymentExtendeds(this ManagementGroup managementGroup)
        {
            return new DeploymentExtendedCollection(managementGroup);
        }
        #endregion
    }
}
