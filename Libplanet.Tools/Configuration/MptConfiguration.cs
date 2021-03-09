using System.Collections.Generic;

namespace Libplanet.Tools.Configuration
{
    public struct MptConfiguration
    {
        public MptConfiguration(Dictionary<string, string> aliases)
        {
            Aliases = aliases;
        }

        public Dictionary<string, string> Aliases { get; set; }
    }
}
