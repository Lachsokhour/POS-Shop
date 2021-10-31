using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace POS_Shop.Layouts
{
    class POSButton
    {
        public void onMouseHover(Button btn)
        {
            btn.BackColor = Color.FromArgb(72, 158, 231);
            btn.ForeColor = Color.White;
        }

        public void onMouseLeave(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
    }
}
