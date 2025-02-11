// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> LogAnalytics output properties. </summary>
    public partial class LogAnalyticsOutput
    {
        /// <summary> Initializes a new instance of LogAnalyticsOutput. </summary>
        internal LogAnalyticsOutput()
        {
        }

        /// <summary> Initializes a new instance of LogAnalyticsOutput. </summary>
        /// <param name="output"> Output file Uri path to blob container. </param>
        internal LogAnalyticsOutput(string output)
        {
            Output = output;
        }

        /// <summary> Output file Uri path to blob container. </summary>
        public string Output { get; }
    }
}
