using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PWMS.InfoAddForm
{
    // 员工提示设置
    public partial class F_ClewSet : Form
    {
        public F_ClewSet()
        {
            InitializeComponent();
        }
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();
        private void F_ClewSet_Load(object sender, EventArgs e)
        {
            SqlDataReader SQLDR = MyDataClass.getcom("Select * from tb_Clew where Kind=" + this.Tag);
            if (SQLDR.Read())
            {
                if ((int)SQLDR[3] == 0)
                    checkBox1.Checked = false;
                else
                    checkBox1.Checked = true;
                numericUpDown1.Value = (int)SQLDR[1];
            }
        }
   
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool Tbool = true;
            if (checkBox1.Checked == true)
                Tbool = true;
            else
                Tbool = false;
            groupBox1.Enabled = Tbool;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Un = 0;
            if (checkBox1.Checked == true)
                Un = 1;
            else
                Un = 0;
            MyDataClass.getsqlcom("update tb_Clew set Fate=" + numericUpDown1.Value + ",Unlock=" + Un + " where Kind=" + this.Tag);
        }

    }
}