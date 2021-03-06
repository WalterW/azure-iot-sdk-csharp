﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Azure.Devices.Shared;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Azure.Devices.Client.Transport
{
    public class AmqpTransportClient : TransportClient
    {
        public AmqpTransportClient() : base()
        {

        }

        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "context", Justification = "Work in progress")]
        public AmqpTransportClient(TransportFallbackType transportFallback) : base(transportFallback)
        {
        }

        public override void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
