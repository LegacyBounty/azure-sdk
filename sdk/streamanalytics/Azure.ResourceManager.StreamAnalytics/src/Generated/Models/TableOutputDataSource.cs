// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Describes an Azure Table output data source. </summary>
    public partial class TableOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of TableOutputDataSource. </summary>
        public TableOutputDataSource()
        {
            ColumnsToRemove = new ChangeTrackingList<string>();
            OutputDataSourceType = "Microsoft.Storage/Table";
        }

        /// <summary> Initializes a new instance of TableOutputDataSource. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="accountName"> The name of the Azure Storage account. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="accountKey"> The account key for the Azure Storage account. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="table"> The name of the Azure Table. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="partitionKey"> This element indicates the name of a column from the SELECT statement in the query that will be used as the partition key for the Azure Table. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="rowKey"> This element indicates the name of a column from the SELECT statement in the query that will be used as the row key for the Azure Table. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="columnsToRemove"> If specified, each item in the array is the name of a column to remove (if present) from output event entities. </param>
        /// <param name="batchSize"> The number of rows to write to the Azure Table at a time. </param>
        internal TableOutputDataSource(string outputDataSourceType, string accountName, string accountKey, string table, string partitionKey, string rowKey, IList<string> columnsToRemove, int? batchSize) : base(outputDataSourceType)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            Table = table;
            PartitionKey = partitionKey;
            RowKey = rowKey;
            ColumnsToRemove = columnsToRemove;
            BatchSize = batchSize;
            OutputDataSourceType = outputDataSourceType ?? "Microsoft.Storage/Table";
        }

        /// <summary> The name of the Azure Storage account. Required on PUT (CreateOrReplace) requests. </summary>
        public string AccountName { get; set; }
        /// <summary> The account key for the Azure Storage account. Required on PUT (CreateOrReplace) requests. </summary>
        public string AccountKey { get; set; }
        /// <summary> The name of the Azure Table. Required on PUT (CreateOrReplace) requests. </summary>
        public string Table { get; set; }
        /// <summary> This element indicates the name of a column from the SELECT statement in the query that will be used as the partition key for the Azure Table. Required on PUT (CreateOrReplace) requests. </summary>
        public string PartitionKey { get; set; }
        /// <summary> This element indicates the name of a column from the SELECT statement in the query that will be used as the row key for the Azure Table. Required on PUT (CreateOrReplace) requests. </summary>
        public string RowKey { get; set; }
        /// <summary> If specified, each item in the array is the name of a column to remove (if present) from output event entities. </summary>
        public IList<string> ColumnsToRemove { get; }
        /// <summary> The number of rows to write to the Azure Table at a time. </summary>
        public int? BatchSize { get; set; }
    }
}
