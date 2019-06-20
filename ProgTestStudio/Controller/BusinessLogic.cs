using ProgTestStudio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTestStudio.Controller
{
    public class BusinessLogic
    {
        private static BusinessLogic _instance;
        
        public List<ActionBase> Data { get; set; }

        public static BusinessLogic Instance
        {
            get
            {
                if (_instance == null)
                    return new BusinessLogic();
                else
                    return _instance;
            }
        }

        private BusinessLogic()
        {

        }

        public void ReconcilePosition(int oldIndex, int newIndex)
        {
            var entry = Data[oldIndex];
            Data.RemoveAt(oldIndex);
            Data.Insert(newIndex, entry);
        }

    }
}
