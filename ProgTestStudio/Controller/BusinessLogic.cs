using ProgTestStudio.Model;
using System.Collections.Generic;

namespace ProgTestStudio.Controller
{
    public class BusinessLogic
    {
        private static BusinessLogic _instance;

        public List<ActionBase> Data { get; set; } = new List<ActionBase>();

        public static BusinessLogic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BusinessLogic();
                    return _instance;
                }
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
