using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller
{
    class size_listener
    {
        Panel GetSize;
        Panel SetSize;
        int fixHeight = 0;
        int fixWidth = 0;
        public size_listener(
            Panel GetSize, 
            Panel SetSize,
            int fixHeight,
            int fixWidth)
        {
            this.GetSize = GetSize;
            this.SetSize = SetSize;
            this.fixHeight = fixHeight;
            this.fixWidth = fixWidth;
            GetSize.Resize += new EventHandler(Resize);
        }
        private void Resize(object sender, System.EventArgs e)
        {
            if (fixHeight == 0 && fixWidth == 0)
            {
                SetSize.Width = GetSize.Width;
                SetSize.Height = GetSize.Height;
            }
            if (fixHeight != 0)
            {
                SetSize.Height = fixHeight;
                SetSize.Width = GetSize.Width;
            }
            if (fixWidth != 0)
            {
                SetSize.Height = GetSize.Height;
                SetSize.Width = fixWidth;
            }
        }
    }
}
