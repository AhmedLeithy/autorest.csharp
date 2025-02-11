﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Storage.Tables.Models;

namespace Azure.Storage.Tables
{
    public class TableClient
    {
        private readonly string _table;
        private readonly ResponseFormat _format;
        private readonly TableInternalClient _tableOperations;

        internal TableClient(string table, TableInternalClient tableOperations)
        {
            _tableOperations = tableOperations;
            _table = table;
            _format = ResponseFormat.ApplicationJsonOdataFullmetadata;
        }

        public async Task<Response<IReadOnlyDictionary<string, object>>> InsertAsync(IDictionary<string, object> entity, CancellationToken cancellationToken = default)
        {
            Response<IReadOnlyDictionary<string, object>> response =
                await _tableOperations.InsertEntityAsync(Enum1.Three0, _table,
                        tableEntityProperties: entity,
                        queryOptions: new QueryOptions() { Format = _format },cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

            return response;
        }

        public async Task<Response> UpdateAsync(string partitionKey, string rowKey, IDictionary<string, object> entity, CancellationToken cancellationToken= default)
        {
            return await _tableOperations.UpdateEntityAsync(Enum1.Three0, _table, partitionKey, rowKey,
                tableEntityProperties: entity,
                queryOptions:new QueryOptions() { Format = _format },
                cancellationToken: cancellationToken);
        }

        public AsyncPageable<IDictionary<string, object>> QueryAsync(string select = null, string filter = null, int? limit = null, CancellationToken cancellationToken = default)
        {
            return PageableHelpers.CreateAsyncEnumerable(async tableName =>
            {
                var response = await _tableOperations.RestClient.QueryEntitiesAsync(Enum1.Three0, _table,
                    queryOptions: new QueryOptions() { Format = _format, Top = limit, Filter = filter, Select = @select},
                    cancellationToken: cancellationToken);
                return Page.FromValues(response.Value.Value, response.Headers.XMsContinuationNextPartitionKey, response.GetRawResponse());
            },(_, __) => throw new NotImplementedException());
        }
    }
}
