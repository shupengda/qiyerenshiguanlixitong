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
        #region  公共变量
        DataClass.MyMeans MyDataClass = new PWMS.DataClass.MyMeans();   //声明MyMeans类的一个对象，以调用其方法
        public static string ADDs = "";  //用来存储添加或修改的SQL语句
        public static string FindValue = "";  //存储查询条件
        public static string Address_ID = "";  //存储通讯录添加修改时的ID编号
        public static string User_ID = "";  //存储用户的ID编号
        public static string User_Name = "";    //存储用户名
        #endregion

        #region  窗体的调用
        /// <summary>
        /// 窗体的调用.
        /// </summary>
        /// <param name="FrmName">调用窗体的Text属性值</param>
        /// <param name="n">标识</param>
        public void Show_Form(string FrmName, int n)
        {
            if (n == 1)
            {
                if (FrmName == "人事档案浏览")  //判断当前要打开的窗体
                {
                    PerForm.F_ManFile FrmManFile = new PWMS.PerForm.F_ManFile();
                    FrmManFile.Text = "人事档案浏览";   //设置窗体名称
                    FrmManFile.ShowDialog();    //显示窗体
                    FrmManFile.Dispose();
                }
                if (FrmName == "人事资料查询")
                {
                    PerForm.F_Find FrmFind = new PWMS.PerForm.F_Find();
                    FrmFind.Text = "人事资料查询";
                    FrmFind.ShowDialog();
                    FrmFind.Dispose();
                }
                if (FrmName == "人事资料统计")
                {
                    PerForm.F_Stat FrmStat = new PWMS.PerForm.F_Stat();
                    FrmStat.Text = "人事资料统计";
                    FrmStat.ShowDialog();
                    FrmStat.Dispose();
                }
                if (FrmName == "员工生日提示")
                {
                    InfoAddForm.F_ClewSet FrmClewSet = new PWMS.InfoAddForm.F_ClewSet();
                    FrmClewSet.Text = "员工生日提示";   //设置窗体名称
                    FrmClewSet.Tag = 1; //设置窗体的Tag属性，用于在打开窗体时判断窗体的显示类形
                    FrmClewSet.ShowDialog();    //显示窗体
                    FrmClewSet.Dispose();
                }
                if (FrmName == "员工合同提示")
                {
                    InfoAddForm.F_ClewSet FrmClewSet = new PWMS.InfoAddForm.F_ClewSet();
                    FrmClewSet.Text = "员工合同提示";
                    FrmClewSet.Tag = 2;
                    FrmClewSet.ShowDialog();
                    FrmClewSet.Dispose();
                }
                if (FrmName == "日常记事")
                {
                    PerForm.F_WordPad FrmWordPad = new PWMS.PerForm.F_WordPad();
                    FrmWordPad.Text = "日常记事";
                    FrmWordPad.ShowDialog();
                    FrmWordPad.Dispose();
                }
                if (FrmName == "通讯录")
                {
                    PerForm.F_AddressList FrmAddressList = new PWMS.PerForm.F_AddressList();
                    FrmAddressList.Text = "通讯录";
                    FrmAddressList.ShowDialog();
                    FrmAddressList.Dispose();
                }
                if (FrmName == "备份/还原数据库")
                {
                    PerForm.F_HaveBack FrmHaveBack = new PWMS.PerForm.F_HaveBack();
                    FrmHaveBack.Text = "备份/还原数据库";
                    FrmHaveBack.ShowDialog();
                    FrmHaveBack.Dispose();
                }
                if (FrmName == "清空数据库")
                {
                    PerForm.F_ClearData FrmClearData = new PWMS.PerForm.F_ClearData();
                    FrmClearData.Text = "清空数据库";
                    FrmClearData.ShowDialog();
                    FrmClearData.Dispose();
                }

                if (FrmName == "重新登录")
                {
                    F_Login FrmLogin = new F_Login();
                    FrmLogin.Tag = 2;
                    FrmLogin.ShowDialog();
                    FrmLogin.Dispose();
                }
                if (FrmName == "用户设置")
                {
                    PerForm.F_User FrmUser = new PWMS.PerForm.F_User();
                    FrmUser.Text = "用户设置";
                    FrmUser.ShowDialog();
                    FrmUser.Dispose();
                }
               
            }
            if (n == 2)
            {
                String FrmStr = ""; //记录窗体名称
                if (FrmName == "民族类别设置")  //判断要打开的窗体
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Folk";   //SQL语句
                    DataClass.MyMeans.Mean_Table = "tb_Folk";   //表名
                    DataClass.MyMeans.Mean_Field = "FolkName";  //添加、修改数据的字段名
                    FrmStr = FrmName;
                }
                if (FrmName == "职工类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_EmployeeGenre";
                    DataClass.MyMeans.Mean_Table = "tb_EmployeeGenre";
                    DataClass.MyMeans.Mean_Field = "EmployeeName";
                    FrmStr = FrmName;
                }
                if (FrmName == "文化程度设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Kultur";
                    DataClass.MyMeans.Mean_Table = "tb_Kultur";
                    DataClass.MyMeans.Mean_Field = "KulturName";
                    FrmStr = FrmName;
                }
                if (FrmName == "政治面貌设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Visage";
                    DataClass.MyMeans.Mean_Table = "tb_Visage";
                    DataClass.MyMeans.Mean_Field = "VisageName";
                    FrmStr = FrmName;
                }
                if (FrmName == "部门类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Branch";
                    DataClass.MyMeans.Mean_Table = "tb_Branch";
                    DataClass.MyMeans.Mean_Field = "BranchName";
                    FrmStr = FrmName;
                }
                if (FrmName == "工资类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Laborage";
                    DataClass.MyMeans.Mean_Table = "tb_Laborage";
                    DataClass.MyMeans.Mean_Field = "LaborageName";
                    FrmStr = FrmName;
                }
                if (FrmName == "职务类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Business";
                    DataClass.MyMeans.Mean_Table = "tb_Business";
                    DataClass.MyMeans.Mean_Field = "BusinessName";
                    FrmStr = FrmName;
                }
                if (FrmName == "职称类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_Duthcall";
                    DataClass.MyMeans.Mean_Table = "tb_Duthcall";
                    DataClass.MyMeans.Mean_Field = "DuthcallName";
                    FrmStr = FrmName;
                }
                if (FrmName == "奖惩类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_RPKind";
                    DataClass.MyMeans.Mean_Table = "tb_RPKind";
                    DataClass.MyMeans.Mean_Field = "RPKind";
                    FrmStr = FrmName;
                }
                if (FrmName == "记事本类别设置")
                {
                    DataClass.MyMeans.Mean_SQL = "select * from tb_WordPad";
                    DataClass.MyMeans.Mean_Table = "tb_WordPad";
                    DataClass.MyMeans.Mean_Field = "WordPad";
                    FrmStr = FrmName;
                }
                InfoAddForm.F_Basic FrmBasic = new PWMS.InfoAddForm.F_Basic();
                FrmBasic.Text = FrmStr; //设置窗体名称
                FrmBasic.ShowDialog();  //显示调用的窗体
                FrmBasic.Dispose();
            }
        }
        #endregion

        #region  将StatusStrip控件中的信息添加到treeView控件中
        /// <summary>
        /// 读取菜单中的信息.
        /// </summary>
        /// <param name="treeV">TreeView控件</param>
        /// <param name="MenuS">MenuStrip控件</param>
        public void GetMenu(TreeView treeV, MenuStrip MenuS)
        {
            for (int i = 0; i < MenuS.Items.Count; i++) //遍历MenuStrip组件中的一级菜单项
            {
                //将一级菜单项的名称添加到TreeView组件的根节点中，并设置当前节点的子节点newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
                //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                //判断当前菜单项中是否有二级菜单项
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //遍历二级菜单项
                    {
                        //将二级菜单名称添加到TreeView组件的子节点newNode1中，并设置当前节点的子节点newNode2
                        TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
                        //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        //判断二级菜单项中是否有三级菜单项
                        if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++)    //遍历三级菜单项
                                //将三级菜单名称添加到TreeView组件的子节点newNode2中
                                newNode2.Nodes.Add(newmenu2.DropDownItems[p].Text);
                    }
            }
        }
        #endregion

        #region  自动编号
        /// <summary>
        /// 在添加信息时自动计算编号.
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="ID">字段名</param>
        /// <returns>返回String对象</returns>
        public String GetAutocoding(string TableName, string ID)
        {
            //查找指定表中ID号为最大的记录
            SqlDataReader MyDR = MyDataClass.getcom("select max(" + ID + ") NID from " + TableName);
            int Num = 0;
            if (MyDR.HasRows)   //当查找到记录时
            {
                MyDR.Read();    //读取当前记录
                if (MyDR[0].ToString() == "")
                    return "0001";
                Num = Convert.ToInt32(MyDR[0].ToString());  //将当前找到的最大编号转换成整数
                ++Num;  //最大编号加1
                string s = string.Format("{0:0000}", Num);  //将整数值转换成指定格式的字符串
                return s;   //返回自动生成的编号
            }
            else
            {
                return "0001";  //当数据表没有记录时，返回0001
            }
        }
        #endregion

        #region  向comboBox控件传递数据表中的数据
        /// <summary>
        /// 动态向comboBox控件的下拉列表添加数据.
        /// </summary>
        /// <param name="cobox">comboBox控件</param>
        /// <param name="TableName">数据表名称</param>
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

        #region  向comboBox控件传递各省市的名称
        /// <summary>
        /// 动态向comboBox控件的下拉列表添加省名.
        /// </summary>
        /// <param name="cobox">comboBox控件</param>
        /// <param name="SQLstr">SQL语句</param>
        /// <param name="n">字段位数</param>
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

        #region  将日期转换成指定的格式
        /// <summary>
        /// 将日期转换成yyyy-mm-dd格式.
        /// </summary>
        /// <param name="NDate">日期</param>
        /// <returns>返回String对象</returns>
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

        #region  将时间转换成指定的格式
        /// <summary>
        /// 将时间转换成yyyy-mm-dd格式.
        /// </summary>
        /// <param name="NDate">日期</param>
        /// <returns>返回String对象</returns>
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

        #region  设置MaskedTextBox控件的格式
        /// <summary>
        /// 将MaskedTextBox控件的格式设为yyyy-mm-dd格式.
        /// </summary>
        /// <param name="NDate">日期</param>
        /// <param name="ID">数据表名称</param>
        /// <returns>返回String对象</returns>
        public void MaskedTextBox_Format(MaskedTextBox MTBox)
        {
            MTBox.Mask = "0000-00-00";
            MTBox.ValidatingType = typeof(System.DateTime);
        }
        #endregion

        #region  用按钮控制数据记录移动时，改变按钮的可用状态
        /// <summary>
        /// 设置按钮是否可用.
        /// </summary>
        /// <param name="B1">首记录按钮</param>
        /// <param name="B2">上一条记录按钮</param>
        /// <param name="B3">下一条记录按钮</param>
        /// <param name="B4">尾记录按钮</param>
        /// <param name="NDate">B1标识</param>
        /// <param name="NDate">B2标识</param>
        /// <param name="NDate">B3标识</param>
        /// <param name="NDate">B4标识</param>
        public void Ena_Button(Button B1, Button B2, Button B3, Button B4, int n1, int n2, int n3, int n4)
        {
            B1.Enabled = Convert.ToBoolean(n1);
            B2.Enabled = Convert.ToBoolean(n2);
            B3.Enabled = Convert.ToBoolean(n3);
            B4.Enabled = Convert.ToBoolean(n4);
        }
        #endregion

        #region  遍历清空指定的控件
        /// <summary>
        /// 清空所有控件下的所有控件.
        /// </summary>
        /// <param name="Con">可视化控件</param>
        public void Clear_Control(Control.ControlCollection Con)
        {
            foreach (Control C in Con){ //遍历可视化组件中的所有控件
                if (C.GetType().Name == "TextBox")  //判断是否为TextBox控件
                    if (((TextBox)C).Visible == true)   //判断当前控件是否为显示状态
                        ((TextBox)C).Clear();   //清空当前控件
                if (C.GetType().Name == "MaskedTextBox")  //判断是否为MaskedTextBox控件
                    if (((MaskedTextBox)C).Visible == true)   //判断当前控件是否为显示状态
                        ((MaskedTextBox)C).Clear();   //清空当前控件
                if (C.GetType().Name == "ComboBox")  //判断是否为ComboBox控件
                    if (((ComboBox)C).Visible == true)   //判断当前控件是否为显示状态
                        ((ComboBox)C).Text = "";   //清空当前控件的Text属性值
                if (C.GetType().Name == "PictureBox")  //判断是否为PictureBox控件
                    if (((PictureBox)C).Visible == true)   //判断当前控件是否为显示状态
                        ((PictureBox)C).Image = null;   //清空当前控件的Image属性
            }
        }
        #endregion

        #region  保存添加或修改的信息
        /// <summary>
        /// 保存添加或修改的信息.
        /// </summary>
        /// <param name="Sarr">数据表中的所有字段</param>
        /// <param name="ID1">第一个字段值</param>
        /// <param name="ID2">第二个字段值</param>
        /// <param name="Contr">指定控件的数据集</param>
        /// <param name="BoxName">要搜索的控件名称</param>
        /// <param name="TableName">数据表名称</param>
        /// <param name="n">控件的个数</param>
        /// <param name="m">标识，用于判断是添加还是修改</param>
        public void Part_SaveClass(string Sarr, string ID1, string ID2, Control.ControlCollection Contr, string BoxName, string TableName, int n, int m)
        {
            string tem_Field = "", tem_Value = "";
            int p = 2;
            if (m == 1){    //当m为1时，表示添加数据信息
                if (ID1 != "" && ID2 == ""){ //根据参数值判断添加的字段
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
                if (m == 2){    //当m为2时，表示修改数据信息
                    if (ID1 != "" && ID2 == ""){ //根据参数值判断添加的字段
                        tem_Value = "ID='" + ID1 + "'";
                        p = 1;
                    }
                    else
                        tem_Value = "Sut_ID='" + ID1 + "',ID='" + ID2 + "'";
                }
                
            if (m > 0){ //生成部份添加、修改语句
                string[] Parr = Sarr.Split(Convert.ToChar(','));
                for (int i = p; i < n; i++)
                {
                    string sID = BoxName + i.ToString();    //通过BoxName参数获取要进行操作的控件名称
                    foreach (Control C in Contr){   //遍历控件集中的相关控件
                        if (C.GetType().Name == "TextBox" | C.GetType().Name == "MaskedTextBox" | C.GetType().Name == "ComboBox")
                            if (C.Name == sID){ //如果在控件集中找到相应的组件
                                string Ctext = C.Text;
                                if (C.GetType().Name == "MaskedTextBox")    //如果当前是MaskedTextBox控件
                                    Ctext = Date_Format(C.Text);    //对当前控件的值进行格式化
                                if (m == 1){    //组合SQL语句中insert的相关语句
                                    tem_Field = tem_Field + "," + Parr[i];
                                    if (Ctext == "")
                                        tem_Value = tem_Value + "," + "NULL";
                                    else
                                        tem_Value = tem_Value + "," + "'" + Ctext + "'";
                                }
                                if (m == 2)
                                {    //组合SQL语句中update的相关语句
                                    if (Ctext=="")
                                        tem_Value = tem_Value + "," + Parr[i] + "=NULL";
                                    else
                                        tem_Value = tem_Value + "," + Parr[i] + "='" + Ctext + "'";
                                }
                            }
                    }
                }
                ADDs = "";
                if (m == 1) //生成SQL的添加语句
                    ADDs = "insert into " + TableName + " (" + tem_Field + ") values(" + tem_Value + ")";
                if (m == 2) //生成SQL的修改语句
                    if (ID2 == "")  //根据ID2参数，判断修改语句的条件
                        ADDs = "update " + TableName + " set " + tem_Value + " where ID='" + ID1 + "'";
                    else
                        ADDs = "update " + TableName + " set " + tem_Value + " where ID='" + ID2 + "'";
            }
        }
        #endregion

        #region  将当前表的数据信息显示在指定的控件上
        /// <summary>
        /// 将DataGridView控件的当前记录显示在其它控件上.
        /// </summary>
        /// <param name="DGrid">DataGridView控件</param>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
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

        #region  清空控件集上的控件信息
        /// <summary>
        /// 清空GroupBox控件上的控件信息.
        /// </summary>
        /// <param name="n">控件个数</param>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
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

        #region 控制数据表的显示字段
        /// <summary>
        /// 通过条件显示相关表的字段，因使用DataGridView控件，添加System.Windows.Forms命名空间
        /// </summary>
        /// <param name="DSet">DataSet类</param>
        /// <param name="DGrid">DataGridView控件</param>
        public void Correlation_Table(DataSet DSet, DataGridView DGrid)
        {
            DGrid.DataSource = DSet.Tables[0];
            DGrid.Columns[0].Visible = false;
            DGrid.Columns[1].Visible = false;
            DGrid.RowHeadersVisible = false;
            DGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region  组合查询条件
        /// <summary>
        /// 根据控件是否为空组合查询条件.
        /// </summary>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
        /// <param name="TName">查询关系</param>
        public void Find_Grids(Control.ControlCollection GBox, string TName, string ANDSign)
        {
            string sID = "";    //定义局部变量
            if (FindValue.Length>0)
                FindValue = FindValue + ANDSign;
            foreach (Control C in GBox){ //遍历控件集上的所有控件
                if (C.GetType().Name == "TextBox" | C.GetType().Name == "ComboBox"){ //判断是否要遍历的控件
                    if (C.GetType().Name == "ComboBox" && C.Text!=""){   //当指定控件不为空时
                        sID = C.Name;
                        if (sID.IndexOf(TName) > -1){    //当TName参数是当前控件名中的部分信息时
                            string[] Astr = sID.Split(Convert.ToChar('_')); //用“_”符号分隔当前控件的名称,获取相应的字段名
                            FindValue = FindValue + "(" + Astr[1] + " = '" + C.Text + "')" + ANDSign;   //生成查询条件
                        }
                    }
                    if (C.GetType().Name == "TextBox" && C.Text != "")  //如果当前为TextBox控件，并且控件不为空
                    {
                        sID = C.Name;   //获取当前控件的名称
                        if (sID.IndexOf(TName) > -1)    //判断TName参数值是否为当前控件名的子字符串
                        {
                            string[] Astr = sID.Split(Convert.ToChar('_')); //以“_”为分隔符，将控件名存入到一维数组中
                            string m_Sgin = ""; //用于记录逻辑运算符
                            string mID = "";    //用于记录字段名
                            if (Astr.Length > 2)    //当数组的元素个数大于2时
                                mID = Astr[1] + "_" + Astr[2];  //将最后两个元素组成字段名
                            else
                                mID = Astr[1];  //获取当前条件所对应的字段名称
                            foreach (Control C1 in GBox)    //遍历控件集
                            {
                                if (C1.GetType().Name == "ComboBox")    //判断是否为ComboBox组件
                                    if ((C1.Name).IndexOf(mID) > -1)    //判断当前组件名是否包含条件组件的部分文件名
                                    {
                                        if (C1.Text == "")  //当查询条件为空时
                                            break;  //退出本次循环
                                        else
                                        {
                                            m_Sgin = C1.Text;   //将条件值存储到m_Sgin变量中
                                            break;
                                        }
                                    }
                            }
                            if (m_Sgin != "")   //当该务件不为空时
                                FindValue = FindValue + "(" + mID + m_Sgin + C.Text + ")" + ANDSign;    //组合SQL语句的查询条件
                        }
                    }
                }
            }
            if (FindValue.Length > 0)   //当存储查询条的变量不为空时，删除逻辑运算符AND和OR
            {
                if (FindValue.IndexOf("AND") > -1)  //判断是否用AND连接条件
                    FindValue = FindValue.Substring(0, FindValue.Length - 4);
                if (FindValue.IndexOf("OR") > -1)  //判断是否用OR连接条件
                    FindValue = FindValue.Substring(0, FindValue.Length - 3);
            }
            else
                FindValue = "";
           
        }
        #endregion



        #region  判断字符型日期是否正确
        /// <summary>
        /// 将字符型日期转换成日期进行判断.
        /// </summary>
        /// <param name="MTbox">MaskedTextBox控件</param>
        /// <param name="NDate">字符型日期</param>
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
                MessageBox.Show("日期输入错误，请重新输入！");
                return false;
            }
        }
        #endregion

        #region  设置文本框只能输入数字型字符串
        /// <summary>
        /// 文本框只能输入数字型和单精度型的字符串.
        /// </summary>
        /// <param name="e">KeyPressEventArgs类</param>
        /// <param name="s">文本框的字符串</param>
        /// <param name="n">标识，判断是数字型还是单精度型</param>
        public void Estimate_Key(KeyPressEventArgs e,string s,int n)
        {
            if (n==0)   //只能输入整型
                if (!(e.KeyChar <= '9' && e.KeyChar >= '0') && e.KeyChar != '\r' && e.KeyChar != '\b')
                {
                    e.Handled = true;   //处理KeyPress事件
                }
            if (n == 1) //可以输入整型或单精度型
            {
                if ((!(e.KeyChar <= '9' && e.KeyChar >= '0')) && e.KeyChar != '.' && e.KeyChar != '\r' && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == '.')   //如果输入“.”
                        if (s == "")    //当前文本框为空
                            e.Handled = true;   //处理KeyPress事件
                        else
                        {
                            if (s.Length > 0)   //当文本框不为空时
                            {
                                if (s.IndexOf(".") > -1)    //查找是否已输入过“.”
                                    e.Handled = true;   //处理KeyPress事件
                            }
                        }
                }
            }
        }
        #endregion

        #region  添加用户权限
        /// <summary>
        /// 在添加用户时，将权限模版中的信息添加到用户权限表中.
        /// </summary>
        /// <param name="ID">用户编号</param>
        /// <param name="n">权限值</param>
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

        #region  清空所有数据表
        /// <summary>
        /// 清空数据库中的所有数据表.
        /// </summary>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取信息控件的部份名称</param>
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

        #region  显示用户权限
        /// <summary>
        /// 显示指定用户的权限.
        /// </summary>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取用户编号</param>
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

        #region  修改指定用户权限
        /// <summary>
        /// 修改指定用户的权限.
        /// </summary>
        /// <param name="GBox">GroupBox控件的数据集</param>
        /// <param name="TName">获取用户编号</param>
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

        #region  设置主窗体菜单不可用
        /// <summary>
        /// 设置主窗体菜单不可用.
        /// </summary>
        /// <param name="MenuS">MenuStrip控件</param>
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

        #region  根据用户权限设置主窗体菜单
        /// <summary>
        /// 根据用户权限设置菜单是否可用.
        /// </summary>
        /// <param name="MenuS">MenuStrip控件</param>
        /// <param name="UName">当前登录用户名</param>
        public void MainPope(MenuStrip MenuS, String UName)
        {
            string Str = "";
            string MenuName = "";
            DataSet DSet = MyDataClass.getDataSet("select ID from tb_Login where Name='" + UName + "'", "tb_Login");    //获取当前登录用户的信息
            string UID = Convert.ToString(DSet.Tables[0].Rows[0][0]);   //获取当前用户编号
            DSet = MyDataClass.getDataSet("select ID,PopeName,Pope from tb_UserPope where ID='" + UID + "'", "tb_UserPope");    //获取当前用户的权限信息
            bool bo = false;
            for (int k = 0; k < DSet.Tables[0].Rows.Count; k++) //遍历当前用户的权限名称
            {
                Str = Convert.ToString(DSet.Tables[0].Rows[k][1]);  //获取权限名称
                if (Convert.ToInt32(DSet.Tables[0].Rows[k][2]) == 1)    //判断权限是否可用
                    bo = true;
                else
                    bo = false;
                for (int i = 0; i < MenuS.Items.Count; i++) //遍历菜单栏中的一级菜单项
                {
                    ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];  //记录当前菜单项下的所有信息
                    if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)    //如果当前菜单项有子级菜单项
                        for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //遍历二级菜单项
                        {
                            MenuName = newmenu.DropDownItems[j].Name;   //获取当前菜单项的名称
                            if (MenuName.IndexOf(Str) > -1) //如果包含权限名称
                                newmenu.DropDownItems[j].Enabled = bo;  //根据权限设置可用状态
                            ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];   //记录当前菜单项的所有信息
                            if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)  //如果当前菜单项有子级菜单项
                                for (int p = 0; p < newmenu2.DropDownItems.Count; p++)  //遍历三级菜单项
                                {
                                    MenuName = newmenu2.DropDownItems[p].Name;  //获取当前菜单项的名称
                                    if (MenuName.IndexOf(Str) > -1) //如果包含权限名称
                                        newmenu2.DropDownItems[p].Enabled = bo;  //根据权限设置可用状态
                                }
                        }
                }
            }
        }
        #endregion

        #region  用TreeView控件调用StatusStrip控件下各菜单的单击事件
        /// <summary>
        /// 用TreeView控件调用StatusStrip控件下各菜单的单击事件.
        /// </summary>
        /// <param name="MenuS">MenuStrip控件</param>
        /// <param name="e">TreeView控件的TreeNodeMouseClickEventArgs类</param>
        public void TreeMenuF(MenuStrip MenuS, TreeNodeMouseClickEventArgs e)
        {
            string Men = "";
            for (int i = 0; i < MenuS.Items.Count; i++) //遍历MenuStrip控件中主菜单项
            {
                Men = ((ToolStripDropDownItem)MenuS.Items[i]).Name; //获取主菜单项的名称
                if (Men.IndexOf("Menu") == -1)  //如果MenuStrip控件的菜单项没有子菜单
                {
                    if (((ToolStripDropDownItem)MenuS.Items[i]).Text == e.Node.Text)    //当节点名称与菜单项名称相等时
                        if (((ToolStripDropDownItem)MenuS.Items[i]).Enabled == false)   //判断当前菜单项是否可用
                        {
                            MessageBox.Show("当前用户无权限调用" + "\"" + e.Node.Text + "\"" + "窗体");
                            break;
                        }
                        else
                            Show_Form(((ToolStripDropDownItem)MenuS.Items[i]).Text.Trim(), 1);  //调用相应的窗体
                }
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)    //遍历二级菜单项
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)
                    {
                        Men = newmenu.DropDownItems[j].Name;    //获取二级菜单项的名称
                        if (Men.IndexOf("Menu") == -1)
                        {
                            if ((newmenu.DropDownItems[j]).Text == e.Node.Text)
                                if ((newmenu.DropDownItems[j]).Enabled == false)
                                {
                                    MessageBox.Show("当前用户无权限调用" + "\"" + e.Node.Text + "\"" + "窗体");
                                    break;
                                }
                                else
                                    Show_Form((newmenu.DropDownItems[j]).Text.Trim(), 1);
                        }
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)  //遍历三级菜单项
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++)
                            {
                                if ((newmenu2.DropDownItems[p]).Text == e.Node.Text)
                                    if ((newmenu2.DropDownItems[p]).Enabled == false)
                                    {
                                        MessageBox.Show("当前用户无权限调用" + "\"" + e.Node.Text + "\"" + "窗体");
                                        break;
                                    }
                                    else
                                        if ((newmenu2.DropDownItems[p]).Text.Trim() == "员工生日提示" || (newmenu2.DropDownItems[p]).Text.Trim() == "员工合同提示")
                                            Show_Form((newmenu2.DropDownItems[p]).Text.Trim(), 1);
                                        else
                                            Show_Form((newmenu2.DropDownItems[p]).Text.Trim(), 2);
                            }
                    }
            }

        }
        #endregion

        #region  查询指定范围内生日与合同到期的职工
        /// <summary>
        /// 查询指定范围内生日与合同到期的职工.
        /// </summary>
        /// <param name="i">标识，判断查询的是生日，还是合同</param>
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
                        Vfield = "是否查看" + sday.ToString() + "天内过生日的职工信息？";
                    else
                        Vfield = "是否查看" + sday.ToString() + "天内合同到期的职工信息？";
                    if (MessageBox.Show(Vfield, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        DataClass.MyMeans.AllSql = dSQL;
                        Show_Form("人事档案浏览", 1);
                    }
                }
            }
        }
        #endregion

        #region  将图片存储到数据库中
        /// <summary>
        /// 以二进制的形式将图片存储到数据库中.
        /// </summary>
        /// <param name="MID">职工编号</param>
        /// <param name="p">图片的二进制形式</param>
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
