using System.Collections.Generic;

namespace ProgTestStudio.Model
{
    public class RestAction : ActionBase
    {
        public string Url { get; set; }
        public Dictionary<string, string> Headers { get; set; }
        public string Payload { get; set; }
    }
}
