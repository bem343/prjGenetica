using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjGenetica
{
        public static class MyExtensions
        {
            public static System.Drawing.Icon ToIcon(this System.Drawing.Image instance)
            {
                using (System.Drawing.Bitmap bm = (System.Drawing.Bitmap)instance)
                {
                    return System.Drawing.Icon.FromHandle(bm.GetHicon());
                }
            }
        }
}
