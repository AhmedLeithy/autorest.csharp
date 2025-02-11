// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtListMethods;

namespace MgmtListMethods.Models
{
    internal partial class TenantParentWithNonResChWithLocListResult
    {
        internal static TenantParentWithNonResChWithLocListResult DeserializeTenantParentWithNonResChWithLocListResult(JsonElement element)
        {
            IReadOnlyList<TenantParentWithNonResChWithLocData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TenantParentWithNonResChWithLocData> array = new List<TenantParentWithNonResChWithLocData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TenantParentWithNonResChWithLocData.DeserializeTenantParentWithNonResChWithLocData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TenantParentWithNonResChWithLocListResult(value, nextLink.Value);
        }
    }
}
