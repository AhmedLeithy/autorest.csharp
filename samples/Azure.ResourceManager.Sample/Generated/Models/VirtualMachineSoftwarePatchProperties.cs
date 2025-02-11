// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Describes the properties of a Virtual Machine software patch. </summary>
    public partial class VirtualMachineSoftwarePatchProperties
    {
        /// <summary> Initializes a new instance of VirtualMachineSoftwarePatchProperties. </summary>
        internal VirtualMachineSoftwarePatchProperties()
        {
            Classifications = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VirtualMachineSoftwarePatchProperties. </summary>
        /// <param name="patchId"> A unique identifier for the patch. </param>
        /// <param name="name"> The friendly name of the patch. </param>
        /// <param name="version"> The version number of the patch. This property applies only to Linux patches. </param>
        /// <param name="kbid"> The KBID of the patch. Only applies to Windows patches. </param>
        /// <param name="classifications"> The classification(s) of the patch as provided by the patch publisher. </param>
        /// <param name="rebootBehavior"> Describes the reboot requirements of the patch. </param>
        /// <param name="activityId"> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </param>
        /// <param name="publishedDate"> The UTC timestamp when the repository published this patch. </param>
        /// <param name="lastModifiedDateTime"> The UTC timestamp of the last update to this patch record. </param>
        /// <param name="assessmentState"> Describes the outcome of an install operation for a given patch. </param>
        internal VirtualMachineSoftwarePatchProperties(string patchId, string name, string version, string kbid, IReadOnlyList<string> classifications, SoftwareUpdateRebootBehavior? rebootBehavior, string activityId, DateTimeOffset? publishedDate, DateTimeOffset? lastModifiedDateTime, PatchAssessmentState? assessmentState)
        {
            PatchId = patchId;
            Name = name;
            Version = version;
            Kbid = kbid;
            Classifications = classifications;
            RebootBehavior = rebootBehavior;
            ActivityId = activityId;
            PublishedDate = publishedDate;
            LastModifiedDateTime = lastModifiedDateTime;
            AssessmentState = assessmentState;
        }

        /// <summary> A unique identifier for the patch. </summary>
        public string PatchId { get; }
        /// <summary> The friendly name of the patch. </summary>
        public string Name { get; }
        /// <summary> The version number of the patch. This property applies only to Linux patches. </summary>
        public string Version { get; }
        /// <summary> The KBID of the patch. Only applies to Windows patches. </summary>
        public string Kbid { get; }
        /// <summary> The classification(s) of the patch as provided by the patch publisher. </summary>
        public IReadOnlyList<string> Classifications { get; }
        /// <summary> Describes the reboot requirements of the patch. </summary>
        public SoftwareUpdateRebootBehavior? RebootBehavior { get; }
        /// <summary> The activity ID of the operation that produced this result. It is used to correlate across CRP and extension logs. </summary>
        public string ActivityId { get; }
        /// <summary> The UTC timestamp when the repository published this patch. </summary>
        public DateTimeOffset? PublishedDate { get; }
        /// <summary> The UTC timestamp of the last update to this patch record. </summary>
        public DateTimeOffset? LastModifiedDateTime { get; }
        /// <summary> Describes the outcome of an install operation for a given patch. </summary>
        public PatchAssessmentState? AssessmentState { get; }
    }
}
