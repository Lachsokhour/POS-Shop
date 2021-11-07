using POS_Shop.Models;
using POS_Shop.Utils;
using POS_Shop.Utils.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Settings
{
    public partial class ExchangeForm : Form
    {
        private Exchange currExchange;
        public ExchangeForm()
        {
            InitializeComponent();
        }

        private void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            FormAlertNotification formAlert = new FormAlertNotification();
            formAlert.ShowAlert(msg, type);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Exchange exchange = SetValue();
            if(exchange != null)
            {
                if(exchange.create())
                {
                    labelInfo.Text = LoadValue().Info();
                }
            }
        }

        private Exchange LoadValue()
        {
            return new Exchange().SelectFirstExchange();
        }

        private Exchange SetValue()
        {
            if(txtDollar.Text == "")
            {
                ShowAlert("Please enter dollar.", FormAlertNotification.Type.Warning);
                txtDollar.Focus();
                return null;
            }else if(txtRiel.Text == "")
            {
                ShowAlert("Please enter riel.", FormAlertNotification.Type.Warning);
                txtRiel.Focus();
                return null;
            }else
            {
                try
                {
                    currExchange.Dollar = float.Parse(txtDollar.Text);
                    currExchange.Riel = txtRiel.Text;
                    return currExchange;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        private void txtRiel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtRiel.Text, "[^0-9]"))
            {
                ShowAlert("Please enter only numbers.", FormAlertNotification.Type.Info);
                txtRiel.Text = txtRiel.Text.Remove(txtRiel.Text.Length - 1);
            }
        }

        private void txtDollar_TextChanged(object sender, EventArgs e)
        {
            /*if (System.Text.RegularExpressions.Regex.IsMatch(txtDollar.Text, @"/^[0-9]{3}+.+[0-9]{2}$/"))
            {
                ShowAlert("Please enter only numbers.", FormAlertNotification.Type.Info);
                txtDollar.Text = txtDollar.Text.Remove(txtDollar.Text.Length - 1);
            }*/
        }

        private void ExchangeForm_Load(object sender, EventArgs e)
        {
            currExchange = LoadValue();
            if(currExchange != null)
            {
                txtDollar.Text = currExchange.Dollar.ToString();
                txtRiel.Text = currExchange.Riel;
                labelInfo.Text = currExchange.Info();
            }
        }
    }
}
