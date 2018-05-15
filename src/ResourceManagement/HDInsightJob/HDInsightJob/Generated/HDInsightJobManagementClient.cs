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
using System.Globalization;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure.Management.HDInsight.Job;

namespace Microsoft.Azure.Management.HDInsight.Job
{
    /// <summary>
    /// The HDInsight job client manages jobs against HDInsight clusters.
    /// </summary>
    public partial class HDInsightJobManagementClient : ServiceClient<HDInsightJobManagementClient>, IHDInsightJobManagementClient
    {
        private string _clusterDnsName;
        
        /// <summary>
        /// The cluster dns name against which the job management is to be
        /// performed.
        /// </summary>
        public string ClusterDnsName
        {
            get { return this._clusterDnsName; }
            set { this._clusterDnsName = value; }
        }
        
        private BasicAuthenticationCloudCredentials _credentials;
        
        /// <summary>
        /// Basic authentication credentials for job submission.
        /// </summary>
        public BasicAuthenticationCloudCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private string _sdkUserAgent;
        
        /// <summary>
        /// Gets or sets the SDK UserAgent text to be added to the user agent
        /// header. This is used to further differentiate various SDK versions.
        /// </summary>
        public string SdkUserAgent
        {
            get { return this._sdkUserAgent; }
        }
        
        private string _userAgentSuffix;
        
        /// <summary>
        /// Gets or sets the additional UserAgent text to be added to the user
        /// agent header. This is used to further differentiate using
        /// applications.
        /// </summary>
        public string UserAgentSuffix
        {
            get { return this._userAgentSuffix; }
            set { this._userAgentSuffix = value; }
        }
        
        private string _userName;
        
        /// <summary>
        /// The user name from Username of BasicAuthenticationCloudCredentials
        /// in lower case used for running job.
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
        }
        
        private IJobOperations _jobManagement;
        
        /// <summary>
        /// Operations for managing jobs against HDInsight clusters.
        /// </summary>
        public virtual IJobOperations JobManagement
        {
            get { return this._jobManagement; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HDInsightJobManagementClient
        /// class.
        /// </summary>
        public HDInsightJobManagementClient()
            : base()
        {
            this._jobManagement = new JobOperations(this);
            this._userAgentSuffix = "";
            this._sdkUserAgent = SdkVersion;
            this._userName = "";
        }
        
        /// <summary>
        /// Initializes a new instance of the HDInsightJobManagementClient
        /// class.
        /// </summary>
        /// <param name='clusterDnsName'>
        /// Required. The cluster dns name against which the job management is
        /// to be performed.
        /// </param>
        /// <param name='credentials'>
        /// Required. Basic authentication credentials for job submission.
        /// </param>
        internal HDInsightJobManagementClient(string clusterDnsName, BasicAuthenticationCloudCredentials credentials)
            : this()
        {
            if (clusterDnsName == null)
            {
                throw new ArgumentNullException("clusterDnsName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._clusterDnsName = clusterDnsName;
            this._credentials = credentials;
            
            this.Credentials.InitializeServiceClient(this);
            this._userName = CultureInfo.CurrentCulture.TextInfo.ToLower(credentials.Username);
        }
        
        /// <summary>
        /// Initializes a new instance of the HDInsightJobManagementClient
        /// class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public HDInsightJobManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._jobManagement = new JobOperations(this);
            this._userAgentSuffix = "";
            this._sdkUserAgent = SdkVersion;
            this._userName = "";
        }
        
        /// <summary>
        /// Initializes a new instance of the HDInsightJobManagementClient
        /// class.
        /// </summary>
        /// <param name='clusterDnsName'>
        /// Required. The cluster dns name against which the job management is
        /// to be performed.
        /// </param>
        /// <param name='credentials'>
        /// Required. Basic authentication credentials for job submission.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public HDInsightJobManagementClient(string clusterDnsName, BasicAuthenticationCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (clusterDnsName == null)
            {
                throw new ArgumentNullException("clusterDnsName");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._clusterDnsName = clusterDnsName;
            this._credentials = credentials;
            
            this.Credentials.InitializeServiceClient(this);
            this._userName = CultureInfo.CurrentCulture.TextInfo.ToLower(credentials.Username);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// HDInsightJobManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of HDInsightJobManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<HDInsightJobManagementClient> client)
        {
            base.Clone(client);
            
            if (client is HDInsightJobManagementClient)
            {
                HDInsightJobManagementClient clonedClient = ((HDInsightJobManagementClient)client);
                
                clonedClient._clusterDnsName = this._clusterDnsName;
                clonedClient._credentials = this._credentials;
                clonedClient._userAgentSuffix = this._userAgentSuffix;
                clonedClient._sdkUserAgent = this._sdkUserAgent;
                clonedClient._userName = this._userName;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
