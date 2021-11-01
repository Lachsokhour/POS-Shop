using POS_Shop.Models;
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

namespace POS_Shop.Employees
{
    public partial class FormEmployee : Form
    {
        private bool addMode = true;
        private BindingSource source = new BindingSource();
        private int id = 0;
        public FormEmployee()
        {
            InitializeComponent();
            SetLabelTitle();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            InitPositionDropDown();
            EmployeeLoadValue();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = SetValue();
            if(emp != null)
            {
                if(addMode)
                {
                    if (emp.create())
                    {
                        EmployeeLoadValue();
                        ClearValue();
                    }
                }else
                {
                    if (emp.update())
                    {
                        EmployeeLoadValue();
                        ClearValue();
                    }
                }
            }
            
        }

        private Employee SetValue()
        {
            if(txtNameEn.Text == "")
            {
                ShowAlertMsg("Please enter emplyee's username.", FormAlertNotification.Type.Warning);
                txtNameEn.Focus();
                return null;
            }
            else if (txtPassword.Text == "")
            {
                ShowAlertMsg("Please enter emplyee's password.", FormAlertNotification.Type.Warning);
                txtPassword.Focus();
                return null;
            }
            else if (txtPhone.Text == "")
            {
                ShowAlertMsg("Please enter emplyee's phone number.", FormAlertNotification.Type.Warning);
                txtPhone.Focus();
                return null;
            }
            else
            {
                Employee emp = new Employee();
                Position position = (Position)comboBoxPosition.SelectedItem;
                emp.NameEn = txtNameEn.Text.Trim();
                emp.NameKh = txtNameKh.Text.Trim();
                emp.Phone = txtPhone.Text.Trim();
                emp.Password = txtPassword.Text.Trim();
                emp.Address = txtAddress.Text.Trim();
                emp.PositionId = position.Value;
                emp.Id = this.id;
                return emp;
            }
        }


        private void EmployeeLoadValue()
        {
            var employees = new Employee().readAll();
            source = new BindingSource(employees, null);
            gridEmployee.DataSource = source;
            source.ResetBindings(false);
            gridEmployee.AllowUserToAddRows = false;
            gridEmployee.RowTemplate.Height = 30;
            gridEmployee.Columns["Id"].Visible = false;
            gridEmployee.Columns["PositionId"].Visible = false;
            gridEmployee.Columns["Password"].Visible = false;
            gridEmployee.Columns["NameEn"].HeaderText = "Username (En)";
            gridEmployee.Columns["NameKh"].HeaderText = "Username (Kh)";
            gridEmployee.Columns["NameKh"].DefaultCellStyle.Font = new Font("Kh Battambang", 10);
            SetValueToFieldWhenEditMode();
            gridEmployee.Refresh();
        }

        private void ClearValue()
        {
            id = 0;
            txtAddress.Text = "";
            txtNameEn.Text = "";
            txtPassword.Text = "";
            txtNameKh.Text = "";
            comboBoxPosition.SelectedIndex = 0;
            txtPhone.Text = "";
            this.addMode = true;
            SetLabelTitle();
        }

        private void InitPositionDropDown()
        {
            Position position = new Position();
            comboBoxPosition.DataSource = position.GetPositions();
            comboBoxPosition.DisplayMember = "Text";
            comboBoxPosition.ValueMember = "Value";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addMode = false;
            SetLabelTitle();
            SetValueToFieldWhenEditMode();
        }

        /// <summary>
        /// Set label of title for inform to user.
        /// </summary>
        private void SetLabelTitle()
        {
            labelTitle.Text = addMode ? "Add Employee" : "Edit Employee";
        }

        private void SetValueToFieldWhenEditMode()
        {
            if(!addMode)
            {
                var currentEmp = (Employee)source.Current;
                txtNameEn.Text = currentEmp.NameEn;
                txtNameKh.Text = currentEmp.NameKh;
                txtAddress.Text = currentEmp.Address;
                txtPhone.Text = currentEmp.Phone;
                txtPassword.Text = currentEmp.Password;
                comboBoxPosition.SelectedValue = new Position().GetPositionByText(currentEmp.Position).Value;
                id = currentEmp.Id;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.addMode = true;
            SetLabelTitle();
            this.ClearValue();
        }

        /// <summary>
        /// Show alert pop up message
        /// </summary>
        /// <param name="msg">message</param>
        /// <param name="type">type of message</param>
        private void ShowAlertMsg(string msg, FormAlertNotification.Type type)
        {
            FormAlertNotification formAlert = new FormAlertNotification();
            formAlert.ShowAlert(msg, type);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var emp = (Employee)source.Current;
            this.id = emp.Id;
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var result = new Employee().delete(id);
                if (result)
                {
                    EmployeeLoadValue();
                }
            }
        }
    }
}
