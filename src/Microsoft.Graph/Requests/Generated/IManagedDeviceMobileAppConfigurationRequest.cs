// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedDeviceMobileAppConfigurationRequest.
    /// </summary>
    public partial interface IManagedDeviceMobileAppConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfiguration using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToCreate">The ManagedDeviceMobileAppConfiguration to create.</param>
        /// <returns>The created ManagedDeviceMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> CreateAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToCreate);        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfiguration using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToCreate">The ManagedDeviceMobileAppConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> CreateAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfiguration.
        /// </summary>
        /// <returns>The ManagedDeviceMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfiguration using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToUpdate">The ManagedDeviceMobileAppConfiguration to update.</param>
        /// <returns>The updated ManagedDeviceMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> UpdateAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToUpdate);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfiguration using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationToUpdate">The ManagedDeviceMobileAppConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceMobileAppConfiguration.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfiguration> UpdateAsync(ManagedDeviceMobileAppConfiguration managedDeviceMobileAppConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationRequest Expand(Expression<Func<ManagedDeviceMobileAppConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationRequest Select(Expression<Func<ManagedDeviceMobileAppConfiguration, object>> selectExpression);

    }
}
