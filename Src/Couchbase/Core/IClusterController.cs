﻿using System;
using System.Collections.Generic;
using Couchbase.Configuration.Server.Providers;

namespace Couchbase.Core
{
    internal interface IClusterController : IConfigPublisher, IDisposable
    {
        List<IConfigProvider> ConfigProviders { get; }

        IConfigProvider GetProvider(string name);

        IBucket CreateBucket(string bucketName);

        IBucket CreateBucket(string bucketName, string password);

        void DestroyBucket(IBucket bucket);
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2014 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion