/*
 * Copyright (c) Contributors, http://virtual-planets.org/
 * See CONTRIBUTORS.TXT for a full list of copyright holders.
 * For an explanation of the license of each contributor and the content it 
 * covers please see the Licenses directory.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the Virtual Universe Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System.IO;
using System.Text;
using Nini.Config;
using Universe.Framework.Modules;
using Universe.Framework.Servers;
using Universe.Framework.Servers.HttpServer;
using Universe.Framework.Servers.HttpServer.Implementation;
using Universe.Framework.Services;

namespace Universe.Services.API.WebAPI
{
	public class MarketPlaceAPI : IService
	{
		#region IService implementation

		public void Initialize(IConfigSource config, IRegistryCore registry)
		{
		}
        
		public void Start(IConfigSource config, IRegistryCore registry)
		{
			MainServer.Instance.AddStreamHandler(new GenericStreamHandler("GET", "/API/MarketPlace/", HandleMarketPlace));
		}
        
		public void FinishedStartup()
		{
		}

		#endregion
        
		public byte[] HandleMarketPlace(string path, Stream request, OSHttpRequest httpRequest, OSHttpResponse httpResponse)
		{
			return Encoding.UTF8.GetBytes("");
		}
	}
}