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

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Operation parameters details.
    /// </summary>
    public partial class ParameterContract
    {
        private string _defaultValue;
        
        /// <summary>
        /// Optional. Gets or sets Default parameter value.
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets Parameter description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets Parameter name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private bool _required;
        
        /// <summary>
        /// Optional. Gets or sets whether parameter is required or not.
        /// </summary>
        public bool Required
        {
            get { return this._required; }
            set { this._required = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. Gets or sets Parameter type.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private IList<string> _values;
        
        /// <summary>
        /// Optional. Gets or sets Parameter values.
        /// </summary>
        public IList<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ParameterContract class.
        /// </summary>
        public ParameterContract()
        {
            this.Values = new LazyList<string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ParameterContract class with
        /// required arguments.
        /// </summary>
        public ParameterContract(string name, string type)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            this.Name = name;
            this.Type = type;
        }
    }
}
