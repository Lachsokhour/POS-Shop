using POS_Shop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop.Utils
{
    public partial class FormAlertNotification : Form
    {
        public FormAlertNotification()
        {
            InitializeComponent();
        }

        public enum Action
        {
            Wait,
            Start,
            Close
        }

        public enum Type
        {
            Success,
            Warning,
            Error,
            Info
        }

        private FormAlertNotification.Action action;
        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Action.Wait:
                    timer1.Interval = 5000;
                    action = Action.Close;
                    break;
                case FormAlertNotification.Action.Start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = FormAlertNotification.Action.Wait;
                        }
                    }
                    break;
                case Action.Close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = Action.Close;
        }

        public void ShowAlert(string msg, Type type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 5; i++)
            {
                fname = "alert" + i.ToString();
                FormAlertNotification frm = (FormAlertNotification)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case Type.Success:
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case Type.Error:
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    break;
                case Type.Info:
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case Type.Warning:
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    break;
            }


            this.labelMsg.Text = msg;
            this.BringToFront();
            this.TopMost = true;
            this.Show();
            this.action = Action.Start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
