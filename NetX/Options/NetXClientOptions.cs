﻿using System.Net;

namespace NetX.Options
{
    internal class NetXClientOptions : NetXConnectionOptions
    {
        public INetXClientProcessor Processor { get; }

        public NetXClientOptions(
            INetXClientProcessor processor,
            IPEndPoint endPoint, 
            bool noDelay, 
            int recvBufferSize, 
            int sendBufferSize, 
            bool duplex,
            int duplexTimeout,
            bool copyBuffer,
            int socketTimeout,
            bool disconnectOnTimeout) : base(
                endPoint, 
                noDelay, 
                recvBufferSize, 
                sendBufferSize, 
                duplex,
                duplexTimeout,
                copyBuffer,
                socketTimeout,
                disconnectOnTimeout)
        {
            Processor = processor;
        }
    }
}
