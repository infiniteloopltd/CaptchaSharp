﻿using CaptchaSharp.Enums;
using System.Linq;

namespace CaptchaSharp.Models
{
    /// <summary>A generic proxy class.</summary>
    public class Proxy
    {
        /// <summary></summary>
        public string Host { get; set; }

        /// <summary></summary>
        public int Port { get; set; }

        /// <summary></summary>
        public ProxyType Type { get; set; }

        /// <summary></summary>
        public string Username { get; set; }

        /// <summary></summary>
        public string Password { get; set; }

        /// <summary>The User-Agent header to be used in requests.</summary>
        public string UserAgent { get; set; }

        /// <summary>The cookies needed to get to the page where the captcha is shown.</summary>
        public (string, string)[] Cookies { get; set; }

        /// <summary>Whether the proxy requires authentication.</summary>
        public bool RequiresAuthentication => !string.IsNullOrEmpty(Username);

        /// <summary></summary>
        public Proxy() { }

        /// <summary></summary>
        public Proxy(string host, int port, ProxyType type = ProxyType.HTTP, string username = "", string password = "")
        {
            Host = host;
            Port = port;
            Type = type;
            Username = username;
            Password = password;
        }

        internal string GetCookieString()
            => Cookies != null ? string.Join("; ", Cookies.Select(c => $"{c.Item1}={c.Item2}")) : string.Empty;

      
    }
}
