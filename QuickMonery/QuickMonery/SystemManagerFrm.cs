using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickMonery
{
    public partial class SystemManagerFrm : Form
    {
        #region 属性
        //设置类型  0=打印机 1=日志管理 2=快捷键 3=关于
        private int SetType = 0;
        //标题集合
        private string[] TitleValue = { "打印机相关设置", "日志管理", "快捷键设置", "关于" };
        #endregion

        public SystemManagerFrm()
        {
            InitializeComponent();
        }

        #region 菜单切换
        private void lblSwitchMenu_Click(object sender, EventArgs e)
        {
            Label tmp_obj = (Label)sender;
            int tmp_SetType = int.Parse(tmp_obj.Tag.ToString());
            if (SetType != tmp_SetType)
            {
                PubSwitch(SetType, false);
                PubSwitch(tmp_SetType, true);
                SetType = tmp_SetType;
                lblCtTitle.Text = TitleValue[SetType];
            }
        }
        private void PubSwitch(int SetType, bool IsCheck)
        {
            switch (SetType)
            {
                case 0:
                    SwitchMenu("palLeftPrint", "ptbLeftPrint", IsCheck ? "sys_icon_print_press.png" : "sys_icon_print.png", "lblLeftPrint", IsCheck);
                    break;
                case 1:
                    SwitchMenu("palLeftData", "ptbLeftData", IsCheck ? "sys_icon_data_press.png" : "sys_icon_data.png", "lblLeftData", IsCheck);
                    break;
                case 2:
                    SwitchMenu("palLeftkeyboard", "ptbLeftkeyboard", IsCheck ? "sys_icon_keyboard_press.png" : "sys_icon_keyboard.png", "lblLeftkeyboard", IsCheck);
                    break;
                case 3:
                    SwitchMenu("palLeftAbout", "ptbLeftAbout", IsCheck ? "sys_icon_about_press.png" : "sys_icon_about.png", "lblLeftAbout", IsCheck);
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

        //退出设置
        private void lblExitSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
