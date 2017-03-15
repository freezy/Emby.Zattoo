using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emby.Zattoo.Models
{
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	class AnnounceRequest
	{
		public AnnounceRequest(string clientAppToken)
		{
			client_app_token = clientAppToken;
		}

		public string client_app_token { get; set; }
		public string uuid { get; set; } = "d7512e98-38a0-4f01-b820-5a5cf98141fe";
		public string lang { get; set; } = "en";
		public string format { get; set; } = "json";
	}
}
