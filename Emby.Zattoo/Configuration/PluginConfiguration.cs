using MediaBrowser.Model.Plugins;

namespace Emby.Zattoo.Configuration
{
	public class PluginConfiguration : BasePluginConfiguration
	{
		public string ZapiAuthUrl { get; set; }
		public string ZapiUrl { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool Swiss { get; set; }
		public int MaxBandwidth { get; set; }
		public string AudioStream { get; set; }

		public PluginConfiguration()
		{
			ZapiAuthUrl = "https://zattoo.com";
			ZapiUrl = "http://zattoo.com";
			Username = "";
			Password = "";
			Swiss = true;
			MaxBandwidth = 5000;
			AudioStream = "B";
		}
	}
}
