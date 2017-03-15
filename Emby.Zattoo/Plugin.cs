using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emby.Zattoo.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Emby.Zattoo
{
	public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
	{
		public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
		{

		}

		public override string Name { get; } = "Zattoo";
		public override string Description { get; } = "Provides live TV using Zattoo as a back-end.";

		public IEnumerable<PluginPageInfo> GetPages()
		{
			 return new[] {
                new PluginPageInfo {
                    Name = Name,
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.configPage.html"
                }
            };
		}
	}
}
