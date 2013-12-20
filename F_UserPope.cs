using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PWMS.PerForm
{
    public partial class F_UserPope : Form
    {
        public F_UserPope()
        {
            InitializeComponent();
        }
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule MyMC = new PWMS.ModuleClass.MyModule();

        private void F_UserPope_Shown(object sender, EventArgs e)
        {
            User_ID.Text = ModuleClass.MyModule.User_ID;
            User_Name.Text = ModuleClass.MyModule.User_Name;
            if (User_Name.Text.Trim() == "TSoft")
                User_Save.Enabled = false;
            MyMC.Show_Pope(groupBox2.Controls, ModuleClass.MyModule.User_ID);

        }

        private void User_Save_Click(object sender, EventArgs e)
        {
            MyMC.Amend_Pope(groupBox2.Controls, ModuleClass.MyModule.User_ID);
            if (DataClass.MyMeans.Login_ID == ModuleClass.MyModule.User_ID)
                DataClass.MyMeans.Login_n = 2;
        }

        private void User_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_All_MouseDown(object sender, MouseEventArgs e)
        {
            bool tt = false;
            if (((CheckBox)sender).Checked == true)
                tt = false;
            else
                tt = true;
            foreach (Control C in groupBox2.Controls)
            {
                string sID = C.Name;
                if (sID.IndexOf("User_") > -1)
                {
                    ((CheckBox)C).Checked = tt;
                }
            }
        }

        private void User_Folk_MouseUp(object sender, MouseEventArgs e)
        {
            if (((CheckBox)sender).Checked == false)
            {
                User_All.Checked = false;
            }
        }

        private void User_Setup_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}