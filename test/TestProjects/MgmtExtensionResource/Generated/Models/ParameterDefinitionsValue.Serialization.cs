// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtExtensionResource.Models
{
    public partial class ParameterDefinitionsValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedValues))
            {
                writer.WritePropertyName("allowedValues");
                writer.WriteStartArray();
                foreach (var item in AllowedValues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue");
                writer.WriteObjectValue(DefaultValue);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
        }

        internal static ParameterDefinitionsValue DeserializeParameterDefinitionsValue(JsonElement element)
        {
            Optional<ParameterType> type = default;
            Optional<IList<object>> allowedValues = default;
            Optional<object> defaultValue = default;
            Optional<ParameterDefinitionsValueMetadata> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
                    }
                    allowedValues = array;
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = ParameterDefinitionsValueMetadata.DeserializeParameterDefinitionsValueMetadata(property.Value);
                    continue;
                }
            }
            return new ParameterDefinitionsValue(Optional.ToNullable(type), Optional.ToList(allowedValues), defaultValue.Value, metadata.Value);
        }
    }
}
