using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Emby.Zattoo.Models;
using MediaBrowser.Common.Net;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Serialization;

namespace Emby.Zattoo.Api
{
	class Session
	{
		private string _authUrl;
		private string _url;

		private readonly ILogger _logger;
		private readonly IHttpClient _httpClient;
		private readonly IJsonSerializer _jsonSerializer;

		public Session(string authUrl, string url, ILogger logger, IHttpClient httpClient, IJsonSerializer jsonSerializer)
		{
			_authUrl = authUrl;
			_url = url;
			_logger = logger;
			_httpClient = httpClient;
			_jsonSerializer = jsonSerializer;
		}

		public async Task Announce(CancellationToken cancellationToken)
		{
			var req = new AnnounceRequest(await FetchAppToken(cancellationToken));
			using (var stream = await _httpClient.Post(new HttpRequestOptions {
				Url = _url + "/zapi/session/hello",
				RequestContent = _jsonSerializer.SerializeToString(req),
				CancellationToken = cancellationToken

			}).ConfigureAwait(false)) {
				
			}
		}

		private async Task<string> FetchAppToken(CancellationToken cancellationToken)
		{
			using (var stream = await _httpClient.Get(new HttpRequestOptions {
				Url = _url,
				CancellationToken = cancellationToken

			}).ConfigureAwait(false)) {
				var reader = new StreamReader(stream);
				var html = reader.ReadToEnd();
				var regex = new Regex(@"window\.appToken\s*=\s*'(.*)'", RegexOptions.IgnoreCase);
				var match = regex.Match(html);
				if (match.Success) {
					return match.Groups[1].Value;
				}
			}
			return null;
		}
	}
}
