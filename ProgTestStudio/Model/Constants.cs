using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTestStudio.Model
{
    public class Constants
    {
        public enum ExportCodeTypes
        {
            CSharp,
            Powershell
        }

        public enum ActionTypes
        {
            Sql,
            Rest,
            Assert,
            Custom,
            Other
        }

        public class Images
        {
            public static string SqlActionIcon = "Resources\\iconfinder_database_1608662.png";
            public static string RestActionIcon = "Resources\\iconfinder_language_326663.png";
            public static string AssertActionIcon = "Resources\\iconfinder_database_1608662.png";
            public static string CustomActionIcon = "Resources\\iconfinder_database_1608662.png";

        }

        public static ActionTypes GetActionTypeFromName(string name)
        {
            switch(name.ToLower().Trim())
            {
                case "sql":
                    return ActionTypes.Sql;

                case "rest":
                    return ActionTypes.Rest;

                case "assert":
                    return ActionTypes.Assert;

                case "custom":
                    return ActionTypes.Custom;
                    
                default:
                    return ActionTypes.Custom;
            }
        }

        public static string ActionTypeDefaultDescription(ActionTypes type)
        {
            switch(type)
            {
                case ActionTypes.Sql:
                    return "Description for Sql Action";
                    
                case ActionTypes.Rest:
                    return "Description for Rest Action";
                    
                case ActionTypes.Assert:
                    return "Description for Assert Action";
                    
                case ActionTypes.Custom:
                    return "Description for Custom Action";

                default:
                    return "Description for Custom Action";

            }
        }
    }
}
