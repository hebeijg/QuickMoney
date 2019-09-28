using QuickMonery.Common;
using QuickMonery.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickMonery
{
    public partial class SystemManagerFrm : Form
    {
        #region 属    性
        //设置类型  0=打印机 1=日志管理 2=快捷键 3=关于
        private int SetType = 0;
        //标题集合
        private string[] TitleValue = { "打印机相关设置", "日志管理", "快捷键设置", "关于" };
        MyDropDown ddlPrintName = null;
        MyDropDown ddlPrintJoint = null;
        private string SysConfigPath = System.AppDomain.CurrentDomain.BaseDirectory + "config.ini";
        private IniFile iniClass;
        #endregion

        public SystemManagerFrm()
        {
            InitializeComponent();
        }

        private void SystemManagerFrm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(SysConfigPath))
            {
                File.Create(SysConfigPath).Close();
            }
            iniClass = new IniFile(SysConfigPath);

            string tmp_PrintJointEnum = iniClass.IniReadValue("Print", "JointEnum");
            InitPrint();
        }

        #region 菜单切换
        private void lblSwitchMenu_Click(object sender, EventArgs e)
        {
            Label tmp_obj = (Label)sender;
            int tmp_SetType = int.Parse(tmp_obj.Tag.ToString());
            if (SetType != tmp_SetType)
            {
                PubSwitch(SetType, false);
                SetType = tmp_SetType;
                lblCtTitle.Text = TitleValue[SetType];
                PubSwitch(tmp_SetType, true);
            }
        }

        private void PubSwitch(int SetType, bool IsCheck)
        {
            switch (SetType)
            {
                case 0:
                    SwitchMenu("palLeftPrint", "ptbLeftPrint", IsCheck ? "sys_icon_print_press.png" : "sys_icon_print.png", "lblLeftPrint", IsCheck);
                    pal_Print_Box.Visible = IsCheck;
                    if (IsCheck) InitPrint();
                    break;
                case 1:
                    SwitchMenu("palLeftData", "ptbLeftData", IsCheck ? "sys_icon_data_press.png" : "sys_icon_data.png", "lblLeftData", IsCheck);
                    pal_Log_Box.Visible = IsCheck;
                    if (IsCheck) InitLog();
                    break;
                case 2:
                    SwitchMenu("palLeftkeyboard", "ptbLeftkeyboard", IsCheck ? "sys_icon_keyboard_press.png" : "sys_icon_keyboard.png", "lblLeftkeyboard", IsCheck);
                    pal_Hotkey_Box.Visible = IsCheck;
                    if (IsCheck) InitHotkey();
                    break;
                case 3:
                    SwitchMenu("palLeftAbout", "ptbLeftAbout", IsCheck ? "sys_icon_about_press.png" : "sys_icon_about.png", "lblLeftAbout", IsCheck);
                    lbl_About.Visible = IsCheck;
                    if (IsCheck) InitAbout();
                    break;
            }
        }

        private void SwitchMenu(string palName, string ptbName, string ImgUrl, string lblName, bool IsCheck)
        {
            Panel tmp_pal = ((Panel)flpLeft.Controls[palName]);
            if (IsCheck)
            {
                tmp_pal.BackColor = System.Drawing.Color.FromArgb(80, 144, 255);
                ((Label)tmp_pal.Controls[lblName]).ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            }
            else
            {
                tmp_pal.BackColor = System.Drawing.Color.FromArgb(21, 36, 64);
                ((Label)tmp_pal.Controls[lblName]).ForeColor = System.Drawing.Color.FromArgb(147, 165, 199);
            }
            ((PictureBox)tmp_pal.Controls[ptbName]).Image = System.Drawing.Image.FromFile("Image/" + ImgUrl);
        }
        #endregion

        #region 打 印 机
        private void InitPrint()
        {
            pal_Print_Box.Height = 380;
            //加载打印名称
            if (ddlPrintName == null)
            {
                ddlPrintName = new MyDropDown(pal_Print_Box, new Point(151, 27), "setPrint_Name", toolTip1);
                string Prints = string.Empty;
                foreach (string pName in PrinterSettings.InstalledPrinters)
                {
                    Prints += pName + ";";
                }
                ddlPrintName.Items = Prints.TrimEnd(';').Split(';');
                ddlPrintName.Draw();
            }
            string tmp_PrintName = iniClass.IniReadValue("Print", "Name");
            ddlPrintName.SelectItem = tmp_PrintName;
            //加载打印联数
            if (ddlPrintJoint == null)
            {
                string tmp_PrintJointEnum = iniClass.IniReadValue("Print", "JointEnum");
                ddlPrintJoint = new MyDropDown(pal_Print_Box, new Point(151, 83), "setPrint_Joint", toolTip1);
                ddlPrintJoint.Items = tmp_PrintJointEnum.Split(';');
                ddlPrintJoint.Draw();
            }
            string tmp_PrintJoint = iniClass.IniReadValue("Print", "JointValue");
            ddlPrintJoint.SelectItem = tmp_PrintJoint;
            //加载是否开启打印
            bool tmp_IsOpenPrint = bool.Parse(iniClass.IniReadValue("Print", "OpenPrint"));
            if (tmp_IsOpenPrint)
                ptb_Print_IsOpen.Image = System.Drawing.Image.FromFile("Image/sys_icon_on.png");
            else
                ptb_Print_IsOpen.Image = System.Drawing.Image.FromFile("Image/sys_icon_off.png");
            ptb_Print_IsOpen.Tag = tmp_IsOpenPrint;
        }

        //打印-是否开启打印切换
        private void ptb_Print_IsOpen_Click(object sender, EventArgs e)
        {
            bool IsValue = bool.Parse(ptb_Print_IsOpen.Tag.ToString());
            if (IsValue)
            {
                ptb_Print_IsOpen.Image = System.Drawing.Image.FromFile("Image/sys_icon_off.png");
            }
            else
            {
                ptb_Print_IsOpen.Image = System.Drawing.Image.FromFile("Image/sys_icon_on.png");
            }
            ptb_Print_IsOpen.Tag = !IsValue;
        }

        //打印-保存
        private void ptb_Print_Set_Click(object sender, EventArgs e)
        {
            string tmp_PrintName = ddlPrintName.SelectItem;
            string tmp_PrintJoint = ddlPrintJoint.SelectItem;
            bool IsValue = bool.Parse(ptb_Print_IsOpen.Tag.ToString());
            iniClass.IniWriteValue("Print", "Name", tmp_PrintName);
            iniClass.IniWriteValue("Print", "JointValue", tmp_PrintJoint);
            iniClass.IniWriteValue("Print", "OpenPrint", IsValue.ToString());
            MessageBox.Show("保存成功!");
        }
        #endregion

        #region 日志管理
        private void InitLog()
        {
            pal_Log_Box.Location = new Point(48, 67);
            pal_Log_Box.Height = 500;
            MainStyle();
            string logPath = Application.StartupPath + "\\Log";
            if (Directory.Exists(logPath))
            {
                DirectoryInfo dir = new DirectoryInfo(logPath);
                FileInfo[] file = dir.GetFiles();
                if (file.Length > 0)
                {
                    var tmp_Log_data = file.OrderByDescending(s => s.Name).Select((x, i) => new { Rows = i + 1, FileName = x.Name, x.FullName,Del= "详细" }).ToList();
                    dgv_Log.Visible = true;
                    dgv_Log.DataSource = tmp_Log_data;
                }
                else
                {
                    dgv_Log.Visible = false;
                }
            }
        }

        public void MainStyle()
        {
            flp_G.BorderStyle = BorderStyle.None;
            flp_G.BackColor = System.Drawing.Color.FromArgb(231, 231, 231); ;
            #region DataGridVeiw Style
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Log.AllowUserToAddRows = false;
            this.dgv_Log.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(246, 249, 255);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(118, 124, 120);
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            
            //dataGridViewCellStyle2. = System.Drawing.Color.Navy;
            this.dgv_Log.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            
            this.dgv_Log.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            //dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            //dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            //dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Log.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Log.EnableHeadersVisualStyles = false;
            this.dgv_Log.GridColor = System.Drawing.Color.FromArgb(231, 231, 231);
            //this.dgv_Log.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Log.DefaultCellStyle.SelectionBackColor = Color.White;
            this.dgv_Log.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgv_Log.RowHeadersVisible = false;
            this.dgv_Log.RowTemplate.Height = 30;

            #endregion

        }
        #endregion

        #region 快 捷 键
        private void InitHotkey()
        {
            pal_Hotkey_Box.Location = new Point(48,67);
            pal_Hotkey_Box.Height = 200;
            string tmp_Hotkey_Sow = iniClass.IniReadValue("Hotkey", "ShowOrHidden");
            string tmp_Hotkey_Cash = iniClass.IniReadValue("Hotkey", "Cash");
            string tmp_Hotkey_Report = iniClass.IniReadValue("Hotkey", "Report");
            string tmp_Hotkey_Restart = iniClass.IniReadValue("Hotkey", "Restart");
            if (!string.IsNullOrEmpty(tmp_Hotkey_Sow))
            {
                tb_Hotkey_Sow.Text = tmp_Hotkey_Sow.Split(';')[0]; tb_Hotkey_Sow.Tag = tmp_Hotkey_Sow.Split(';')[0];
            }
            if (!string.IsNullOrEmpty(tmp_Hotkey_Cash))
            {
                tb_Hotkey_Cash.Text = tmp_Hotkey_Cash.Split(';')[0]; tb_Hotkey_Cash.Tag = tmp_Hotkey_Cash.Split(';')[0];
            }
            if (!string.IsNullOrEmpty(tmp_Hotkey_Report))
            {
                tb_Hotkey_Report.Text = tmp_Hotkey_Report.Split(';')[0]; tb_Hotkey_Report.Tag = tmp_Hotkey_Report.Split(';')[0];
            }
            if (!string.IsNullOrEmpty(tmp_Hotkey_Restart))
            {
                tb_Hotkey_Restart.Text = tmp_Hotkey_Restart.Split(';')[0]; tb_Hotkey_Restart.Tag = tmp_Hotkey_Restart.Split(';')[0];
            }
        }

        /// 按键
        private void tb_Hotkey_KeyDown(object sender, KeyEventArgs e)
        {
            int HotKeyValue = 0;
            string HotKeyString = "";
            e.SuppressKeyPress = false;
            e.Handled = true;
            if (e.Modifiers != Keys.None)
            {
                switch (e.Modifiers)
                {
                    case Keys.Control:
                        HotKeyString += "Ctrl + ";
                        HotKeyValue = (int)e.Modifiers;
                        break;
                    case Keys.Alt:
                        HotKeyString += "Alt + ";
                        HotKeyValue = (int)e.Modifiers;
                        break;
                    case Keys.Shift:
                        HotKeyString += "Shift + ";
                        HotKeyValue = (int)e.Modifiers;
                        break;
                    case Keys.Control | Keys.Alt:
                        HotKeyString += "Ctrl + Alt + ";
                        HotKeyValue = (int)e.Modifiers;
                        break;
                    case Keys.Control | Keys.Shift:
                        HotKeyString += "Ctrl + Shift + ";
                        HotKeyValue = (int)e.Modifiers;
                        break;
                    case Keys.Alt | Keys.Shift:
                        HotKeyString += "Alt + Shift + ";
                        HotKeyValue = (int)e.Modifiers;
                        break;
                    case Keys.Control | Keys.Alt | Keys.Shift:
                        HotKeyString += "Ctrl + Alt + Shift + ";
                        HotKeyValue = (int)e.Modifiers;
                        break;
                }
                if (e.KeyCode != Keys.None && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Menu && e.KeyCode != Keys.ShiftKey)
                {
                    HotKeyString += KeyCodeToString(e.KeyCode);
                    HotKeyValue += (int)e.KeyCode;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                {
                    HotKeyString = "无";
                    HotKeyValue = -1;
                }
                else if (e.KeyCode != Keys.None)
                {
                    HotKeyString = KeyCodeToString(e.KeyCode);
                    HotKeyValue = (int)e.KeyCode;
                }
            }
            if (HotKeyValue == 0)
                HotKeyValue = -1;
            TextBox txtHotKey = (TextBox)sender;
            txtHotKey.Text = HotKeyString;
            txtHotKey.Tag = HotKeyValue;
            txtHotKey.SelectionStart = txtHotKey.Text.Length;
        }

        /// 将按键转换成相应字符  按键  字符
        private string KeyCodeToString(Keys KeyCode)
        {
            if (KeyCode >= Keys.D0 && KeyCode <= Keys.D9)
            {
                return KeyCode.ToString().Remove(0, 1);
            }
            else if (KeyCode >= Keys.NumPad0 && KeyCode <= Keys.NumPad9)
            {
                return KeyCode.ToString().Replace("Pad", "");
            }
            else
            {
                return KeyCode.ToString();
            }
        }

        /// 设置按键不响应
        private void tb_Hotkey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// 释放按键后，若是无实际功能键，则置无
        private void tb_Hotkey_KeyUp(object sender, KeyEventArgs e)
        {
            CheckHotkey(sender);
        }

        /// 失去焦点后，若是无实际功能键，则置无
        private void tb_Hotkey_LostFocus(object sender, EventArgs e)
        {
            CheckHotkey(sender);
        }

        /// 检查是否无实际功能键，是则置无
        private void CheckHotkey(object sender)
        {
            TextBox txtHotKey = (TextBox)sender;
            if (txtHotKey.Text.EndsWith(" + ") || String.IsNullOrEmpty(txtHotKey.Text))
            {
                txtHotKey.Text = "无";
                txtHotKey.Tag = -1;
                txtHotKey.SelectionStart = txtHotKey.Text.Length;
            }
        }

        //快捷键--保存
        private void ptb_Hotkey_Set_Click(object sender, EventArgs e)
        {
            iniClass.IniWriteValue("Hotkey", "ShowOrHidden", tb_Hotkey_Sow.Text + ";" + tb_Hotkey_Sow.Tag);
            iniClass.IniWriteValue("Hotkey", "Cash", tb_Hotkey_Cash.Text + ";" + tb_Hotkey_Cash.Tag);
            iniClass.IniWriteValue("Hotkey", "Report", tb_Hotkey_Report.Text + ";" + tb_Hotkey_Report.Tag);
            iniClass.IniWriteValue("Hotkey", "Restart", tb_Hotkey_Restart.Text + ";" + tb_Hotkey_Restart.Tag);
            MessageBox.Show("保存成功!");
        }
        #endregion

        //关于
        private void InitAbout()
        {
            lbl_About.Text = iniClass.IniReadValue("VersionInfo", "Version");
            lbl_About.Location = new Point(55, 75);
        }

        //退出设置
        private void lblExitSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
