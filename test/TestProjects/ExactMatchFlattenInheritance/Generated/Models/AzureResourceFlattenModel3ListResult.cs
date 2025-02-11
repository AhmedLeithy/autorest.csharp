// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ExactMatchFlattenInheritance.Models
{
    /// <summary> The response from the List Storage Accounts operation. </summary>
    public partial class AzureResourceFlattenModel3ListResult
    {
        /// <summary> Initializes a new instance of AzureResourceFlattenModel3ListResult. </summary>
        internal AzureResourceFlattenModel3ListResult()
        {
            Value = new ChangeTrackingList<AzureResourceFlattenModel3>();
        }

        /// <summary> Initializes a new instance of AzureResourceFlattenModel3ListResult. </summary>
        /// <param name="value"> Gets the list of storage accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </param>
        internal AzureResourceFlattenModel3ListResult(IReadOnlyList<AzureResourceFlattenModel3> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of storage accounts and their properties. </summary>
        public IReadOnlyList<AzureResourceFlattenModel3> Value { get; }
        /// <summary> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
