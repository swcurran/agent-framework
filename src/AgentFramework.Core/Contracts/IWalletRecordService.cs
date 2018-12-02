﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AgentFramework.Core.Models.Records;
using AgentFramework.Core.Models.Records.Search;
using Hyperledger.Indy.WalletApi;

namespace AgentFramework.Core.Contracts
{
    /// <summary>
    /// Wallet record service.
    /// </summary>
    public interface IWalletRecordService
    {
        /// <summary>
        /// Adds the record async.
        /// </summary>
        /// <returns>The record async.</returns>
        /// <param name="wallet">Wallet.</param>
        /// <param name="record">Record.</param>
        /// <param name="id">Identifier.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task AddAsync<T>(Wallet wallet, T record) where T : WalletRecord, new();

        /// <summary>
        /// Searchs the records async.
        /// </summary>
        /// <returns>The records async.</returns>
        /// <param name="wallet">Wallet.</param>
        /// <param name="query">Query.</param>
        /// <param name="options">Options.</param>
        /// <param name="count">The number of items to return</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task<List<T>> SearchAsync<T>(Wallet wallet, ISearchQuery query, SearchOptions options, int count) where T : WalletRecord, new();

        /// <summary>
        /// Updates the record async.
        /// </summary>
        /// <returns>The record async.</returns>
        /// <param name="wallet">Wallet.</param>
        /// <param name="record">Credential record.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task UpdateAsync<T>(Wallet wallet, T record) where T : WalletRecord, new();

        /// <summary>
        /// Gets the record async.
        /// </summary>
        /// <returns>The record async.</returns>
        /// <param name="wallet">Wallet.</param>
        /// <param name="id">Identifier.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        Task<T> GetAsync<T>(Wallet wallet, string id) where T : WalletRecord, new();

        /// <summary>
        /// Deletes the record async.
        /// </summary>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        /// <param name="wallet">Wallet.</param>
        /// <param name="id">Record Identifier.</param>
        /// <returns>Boolean status indicating if the removal succeed</returns>
        Task<bool> DeleteAsync<T>(Wallet wallet, string id) where T : WalletRecord, new();
    }
}