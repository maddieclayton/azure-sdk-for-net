// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.ApiManagement.Models;

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    /// <summary>
    /// Parameters supplied to the CreateOrUpdate Api Management service
    /// operation.
    /// </summary>
    public partial class ApiServiceCreateOrUpdateParameters
    {
        private string _location;
        
        /// <summary>
        /// Required. Gets or sets Api Management service data center location.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private ApiServiceProperties _properties;
        
        /// <summary>
        /// Required. Gets or sets properties of the Api Management service.
        /// </summary>
        public ApiServiceProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private ApiServiceSkuProperties _skuProperties;
        
        /// <summary>
        /// Required. Gets or sets sku properties of the Api Management service.
        /// </summary>
        public ApiServiceSkuProperties SkuProperties
        {
            get { return this._skuProperties; }
            set { this._skuProperties = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. Gets or sets Api Management service tags. A maximum of 10
        /// tags can be provided for a resource, and each tag must have a key
        /// no greater than 128 characters (and value no greater than 256
        /// characters)
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ApiServiceCreateOrUpdateParameters class.
        /// </summary>
        public ApiServiceCreateOrUpdateParameters()
        {
            this.Tags = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ApiServiceCreateOrUpdateParameters class with required arguments.
        /// </summary>
        public ApiServiceCreateOrUpdateParameters(string location, ApiServiceProperties properties, ApiServiceSkuProperties skuProperties)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            if (skuProperties == null)
            {
                throw new ArgumentNullException("skuProperties");
            }
            this.Location = location;
            this.Properties = properties;
            this.SkuProperties = skuProperties;
        }
    }
}
