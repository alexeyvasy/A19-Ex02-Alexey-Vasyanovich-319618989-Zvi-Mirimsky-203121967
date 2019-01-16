using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FacebookAppLogic
{
    public static class BackgroundChange
    {
        public static event Action<Color> BackgroundChanged;

        public static void Update(Color i_BackgroundColor)
        {
            BackgroundChanged.Invoke(i_BackgroundColor);
        }
    }
}
