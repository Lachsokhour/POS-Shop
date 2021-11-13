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

namespace POS_Shop.Stock
{
    public partial class FormStockIn : Form, IBehaviorForm
    {
        private bool isAddMode;
        private StockIn curStockIn = new StockIn();

        public FormStockIn()
        {
            InitializeComponent();
        }

        public FormStockIn(bool isAddMode, BindingSource source)
        {
            InitializeComponent();
            this.isAddMode = isAddMode;
            SetLabelTitle();
            if (source != null)
            {
                curStockIn = (StockIn)source.Current;
                SetValueToFieldWhenEditMode();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToList();
        }

        private void BackToList()
        {
            ParentForm form = Application.OpenForms["ParentForm"] as ParentForm;
            if (form != null)
                form.openChildFormInPanel(new FormListStockIn());
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, "[^0-9]"))
            {
                ShowAlert("Please enter only numbers.", FormAlertNotification.Type.Info);
                txtQty.Text = txtQty.Text.Remove(txtQty.Text.Length - 1);
            }
        }

        public void ClearValue()
        {
            txtNote.Text = "";
            txtPriceIn.Text = "";
            txtQty.Text = "";
            comboBoxProduct.SelectedIndex = 0;
            dateExpired.Value = DateTime.Now;
            dateIn.Value = DateTime.Now;
        }

        public void SetValueToFieldWhenEditMode()
        {
            if(!isAddMode)
            {
                txtNote.Text = curStockIn.Note;
                txtPriceIn.Text = curStockIn.PriceIn.ToString();
                txtQty.Text = curStockIn.Qty.ToString();
                dateExpired.Value = curStockIn.DateExpired;
                dateIn.Value = curStockIn.DateIn;
                comboBoxProduct.SelectedValue = curStockIn.ProductId;
            }
        }

        public void LoadValue()
        {

        }

        public void SetLabelTitle()
        {
            groupFormStockIn.Text = isAddMode ? "Add New Stock" : "Edit Stock";
        }

        public void ShowAlert(string msg, FormAlertNotification.Type type)
        {
            FormAlertNotification formAlert = new FormAlertNotification();
            formAlert.ShowAlert(msg, type);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var stockIn = SetValue();
            if(stockIn != null)
            {
                if(stockIn.create())
                {   
                    if(!isAddMode)
                    {
                        BackToList();
                    }
                    ClearValue();
                }
            }
        }

        private void FormStockIn_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void LoadProduct()
        {
            comboBoxProduct.DataSource = new Product().readAll();
            comboBoxProduct.DisplayMember = "NameEn";
            comboBoxProduct.ValueMember = "Id";
        }

        private StockIn SetValue()
        {
            if (txtPriceIn.Text == "")
            {
                ShowAlert("Please enter price in.", FormAlertNotification.Type.Warning);
                txtPriceIn.Focus();
                return null;
            }
            else if (txtQty.Text == "")
            {
                ShowAlert("Please enter qty.", FormAlertNotification.Type.Warning);
                txtQty.Focus();
                return null;
            }
            else if (dateExpired.Value < dateIn.Value || dateExpired.Value == dateIn.Value)
            {
                ShowAlert("Date expired should be bigger \n than date in.", FormAlertNotification.Type.Warning);
                dateExpired.Focus();
                return null;
            }
            else
            {
                var product = (Product)comboBoxProduct.SelectedItem;
                curStockIn.Note = txtNote.Text.Trim();
                curStockIn.PriceIn = float.Parse(txtPriceIn.Text);
                curStockIn.DateExpired = dateExpired.Value;
                curStockIn.DateIn = dateIn.Value;
                curStockIn.ProductId = product.Id;
                curStockIn.Qty = int.Parse(txtQty.Text);
                return curStockIn;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValue();
        }
    }
}
