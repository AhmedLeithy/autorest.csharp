// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The ScheduledEventsProfile. </summary>
    public partial class ScheduledEventsProfile
    {
        /// <summary> Initializes a new instance of ScheduledEventsProfile. </summary>
        public ScheduledEventsProfile()
        {
        }

        /// <summary> Initializes a new instance of ScheduledEventsProfile. </summary>
        /// <param name="terminateNotificationProfile"> Specifies Terminate Scheduled Event related configurations. </param>
        internal ScheduledEventsProfile(TerminateNotificationProfile terminateNotificationProfile)
        {
            TerminateNotificationProfile = terminateNotificationProfile;
        }

        /// <summary> Specifies Terminate Scheduled Event related configurations. </summary>
        public TerminateNotificationProfile TerminateNotificationProfile { get; set; }
    }
}
