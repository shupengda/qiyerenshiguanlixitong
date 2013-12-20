using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PWMS.ModuleClass
{
    class MyModule
    {
        #region  ��������
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();   //����MyMeans���һ�������Ե����䷽��
        public static string ADDs = "";  //�����洢��ӻ��޸ĵ�SQL���
        public static string FindValue = "";  //�洢��ѯ����
        public static string Address_ID = "";  //�洢ͨѶ¼����޸�ʱ��ID���
        public static string User_ID = "";  //�洢�û���ID���
        public static string User_Name = "";    //�洢�û���
        #endregion

        #region  ����ĵ���
        /// <summary>
        /// ����ĵ���.
        /// </summary>
        /// <param name="FrmName">���ô����Text����ֵ</param>
        /// <param name="n">��ʶ</param>
        public void Show_Form(string FrmName, int n)
        {
            if (n == 1)
            {
                if (FrmName == "���µ������")  //�жϵ�ǰҪ�򿪵Ĵ���
                {
                    PerForm.F_ManFile FrmManFile = new PWMS.PerForm.F_ManFile();
                    FrmManFile.Text = "���µ������";   //���ô�������
                    FrmManFile.ShowDialog();    //��ʾ����
                    FrmManFile.Dispose();
                }
                if (FrmName == "�������ϲ�ѯ")
                {
                    PerForm.F_Find FrmFind = new PWMS.PerForm.F_Find();
                    FrmFind.Text = "�������ϲ�ѯ";
                    FrmFind.ShowDialog();
                    FrmFind.Dispose();
                }
                if (FrmName == "��������ͳ��")
                {
                    PerForm.F_Stat FrmStat = new PWMS.PerForm.F_Stat();
                    FrmStat.Text = "��������ͳ��";
                    FrmStat.ShowDialog();
                    FrmStat.Dispose();
                }
                if (FrmName == "Ա��������ʾ")
                {
                    InfoAddForm.F_ClewSet FrmClewSet = new PWMS.InfoAddForm.F_ClewSet();
                    FrmClewSet.Text = "Ա��������ʾ";   //���ô�������
                    FrmClewSet.Tag = 1; //���ô����Tag���ԣ������ڴ򿪴���ʱ�жϴ������ʾ����
                    FrmClewSet.ShowDialog();    //��ʾ����
                    FrmClewSet.Dispose();
                }
                if (FrmName == "Ա����ͬ��ʾ")
                {
                    InfoAddForm.F_ClewSet FrmClewSet = new PWMS.InfoAddForm.F_ClewSet();
                    FrmClewSet.Text = "Ա����ͬ��ʾ";
                    FrmClewSet.Tag = 2;
                    FrmClewSet.ShowDialog();
                    FrmClewSet.Dispose();
                }
                if (FrmName == "�ճ�����")
                {
                    PerForm.F_WordPad FrmWordPad = new PWMS.PerForm.F_WordPad();
                    FrmWordPad.Text = "�ճ�����";
                    FrmWordPad.ShowDialog();
                    FrmWordPad.Dispose();
                }
                if (FrmName == "ͨѶ¼")
                {
                    PerForm.F_AddressList FrmAddressList = new PWMS.PerForm.F_AddressList();
                    FrmAddressList.Text = "ͨѶ¼";
                    FrmAddressList.ShowDialog();
                    FrmAddressList.Dispose();
                }
                if (FrmName == "����/��ԭ���ݿ�")
                {
                    PerForm.F_HaveBack FrmHaveBack = new PWMS.PerForm.F_HaveBack();
                    FrmHaveBack.Text = "����/��ԭ���ݿ�";
                    FrmHaveBack.ShowDialog();
                    FrmHaveBack.Dispose();
                }
                if (FrmName == "������ݿ�")
                {
                    PerForm.F_ClearData FrmClearData = new PWMS.PerForm.F_ClearData();
                    FrmClearData.Text = "������ݿ�";
                    FrmClearData.ShowDialog();
                    FrmClearData.Dispose();
                }

                if (FrmName == "���µ�¼")
                {
                    F_Login FrmLogin = new F_Login();
                    FrmLogin.Tag = 2;
                    FrmLogin.ShowDialog();
                    FrmLogin.Dispose();
                }
                if (FrmName == "�û�����")
                {
                    PerForm.F_User FrmUser = new PWMS.PerForm.F_User();
                    FrmUser.Text = "�û�����";
                    FrmUser.ShowDialog();
                    FrmUser.Dispose();
                }
               
            }
            if (n == 2)
            {
                String FrmStr = ""; //��¼��������
                if (FrmName == "�����������")  //�ж�Ҫ�򿪵Ĵ���
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Folk";   //SQL���
                    DataClass.MyMeans.Mean_Table = "tb_Folk";   //����
                    DataClass.MyMeans.Mean_Field = "FolkName";  //��ӡ��޸����ݵ��ֶ���
                    FrmStr = FrmName;
                }
                if (FrmName == "ְ���������")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_EmployeeGenre";
                    DataClass.MyMeans.Mean_Table = "tb_EmployeeGenre";
                    DataClass.MyMeans.Mean_Field = "EmployeeName";
                    FrmStr = FrmName;
                }
                if (FrmName == "�Ļ��̶�����")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Kultur";
                    DataClass.MyMeans.Mean_Table = "tb_Kultur";
                    DataClass.MyMeans.Mean_Field = "KulturName";
                    FrmStr = FrmName;
                }
                if (FrmName == "������ò����")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Visage";
                    DataClass.MyMeans.Mean_Table = "tb_Visage";
                    DataClass.MyMeans.Mean_Field = "VisageName";
                    FrmStr = FrmName;
                }
                if (FrmName == "�����������")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Branch";
                    DataClass.MyMeans.Mean_Table = "tb_Branch";
                    DataClass.MyMeans.Mean_Field = "BranchName";
                    FrmStr = FrmName;
                }
                if (FrmName == "�����������")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Laborage";
                    DataClass.MyMeans.Mean_Table = "tb_Laborage";
                    DataClass.MyMeans.Mean_Field = "LaborageName";
                    FrmStr = FrmName;
                }
                if (FrmName == "ְ���������")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Business";
                    DataClass.MyMeans.Mean_Table = "tb_Business";
                    DataClass.MyMeans.Mean_Field = "BusinessName";
                    FrmStr = FrmName;
                }
                if (FrmName == "ְ���������")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Duthcall";
                    DataClass.MyMeans.Mean_Table = "tb_Duthcall";
                    DataClass.MyMeans.Mean_Field = "DuthcallName";
                    FrmStr = FrmName;
                }
                if (FrmName == "�����������")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_RPKind";
                    DataClass.MyMeans.Mean_Table = "tb_RPKind";
                    DataClass.MyMeans.Mean_Field = "RPKind";
                    FrmStr = FrmName;
                }
                if (FrmName == "���±��������")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_WordPad";
                    DataClass.MyMeans.Mean_Table = "tb_WordPad";
                    DataClass.MyMeans.Mean_Field = "WordPad";
                    FrmStr = FrmName;
                }
                InfoAddForm.F_Basic FrmBasic = new PWMS.InfoAddForm.F_Basic();
                FrmBasic.Text = FrmStr; //���ô�������
                FrmBasic.ShowDialog();  //��ʾ���õĴ���
                FrmBasic.Dispose();
            }
        }
        #endregion

        #region  ��StatusStrip�ؼ��е���Ϣ��ӵ�treeView�ؼ���
        /// <summary>
        /// ��ȡ�˵��е���Ϣ.
        /// </summary>
        /// <param name="treeV">TreeView�ؼ�</param>
        /// <param name="MenuS">MenuStrip�ؼ�</param>
        public void GetMenu(TreeView treeV, MenuStrip MenuS)
        {
            for (int i = 0; i < MenuS.Items.Count; i++) //����MenuStrip����е�һ���˵���
            {
                //��һ���˵����������ӵ�TreeView����ĸ��ڵ��У������õ�ǰ�ڵ���ӽڵ�newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
                //����ǰ�˵�������������Ϣ���뵽ToolStripDropDownItem������
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                //�жϵ�ǰ�˵������Ƿ��ж����˵���
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //���������˵���
                    {
                        //�������˵�������ӵ�TreeView������ӽڵ�newNode1�У������õ�ǰ�ڵ���ӽڵ�newNode2
                        TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
                        //����ǰ�˵�������������Ϣ���뵽ToolStripDropDownItem������
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        //�ж϶����˵������Ƿ��������˵���
                        if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++)    //���������˵���
                                //�������˵�������ӵ�TreeView������ӽڵ�newNode2��
                                newNode2.Nodes.Add(newmenu2.DropDownItems[p].Text);
                    }
            }
        }
        #endregion

        #region  �Զ����
        /// <summary>
        /// �������Ϣʱ�Զ�������.
        /// </summary>
        /// <param name="TableName">����</param>
        /// <param name="ID">�ֶ���</param>
        /// <returns>����String����</returns>
        public String GetAutocoding(string TableName, string ID)
        {
            //����ָ������ID��Ϊ���ļ�¼
            SqlDataReader MyDR = MyDataClass.getcom("select max(" + ID + ") NID from " + TableName);
            int Num = 0;
            if (MyDR.HasRows)   //�����ҵ���¼ʱ
            {
                MyDR.Read();    //��ȡ��ǰ��¼
                if (MyDR[0].ToString() == "")
                    return "0001";
                Num = Convert.ToInt32(MyDR[0].ToString());  //����ǰ�ҵ��������ת��������
                ++Num;  //����ż�1
                string s = string.Format("{0:0000}", Num);  //������ֵת����ָ����ʽ���ַ���
                return s;   //�����Զ����ɵı��
            }
            else
            {
                return "0001";  //�����ݱ�û�м�¼ʱ������0001
            }
        }
        #endregion

        #region  ��comboBox�ؼ��������ݱ��е�����
        /// <summary>
        /// ��̬��comboBox�ؼ��������б��������.
        /// </summary>
        /// <param name="cobox">comboBox�ؼ�</param>
        /// <param name="TableName">���ݱ�����</param>
        public void CoPassData(ComboBox cobox, string TableName)
        {
            cobox.Items.Clear();
            DataClass.MyMeans MyDataClsaa = new PWMS.DataClass.MyMeans();
            SqlDataReader MyDR = MyDataClsaa.getcom("select * from " + TableName);
            if (MyDR.HasRows)
            {
                while (MyDR.Read())
                {
                    if (MyDR[1].ToString() != "" && MyDR[1].ToString()!=null)
                        cobox.Items.Add(MyDR[1].ToString());
                }
            }
        }
        #endregion

        #region  ��comboBox�ؼ����ݸ�ʡ�е�����
        /// <summary>
        /// ��̬��comboBox�ؼ��������б����ʡ��.
        /// </summary>
        /// <param name="cobox">comboBox�ؼ�</param>
        /// <param name="SQLstr">SQL���</param>
        /// <param name="n">�ֶ�λ��</param>
        public void CityInfo(ComboBox cobox, string SQLstr, int n)
        {
            cobox.Items.Clear();
            DataClass.MyMeans MyDataClsaa = new PWMS.DataClass.MyMeans();
            SqlDataReader MyDR = MyDataClsaa.getcom(SQLstr);
            if (MyDR.HasRows)
            {
                while (MyDR.Read())
                {
                    if (MyDR[n].ToString() != "" && MyDR[n].ToString() != null)
                        cobox.Items.Add(MyDR[n].ToString());
                }
            }
        }
        #endregion

        #region  ������ת����ָ���ĸ�ʽ
        /// <summary>
        /// ������ת����yyyy-mm-dd��ʽ.
        /// </summary>
        /// <param name="NDate">����</param>
        /// <returns>����String����</returns>
        public string Date_Format(string NDate)
        {
            string sm,sd;
            int y, m, d;
            try
            {
                y = Convert.ToDateTime(NDate).Year;
                m = Convert.ToDateTime(NDate).Month;
                d = Convert.ToDateTime(NDate).Day;
            }
            catch
            {
                return "";
            }
            if (y == 1900)
                return "";
            if (m < 10)
                sm = "0" + Convert.ToString(m);
            else
                sm = Convert.ToString(m);
            if (d < 10)
                sd = "0" + Convert.ToString(d);
            else
                sd = Convert.ToString(d);
            return Convert.ToString(y) + "-" + sm + "-" + sd;
        }
        #endregion

        #region  ��ʱ��ת����ָ���ĸ�ʽ
        /// <summary>
        /// ��ʱ��ת����yyyy-mm-dd��ʽ.
        /// </summary>
        /// <param name="NDate">����</param>
        /// <returns>����String����</returns>
        public string Time_Format(string NDate)
        {
            string sh, sm, se;
            int hh, mm, ss;
            try
            {
                hh = Convert.ToDateTime(NDate).Hour;
                mm = Convert.ToDateTime(NDate).Minute;
                ss = Convert.ToDateTime(NDate).Second;
                
            }
            catch
            {
                return "";
            }
            sh = Convert.ToString(hh);
            if (sh.Length < 2)
                sh = "0" + sh;
            sm = Convert.ToString(mm);
            if (sm.Length < 2)
                sm = "0" + sm;
            se = Convert.ToString(ss);
            if (se.Length < 2)
                se = "0" + se;
            return sh + sm + se;
        }
        #endregion

        #region  ����MaskedTextBox�ؼ��ĸ�ʽ
        /// <summary>
        /// ��MaskedTextBox�ؼ��ĸ�ʽ��Ϊyyyy-mm-dd��ʽ.
        /// </summary>
        /// <param name="NDate">����</param>
        /// <param name="ID">���ݱ�����</param>
        /// <returns>����String����</returns>
        public void MaskedTextBox_Format(MaskedTextBox MTBox)
        {
            MTBox.Mask = "0000-00-00";
            MTBox.ValidatingType = typeof(System.DateTime);
        }
        #endregion

        #region  �ð�ť�������ݼ�¼�ƶ�ʱ���ı䰴ť�Ŀ���״̬
        /// <summary>
        /// ���ð�ť�Ƿ����.
        /// </summary>
        /// <param name="B1">�׼�¼��ť</param>
        /// <param name="B2">��һ����¼��ť</param>
        /// <param name="B3">��һ����¼��ť</param>
        /// <param name="B4">β��¼��ť</param>
        /// <param name="NDate">B1��ʶ</param>
        /// <param name="NDate">B2��ʶ</param>
        /// <param name="NDate">B3��ʶ</param>
        /// <param name="NDate">B4��ʶ</param>
        public void Ena_Button(Button B1, Button B2, Button B3, Button B4, int n1, int n2, int n3, int n4)
        {
            B1.Enabled = Convert.ToBoolean(n1);
            B2.Enabled = Convert.ToBoolean(n2);
            B3.Enabled = Convert.ToBoolean(n3);
            B4.Enabled = Convert.ToBoolean(n4);
        }
        #endregion

        #region  �������ָ���Ŀؼ�
        /// <summary>
        /// ������пؼ��µ����пؼ�.
        /// </summary>
        /// <param name="Con">���ӻ��ؼ�</param>
        public void Clear_Control(Control.ControlCollection Con)
        {
            foreach (Control C in Con){ //�������ӻ�����е����пؼ�
                if (C.GetType().Name == "TextBox")  //�ж��Ƿ�ΪTextBox�ؼ�
                    if (((TextBox)C).Visible == true)   //�жϵ�ǰ�ؼ��Ƿ�Ϊ��ʾ״̬
                        ((TextBox)C).Clear();   //��յ�ǰ�ؼ�
                if (C.GetType().Name == "MaskedTextBox")  //�ж��Ƿ�ΪMaskedTextBox�ؼ�
                    if (((MaskedTextBox)C).Visible == true)   //�жϵ�ǰ�ؼ��Ƿ�Ϊ��ʾ״̬
                        ((MaskedTextBox)C).Clear();   //��յ�ǰ�ؼ�
                if (C.GetType().Name == "ComboBox")  //�ж��Ƿ�ΪComboBox�ؼ�
                    if (((ComboBox)C).Visible == true)   //�жϵ�ǰ�ؼ��Ƿ�Ϊ��ʾ״̬
                        ((ComboBox)C).Text = "";   //��յ�ǰ�ؼ���Text����ֵ
                if (C.GetType().Name == "PictureBox")  //�ж��Ƿ�ΪPictureBox�ؼ�
                    if (((PictureBox)C).Visible == true)   //�жϵ�ǰ�ؼ��Ƿ�Ϊ��ʾ״̬
                        ((PictureBox)C).Image = null;   //��յ�ǰ�ؼ���Image����
            }
        }
        #endregion

        #region  ������ӻ��޸ĵ���Ϣ
        /// <summary>
        /// ������ӻ��޸ĵ���Ϣ.
        /// </summary>
        /// <param name="Sarr">���ݱ��е������ֶ�</param>
        /// <param name="ID1">��һ���ֶ�ֵ</param>
        /// <param name="ID2">�ڶ����ֶ�ֵ</param>
        /// <param name="Contr">ָ���ؼ������ݼ�</param>
        /// <param name="BoxName">Ҫ�����Ŀؼ�����</param>
        /// <param name="TableName">���ݱ�����</param>
        /// <param name="n">�ؼ��ĸ���</param>
        /// <param name="m">��ʶ�������ж�����ӻ����޸�</param>
        public void Part_SaveClass(string Sarr, string ID1, string ID2, Control.ControlCollection Contr, string BoxName, string TableName, int n, int m)
        {
            string tem_Field = "", tem_Value = "";
            int p = 2;
            if (m == 1){    //��mΪ1ʱ����ʾ���������Ϣ
                if (ID1 != "" && ID2 == ""){ //���ݲ���ֵ�ж���ӵ��ֶ�
                    tem_Field = "ID";
                    tem_Value = "'" + ID1 + "'";
                    p = 1;
                }
                else{
                    tem_Field = "Sut_id,ID";
                    tem_Value = "'" + ID1 + "','" + ID2 + "'";
                }
            }
            else
                if (m == 2){    //��mΪ2ʱ����ʾ�޸�������Ϣ
                    if (ID1 != "" && ID2 == ""){ //���ݲ���ֵ�ж���ӵ��ֶ�
                        tem_Value = "ID='" + ID1 + "'";
                        p = 1;
                    }
                    else
                        tem_Value = "Sut_ID='" + ID1 + "',ID='" + ID2 + "'";
                }
                
            if (m > 0){ //���ɲ�����ӡ��޸����
                string[] Parr = Sarr.Split(Convert.ToChar(','));
                for (int i = p; i < n; i++)
                {
                    string sID = BoxName + i.ToString();    //ͨ��BoxName������ȡҪ���в����Ŀؼ�����
                    foreach (Control C in Contr){   //�����ؼ����е���ؿؼ�
                        if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                            if (C.Name == sID){ //����ڿؼ������ҵ���Ӧ�����
                                string Ctext = C.Text;
                                if (C.GetType().Name == "MaskedTextBox")    //�����ǰ��MaskedTextBox�ؼ�
                                    Ctext = Date_Format(C.Text);    //�Ե�ǰ�ؼ���ֵ���и�ʽ��
                                if (m == 1){    //���SQL�����insert��������
                                    tem_Field = tem_Field + "," + Parr[i];
                                    if (Ctext == "")
                                        tem_Value = tem_Value + "," + "NULL";
                                    else
                                        tem_Value = tem_Value + "," + "'" + Ctext + "'";
                                }
                                if (m == 2)
                                {    //���SQL�����update��������
                                    if (Ctext=="")
                                        tem_Value = tem_Value + "," + Parr[i] + "=NULL";
                                    else
                                        tem_Value = tem_Value + "," + Parr[i] + "='" + Ctext + "'";
                                }
                            }
                    }
                }
                ADDs = "";
                if (m == 1) //����SQL��������
                    ADDs = "insert into " + TableName + " (" + tem_Field + ") values(" + tem_Value + ")";
                if (m == 2) //����SQL���޸����
                    if (ID2 == "")  //����ID2�������ж��޸���������
                        ADDs = "update " + TableName + " set " + tem_Value + " where ID='" + ID1 + "'";
                    else
                        ADDs = "update " + TableName + " set " + tem_Value + " where ID='" + ID2 + "'";
            }
        }
        #endregion

        #region  ����ǰ���������Ϣ��ʾ��ָ���Ŀؼ���
        /// <summary>
        /// ��DataGridView�ؼ��ĵ�ǰ��¼��ʾ�������ؼ���.
        /// </summary>
        /// <param name="DGrid">DataGridView�ؼ�</param>
        /// <param name="GBox">GroupBox�ؼ������ݼ�</param>
        /// <param name="TName">��ȡ��Ϣ�ؼ��Ĳ�������</param>
        public void Show_DGrid(DataGridView DGrid, Control.ControlCollection GBox, string TName)
        {
            string sID = "";
            if (DGrid.RowCount > 0)
            {
                for (int i = 2; i < DGrid.ColumnCount; i++)
                {
                    sID = TName + i.ToString();
                    foreach (Control C in GBox)
                    {
                        if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                            if (C.Name == sID)
                            {
                                if (C.GetType().Name != "MaskedTextBox")
                                    C.Text = DGrid[i, DGrid.CurrentCell.RowIndex].Value.ToString();
                                else
                                    C.Text = Date_Format(Convert.ToString(DGrid[i, DGrid.CurrentCell.RowIndex].Value).Trim());
                            }
                    }
                }
            }

        }
        #endregion

        #region  ��տؼ����ϵĿؼ���Ϣ
        /// <summary>
        /// ���GroupBox�ؼ��ϵĿؼ���Ϣ.
        /// </summary>
        /// <param name="n">�ؼ�����</param>
        /// <param name="GBox">GroupBox�ؼ������ݼ�</param>
        /// <param name="TName">��ȡ��Ϣ�ؼ��Ĳ�������</param>
        public void Clear_Grids(int n, Control.ControlCollection GBox, string TName)
        {
            string sID = "";
            for (int i = 2; i < n; i++)
            {
                sID = TName + i.ToString();
                foreach (Control C in GBox)
                {
                    if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                        if (C.Name == sID)
                        {
                            C.Text = "";
                        }
                }
            }
        }
        #endregion

        #region �������ݱ����ʾ�ֶ�
        /// <summary>
        /// ͨ��������ʾ��ر���ֶΣ���ʹ��DataGridView�ؼ������System.Windows.Forms�����ռ�
        /// </summary>
        /// <param name="DSet">DataSet��</param>
        /// <param name="DGrid">DataGridView�ؼ�</param>
        public void Correlation_Table(DataSet DSet, DataGridView DGrid)
        {
            DGrid.DataSource = DSet.Tables[0];
            DGrid.Columns[0].Visible = false;
            DGrid.Columns[1].Visible = false;
            DGrid.RowHeadersVisible = false;
            DGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region  ��ϲ�ѯ����
        /// <summary>
        /// ���ݿؼ��Ƿ�Ϊ����ϲ�ѯ����.
        /// </summary>
        /// <param name="GBox">GroupBox�ؼ������ݼ�</param>
        /// <param name="TName">��ȡ��Ϣ�ؼ��Ĳ�������</param>
        /// <param name="TName">��ѯ��ϵ</param>
        public void Find_Grids(Control.ControlCollection GBox, string TName, string ANDSign)
        {
            string sID = "";    //����ֲ�����
            if (FindValue.Length>0)
                FindValue = FindValue + ANDSign;
            foreach (Control C in GBox){ //�����ؼ����ϵ����пؼ�
                if (C.GetType().Name == "TextBox" | C.GetType().Name == "ComboBox"){ //�ж��Ƿ�Ҫ�����Ŀؼ�
                    if (C.GetType().Name == "ComboBox" && C.Text!=""){   //��ָ���ؼ���Ϊ��ʱ
                        sID = C.Name;
                        if (sID.IndexOf(TName) > -1){    //��TName�����ǵ�ǰ�ؼ����еĲ�����Ϣʱ
                            string[] Astr = sID.Split(Convert.ToChar('_')); //�á�_�����ŷָ���ǰ�ؼ�������,��ȡ��Ӧ���ֶ���
                            FindValue = FindValue + "(" + Astr[1] + " = '" + C.Text + "')" + ANDSign;   //���ɲ�ѯ����
                        }
                    }
                    if (C.GetType().Name == "TextBox" && C.Text != "")  //�����ǰΪTextBox�ؼ������ҿؼ���Ϊ��
                    {
                        sID = C.Name;   //��ȡ��ǰ�ؼ�������
                        if (sID.IndexOf(TName) > -1)    //�ж�TName����ֵ�Ƿ�Ϊ��ǰ�ؼ��������ַ���
                        {
                            string[] Astr = sID.Split(Convert.ToChar('_')); //�ԡ�_��Ϊ�ָ��������ؼ������뵽һά������
                            string m_Sgin = ""; //���ڼ�¼�߼������
                            string mID = "";    //���ڼ�¼�ֶ���
                            if (Astr.Length > 2)    //�������Ԫ�ظ�������2ʱ
                                mID = Astr[1] + "_" + Astr[2];  //���������Ԫ������ֶ���
                            else
                                mID = Astr[1];  //��ȡ��ǰ��������Ӧ���ֶ�����
                            foreach (Control C1 in GBox)    //�����ؼ���
                            {
                                if (C1.GetType().Name == "ComboBox")    //�ж��Ƿ�ΪComboBox���
                                    if ((C1.Name).IndexOf(mID) > -1)    //�жϵ�ǰ������Ƿ������������Ĳ����ļ���
                                    {
                                        if (C1.Text == "")  //����ѯ����Ϊ��ʱ
                                            break;  //�˳�����ѭ��
                                        else
                                        {
                                            m_Sgin = C1.Text;   //������ֵ�洢��m_Sgin������
                                            break;
                                        }
                                    }
                            }
                            if (m_Sgin != "")   //���������Ϊ��ʱ
                                FindValue = FindValue + "(" + mID + m_Sgin + C.Text + ")" + ANDSign;    //���SQL���Ĳ�ѯ����
                        }
                    }
                }
            }
            if (FindValue.Length > 0)   //���洢��ѯ���ı�����Ϊ��ʱ��ɾ���߼������AND��OR
            {
                if (FindValue.IndexOf("AND") > -1)  //�ж��Ƿ���AND��������
                    FindValue = FindValue.Substring(0, FindValue.Length - 4);
                if (FindValue.IndexOf("OR") > -1)  //�ж��Ƿ���OR��������
                    FindValue = FindValue.Substring(0, FindValue.Length - 3);
            }
            else
                FindValue = "";
           
        }
        #endregion



        #region  �ж��ַ��������Ƿ���ȷ
        /// <summary>
        /// ���ַ�������ת�������ڽ����ж�.
        /// </summary>
        /// <param name="MTbox">MaskedTextBox�ؼ�</param>
        /// <param name="NDate">�ַ�������</param>
        /// <>
        public bool Estimate_Date(MaskedTextBox MTbox)
        {
            try
            {
                DateTime DT = DateTime.Parse(MTbox.Text.Trim());
                return true;
            }
            catch
            {
                MTbox.Text = "";
                MessageBox.Show("��������������������룡");
                return false;
            }
        }
        #endregion

        #region  �����ı���ֻ�������������ַ���
        /// <summary>
        /// �ı���ֻ�����������ͺ͵������͵��ַ���.
        /// </summary>
        /// <param name="e">KeyPressEventArgs��</param>
        /// <param name="s">�ı�����ַ���</param>
        /// <param name="n">��ʶ���ж��������ͻ��ǵ�������</param>
        public void Estimate_Key(KeyPressEventArgs e,string s,int n)
        {
            if (n==0)   //ֻ����������
                if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\r' && e.KeyChar != '\b')
                {
                    e.Handled = true;   //����KeyPress�¼�
                }
            if (n == 1) //�����������ͻ򵥾�����
            {
                if ((!(e.KeyChar <= '9' && e.KeyChar >= '0')) && e.KeyChar != '.' && e.KeyChar != '\r' && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == '.')   //������롰.��
                        if (s == "")    //��ǰ�ı���Ϊ��
                            e.Handled = true;   //����KeyPress�¼�
                        else
                        {
                            if (s.Length > 0)   //���ı���Ϊ��ʱ
                            {
                                if (s.IndexOf(".") > -1)    //�����Ƿ����������.��
                                    e.Handled = true;   //����KeyPress�¼�
                            }
                        }
                }
            }
        }
        #endregion

        #region  ����û�Ȩ��
        /// <summary>
        /// ������û�ʱ����Ȩ��ģ���е���Ϣ��ӵ��û�Ȩ�ޱ���.
        /// </summary>
        /// <param name="ID">�û����</param>
        /// <param name="n">Ȩ��ֵ</param>
        /// <>
        public void ADD_Pope(string ID,int n)
        {
            DataSet DSet;
            DSet = MyDataClass.getDataSet("select PopeName from tb_PopeModel", "tb_PopeModel");
            for (int i = 0; i < DSet.Tables[0].Rows.Count; i++)
            {
                MyDataClass.getsqlcom("insert into tb_UserPope (ID,PopeName,Pope) values('" + ID + "','" + Convert.ToString(DSet.Tables[0].Rows[i][0]) + "'," + n + ")");
            }
        }
        #endregion

        #region  ����������ݱ�
        /// <summary>
        /// ������ݿ��е��������ݱ�.
        /// </summary>
        /// <param name="GBox">GroupBox�ؼ������ݼ�</param>
        /// <param name="TName">��ȡ��Ϣ�ؼ��Ĳ�������</param>
        public void Clear_Table(Control.ControlCollection GBox, string TName)
        {
            string sID = "";
            foreach (Control C in GBox)
            {
                if (C.GetType().Name == "CheckBox")
                {
                    sID = C.Name;
                    if (sID.IndexOf(TName) > -1)
                    {
                        if (((CheckBox)C).Checked == true)
                        {
                            string TableName = "";
                            string[] Astr = sID.Split(Convert.ToChar('_'));
                            TableName = "tb_" + Astr[1];
                            if (Astr[1].ToUpper() == ("Clew").ToUpper())
                            {
                                MyDataClass.getsqlcom("update " + TableName + " set Fate=0,Unlock=0 where ID>0");
                            }
                            else
                            {
                                MyDataClass.getsqlcom("Delete " + TableName);
                                if (Astr[1].ToUpper() == ("Login").ToUpper())
                                {
                                    MyDataClass.getsqlcom("Delete tb_UserPope");
                                    MyDataClass.getsqlcom("insert into " + TableName + " (ID,Name,Pass) values('0001','TSoft','111')");
                                    ADD_Pope("0001", 1);
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region  ��ʾ�û�Ȩ��
        /// <summary>
        /// ��ʾָ���û���Ȩ��.
        /// </summary>
        /// <param name="GBox">GroupBox�ؼ������ݼ�</param>
        /// <param name="TName">��ȡ�û����</param>
        public void Show_Pope(Control.ControlCollection GBox, string TID)
        {
            string sID = "";
            string CheckName = "";
            bool t = false;
            DataSet DSet = MyDataClass.getDataSet("select ID,PopeName,Pope from tb_UserPope where ID='" + TID + "'", "tb_UserPope");
            for (int i = 0; i < DSet.Tables[0].Rows.Count; i++)
            {
                sID = Convert.ToString(DSet.Tables[0].Rows[i][1]);
                if ((int)(DSet.Tables[0].Rows[i][2]) == 1)
                    t = true;
                else
                    t = false;
                foreach (Control C in GBox)
                {
                    if (C.GetType().Name == "CheckBox")
                    {
                        CheckName = C.Name;
                        if (CheckName.IndexOf(sID) > -1)
                        {
                            ((CheckBox)C).Checked = t;
                        }
                    }
                }
            }
        }
        #endregion

        #region  �޸�ָ���û�Ȩ��
        /// <summary>
        /// �޸�ָ���û���Ȩ��.
        /// </summary>
        /// <param name="GBox">GroupBox�ؼ������ݼ�</param>
        /// <param name="TName">��ȡ�û����</param>
        public void Amend_Pope(Control.ControlCollection GBox, string TID)
        {
            string CheckName = "";
            int tt = 0;
            foreach (Control C in GBox)
            {
                if (C.GetType().Name == "CheckBox")
                {
                    if (((CheckBox)C).Checked)
                        tt = 1;
                    else
                        tt = 0;
                    CheckName = C.Name;
                    string[] Astr = CheckName.Split(Convert.ToChar('_'));
                    MyDataClass.getsqlcom("update tb_UserPope set Pope=" + tt + " where (ID='" + TID + "') and (PopeName='" + Astr[1].Trim() + "')");
                }
            }

        }
        #endregion

        #region  ����������˵�������
        /// <summary>
        /// ����������˵�������.
        /// </summary>
        /// <param name="MenuS">MenuStrip�ؼ�</param>
        public void MainMenuF(MenuStrip MenuS)
        {
            string Men = "";
            for (int i = 0; i < MenuS.Items.Count; i++)
            {
                Men = ((ToolStripDropDownItem)MenuS.Items[i]).Name;
                if (Men.IndexOf("Menu") == -1)
                    ((ToolStripDropDownItem)MenuS.Items[i]).Enabled = false;
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)
                    {
                        Men = newmenu.DropDownItems[j].Name;
                        if (Men.IndexOf("Menu") == -1)
                            newmenu.DropDownItems[j].Enabled = false;
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++)
                                newmenu2.DropDownItems[p].Enabled = false;
                    }
            }
            
        }
        #endregion

        #region  �����û�Ȩ������������˵�
        /// <summary>
        /// �����û�Ȩ�����ò˵��Ƿ����.
        /// </summary>
        /// <param name="MenuS">MenuStrip�ؼ�</param>
        /// <param name="UName">��ǰ��¼�û���</param>
        public void MainPope(MenuStrip MenuS, String UName)
        {
            string Str = "";
            string MenuName = "";
            DataSet DSet = MyDataClass.getDataSet("select ID from tb_Login where Name='" + UName + "'", "tb_Login");    //��ȡ��ǰ��¼�û�����Ϣ
            string UID = Convert.ToString(DSet.Tables[0].Rows[0][0]);   //��ȡ��ǰ�û����
            DSet = MyDataClass.getDataSet("select ID,PopeName,Pope from tb_UserPope where ID='" + UID + "'", "tb_UserPope");    //��ȡ��ǰ�û���Ȩ����Ϣ
            bool bo = false;
            for (int k = 0; k < DSet.Tables[0].Rows.Count; k++) //������ǰ�û���Ȩ������
            {
                Str = Convert.ToString(DSet.Tables[0].Rows[k][1]);  //��ȡȨ������
                if (Convert.ToInt32(DSet.Tables[0].Rows[k][2]) == 1)    //�ж�Ȩ���Ƿ����
                    bo = true;
                else
                    bo = false;
                for (int i = 0; i < MenuS.Items.Count; i++) //�����˵����е�һ���˵���
                {
                    ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];  //��¼��ǰ�˵����µ�������Ϣ
                    if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)    //�����ǰ�˵������Ӽ��˵���
                        for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //���������˵���
                        {
                            MenuName = newmenu.DropDownItems[j].Name;   //��ȡ��ǰ�˵��������
                            if (MenuName.IndexOf(Str) > -1) //�������Ȩ������
                                newmenu.DropDownItems[j].Enabled = bo;  //����Ȩ�����ÿ���״̬
                            ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];   //��¼��ǰ�˵����������Ϣ
                            if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)  //�����ǰ�˵������Ӽ��˵���
                                for (int p = 0; p < newmenu2.DropDownItems.Count; p++)  //���������˵���
                                {
                                    MenuName = newmenu2.DropDownItems[p].Name;  //��ȡ��ǰ�˵��������
                                    if (MenuName.IndexOf(Str) > -1) //�������Ȩ������
                                        newmenu2.DropDownItems[p].Enabled = bo;  //����Ȩ�����ÿ���״̬
                                }
                        }
                }
            }
        }
        #endregion

        #region  ��TreeView�ؼ�����StatusStrip�ؼ��¸��˵��ĵ����¼�
        /// <summary>
        /// ��TreeView�ؼ�����StatusStrip�ؼ��¸��˵��ĵ����¼�.
        /// </summary>
        /// <param name="MenuS">MenuStrip�ؼ�</param>
        /// <param name="e">TreeView�ؼ���TreeNodeMouseClickEventArgs��</param>
        public void TreeMenuF(MenuStrip MenuS, TreeNodeMouseClickEventArgs e)
        {
            string Men = "";
            for (int i = 0; i < MenuS.Items.Count; i++) //����MenuStrip�ؼ������˵���
            {
                Men = ((ToolStripDropDownItem)MenuS.Items[i]).Name; //��ȡ���˵��������
                if (Men.IndexOf("Menu") == -1)  //���MenuStrip�ؼ��Ĳ˵���û���Ӳ˵�
                {
                    if (((ToolStripDropDownItem)MenuS.Items[i]).Text == e.Node.Text)    //���ڵ�������˵����������ʱ
                        if (((ToolStripDropDownItem)MenuS.Items[i]).Enabled == false)   //�жϵ�ǰ�˵����Ƿ����
                        {
                            MessageBox.Show("��ǰ�û���Ȩ�޵���" + "\"" + e.Node.Text + "\"" + "����");
                            break;
                        }
                        else
                            Show_Form(((ToolStripDropDownItem)MenuS.Items[i]).Text.Trim(), 1);  //������Ӧ�Ĵ���
                }
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)    //���������˵���
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)
                    {
                        Men = newmenu.DropDownItems[j].Name;    //��ȡ�����˵��������
                        if (Men.IndexOf("Menu") == -1)
                        {
                            if ((newmenu.DropDownItems[j]).Text == e.Node.Text)
                                if ((newmenu.DropDownItems[j]).Enabled == false)
                                {
                                    MessageBox.Show("��ǰ�û���Ȩ�޵���" + "\"" + e.Node.Text + "\"" + "����");
                                    break;
                                }
                                else
                                    Show_Form((newmenu.DropDownItems[j]).Text.Trim(), 1);
                        }
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)  //���������˵���
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++)
                            {
                                if ((newmenu2.DropDownItems[p]).Text == e.Node.Text)
                                    if ((newmenu2.DropDownItems[p]).Enabled == false)
                                    {
                                        MessageBox.Show("��ǰ�û���Ȩ�޵���" + "\"" + e.Node.Text + "\"" + "����");
                                        break;
                                    }
                                    else
                                        if ((newmenu2.DropDownItems[p]).Text.Trim() == "Ա��������ʾ" || (newmenu2.DropDownItems[p]).Text.Trim() == "Ա����ͬ��ʾ")
                                            Show_Form((newmenu2.DropDownItems[p]).Text.Trim(), 1);
                                        else
                                            Show_Form((newmenu2.DropDownItems[p]).Text.Trim(), 2);
                            }
                    }
            }

        }
        #endregion

        #region  ��ѯָ����Χ���������ͬ���ڵ�ְ��
        /// <summary>
        /// ��ѯָ����Χ���������ͬ���ڵ�ְ��.
        /// </summary>
        /// <param name="i">��ʶ���жϲ�ѯ�������գ����Ǻ�ͬ</param>
        public void PactDay(int i)
        {
            DataSet DSet = MyDataClass.getDataSet("select * from tb_Clew where kind=" + i + " and unlock=1", "tb_clew");
            if (DSet.Tables[0].Rows.Count > 0)
            {
                string Vfield = "";
                string dSQL = "";
                int sday = Convert.ToInt32(DSet.Tables[0].Rows[0][1]);
                if (i == 1)
                {
                    Vfield = "Birthday";
                    dSQL = "select * from tb_Stuffbusic where (datediff(day,getdate(),convert(Nvarchar(12),cast (cast (year(getdate()) as char(4))+'-'+ cast(month(" + Vfield + ") as char(2))+'-'+	cast (day(" + Vfield + ") as char(2)) as datetime),110))<=" + sday + ") and (datediff(day,getdate(),convert(Nvarchar(12),cast (cast (year(getdate()) as char(4))+'-'+ cast(month(" + Vfield + ") as char(2))+'-'+cast (day(" + Vfield + ") as char(2)) as datetime),110))>=0)";
                }
                else
                {
                    Vfield = "Pact_E";
                    dSQL = "select * from tb_Stuffbusic where ((getdate()-convert(Nvarchar(12)," + Vfield + ",110))>=-" + sday + " and (getdate()-convert(Nvarchar(12)," + Vfield + ",110))<=0)";
                }
                DSet = MyDataClass.getDataSet(dSQL, "tb_Stuffbusic");
                if (DSet.Tables[0].Rows.Count > 0)
                {
                    if (i == 1)
                        Vfield = "�Ƿ�鿴" + sday.ToString() + "���ڹ����յ�ְ����Ϣ��";
                    else
                        Vfield = "�Ƿ�鿴" + sday.ToString() + "���ں�ͬ���ڵ�ְ����Ϣ��";
                    if (MessageBox.Show(Vfield, "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        DataClass.MyMeans.AllSql = dSQL;
                        Show_Form("���µ������", 1);
                    }
                }
            }
        }
        #endregion

        #region  ��ͼƬ�洢�����ݿ���
        /// <summary>
        /// �Զ����Ƶ���ʽ��ͼƬ�洢�����ݿ���.
        /// </summary>
        /// <param name="MID">ְ�����</param>
        /// <param name="p">ͼƬ�Ķ�������ʽ</param>
        public void SaveImage(string MID, byte[] p)
        {
            MyDataClass.con_open();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Stuffbusic Set Photo=@Photo where ID="+MID);
            SqlCommand cmd = new SqlCommand(strSql.ToString(), DataClass.MyMeans.My_con);
            cmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = p;
            cmd.ExecuteNonQuery();
            DataClass.MyMeans.My_con.Close();
        }
        #endregion
    }

}
