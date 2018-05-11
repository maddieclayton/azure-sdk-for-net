﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Available authentication types for an <see cref="HttpLinkedService"/>.
    /// </summary>
    public static class HttpAuthenticationType
    {
        /// <summary>
        /// Basic authentication type.
        /// </summary>
        public const string Basic = "Basic";

        /// <summary>
        /// Anonymous authentication type.
        /// </summary>
        public const string Anonymous = "Anonymous";

        /// <summary>
        /// Windows authentication type.
        /// </summary>
        public const string Windows = "Windows";

        /// <summary>
        /// Digest authentication type.
        /// </summary>
        public const string Digest = "Digest";

        /// <summary>
        /// ClientCertificate authentication type.
        /// </summary>
        public const string ClientCertificate = "ClientCertificate";
    }
}