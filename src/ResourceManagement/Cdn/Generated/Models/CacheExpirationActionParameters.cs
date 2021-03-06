// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the parameters for the cache expiration action.
    /// </summary>
    public partial class CacheExpirationActionParameters
    {
        /// <summary>
        /// Initializes a new instance of the CacheExpirationActionParameters
        /// class.
        /// </summary>
        public CacheExpirationActionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CacheExpirationActionParameters
        /// class.
        /// </summary>
        /// <param name="cacheBehavior">Caching behavior for the requests that
        /// include query strings. Possible values include: 'BypassCache',
        /// 'Override', 'SetIfMissing'</param>
        /// <param name="cacheDuration">The duration for which the content
        /// needs to be cached. Allowed format is [d.]hh:mm:ss</param>
        public CacheExpirationActionParameters(CacheBehavior cacheBehavior, string cacheDuration = default(string))
        {
            CacheBehavior = cacheBehavior;
            CacheDuration = cacheDuration;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for CacheExpirationActionParameters class.
        /// </summary>
        static CacheExpirationActionParameters()
        {
            Odatatype = "Microsoft.Azure.Cdn.Models.DeliveryRuleCacheExpirationActionParameters";
            CacheType = "All";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets caching behavior for the requests that include query
        /// strings. Possible values include: 'BypassCache', 'Override',
        /// 'SetIfMissing'
        /// </summary>
        [JsonProperty(PropertyName = "cacheBehavior")]
        public CacheBehavior CacheBehavior { get; set; }

        /// <summary>
        /// Gets or sets the duration for which the content needs to be cached.
        /// Allowed format is [d.]hh:mm:ss
        /// </summary>
        [JsonProperty(PropertyName = "cacheDuration")]
        public string CacheDuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.type")]
        public static string Odatatype { get; private set; }

        /// <summary>
        /// The level at which the content needs to be cached.
        /// </summary>
        [JsonProperty(PropertyName = "cacheType")]
        public static string CacheType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CacheBehavior == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CacheBehavior");
            }
        }
    }
}
