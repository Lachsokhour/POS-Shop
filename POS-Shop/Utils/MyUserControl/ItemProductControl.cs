using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace POS_Shop.Utils.MyUserControl
{
    public partial class ItemProductControl : UserControl
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public ItemProductControl()
        {
            InitializeComponent();

            // move icon order to front.
            this.panelItem.SendToBack();

            // change border
            //panelItem.BorderStyle = BorderStyle.None;
            panelItem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelItem.Width, panelItem.Height, 20, 20));
        }

        private void ItemProductControl_Load(object sender, EventArgs e)
        {
        }

        private void picOrder_Click(object sender, EventArgs e)
        {
            ItemDetails.Qty++;
            ItemDetailsStatic = ItemDetails;
            //Rows.Add(LabelProductName, LabelPrice, Qty, LabelPrice);    
        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
