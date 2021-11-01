using POS_Shop.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Categories
{
    public partial class CategoryForm : SubForm
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.filename);
            var formAlert = new FormAlertNotification();
            formAlert.ShowAlert("Data not found.", FormAlertNotification.Type.Warning);
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
