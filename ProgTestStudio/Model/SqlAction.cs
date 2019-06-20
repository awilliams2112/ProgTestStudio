using System.Collections.Generic;

namespace ProgTestStudio.Model
{
    public class SqlAction : ActionBase
    {
        public string ConectionString { get; set; }
        public string Statement { get; set; }
        public Dictionary<string, string> Args { get; set; }
    }
}
