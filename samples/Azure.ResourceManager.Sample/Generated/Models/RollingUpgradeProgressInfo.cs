// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Information about the number of virtual machine instances in each upgrade state. </summary>
    public partial class RollingUpgradeProgressInfo
    {
        /// <summary> Initializes a new instance of RollingUpgradeProgressInfo. </summary>
        internal RollingUpgradeProgressInfo()
        {
        }

        /// <summary> Initializes a new instance of RollingUpgradeProgressInfo. </summary>
        /// <param name="successfulInstanceCount"> The number of instances that have been successfully upgraded. </param>
        /// <param name="failedInstanceCount"> The number of instances that have failed to be upgraded successfully. </param>
        /// <param name="inProgressInstanceCount"> The number of instances that are currently being upgraded. </param>
        /// <param name="pendingInstanceCount"> The number of instances that have not yet begun to be upgraded. </param>
        internal RollingUpgradeProgressInfo(int? successfulInstanceCount, int? failedInstanceCount, int? inProgressInstanceCount, int? pendingInstanceCount)
        {
            SuccessfulInstanceCount = successfulInstanceCount;
            FailedInstanceCount = failedInstanceCount;
            InProgressInstanceCount = inProgressInstanceCount;
            PendingInstanceCount = pendingInstanceCount;
        }

        /// <summary> The number of instances that have been successfully upgraded. </summary>
        public int? SuccessfulInstanceCount { get; }
        /// <summary> The number of instances that have failed to be upgraded successfully. </summary>
        public int? FailedInstanceCount { get; }
        /// <summary> The number of instances that are currently being upgraded. </summary>
        public int? InProgressInstanceCount { get; }
        /// <summary> The number of instances that have not yet begun to be upgraded. </summary>
        public int? PendingInstanceCount { get; }
    }
}
