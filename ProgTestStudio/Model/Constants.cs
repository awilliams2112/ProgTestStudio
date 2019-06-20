using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTestStudio.Model
{
    public class Constants
    {
        public class ActionTypeNames
        {
            public string Sql = "SQL";
            public string Rest = "Rest";
            public string Assert = "Assert";
        }
    }

    public struct ActionType
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
