using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTestStudio
{
    public interface UITestPanel
    {
        void Load();
    }

    public interface UITestTab
    {
        void LoadUI();
    }

    public interface UIActionControl
    {
        void LoadUI();
    }

    public interface UIArrowControl
    {
        void LoadUI();
    }
}
