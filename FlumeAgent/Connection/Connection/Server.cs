﻿using System;

namespace FlumeAgent
{
	internal class Server
	{
		public const int DefaultPort = 2014;

		public Server(string host = "127.0.0.1", int port = DefaultPort)
		{
			Host = host;
			Port = port;
		}

		public int Port { get; private set; }

		public string Host { get; private set; }

		public override string ToString()
		{
			return String.Concat(Host, ":", Port);
		}
	}
}