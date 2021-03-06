// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net
{
    public interface IWebProxyScript
    {
        void Close();
        bool Load(Uri scriptLocation, string script, Type helperType);
        string Run(string url, string host);
    }
}
