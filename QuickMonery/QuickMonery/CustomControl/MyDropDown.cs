using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickMonery.CustomControl
{
    public class MyDropDown
    {
        private Panel ParentBox;
        private Point LocationValue;
        private string ThisName;
        private ComboBox com_Box;//下拉列表
        private Label lab_value;//
        private ToolTip tool_Tip;
        public string[] Items { get; set; }

        private string SelectItem_Pub;
        public string SelectItem
        {
            get { return SelectItem_Pub; }
            set
            {
                SelectItem_Pub = lab_value.Text = com_Box.Text = value;
                tool_Tip.SetToolTip(lab_value, value);
            }
        }
        public MyDropDown(Panel Parent, Point Location, string ObjName, ToolTip tooltip)
        {
            ParentBox = Parent;
            LocationValue = Location;
            ThisName = ObjName;
            tool_Tip = tooltip;
        }

        public void Draw()
        {
            //主框
            Panel mainbox = new Panel();
            mainbox.Name = ThisName; mainbox.Location = LocationValue; mainbox.Width = 200; mainbox.Height = 34;
            mainbox.BackgroundImage = System.Drawing.Image.FromFile("Image/pub_combox_bg.png");
            //下拉
            com_Box = new ComboBox();
            com_Box.Name = ThisName + "_cb"; com_Box.Parent = mainbox; com_Box.Location = new Point(5, 8); com_Box.Width = 190; 
            com_Box.Font = new Font(new FontFamily("黑体"), 12, FontStyle.Regular);
            com_Box.ForeColor = System.Drawing.Color.FromArgb(108, 108, 108);
            com_Box.FlatStyle = FlatStyle.Flat; com_Box.DropDownStyle = ComboBoxStyle.DropDownList;
            com_Box.FormattingEnabled = true;
            com_Box.TextChanged += new System.EventHandler(ComboBox_TextChanged);
            com_Box.Items.AddRange(Items);            
            mainbox.Controls.Add(com_Box);
            //遮盖
            Panel delbox = new Panel();
            delbox.Name = ThisName + "_pal"; delbox.Parent = ParentBox; delbox.Width = 194; delbox.Height = 30;
            delbox.Location = new Point(LocationValue.X + 3, LocationValue.Y + 2);
            delbox.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            //文本
            lab_value = new Label();
            lab_value.Name = ThisName + "_lab"; lab_value.Width = 160; lab_value.Location = new Point(5, 7);
            lab_value.Font = new Font(new FontFamily("黑体"), 11);
            lab_value.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            lab_value.Text = SelectItem_Pub;
            delbox.Controls.Add(lab_value);
            //图标
            PictureBox pb = new PictureBox();
            pb.Width = 20; pb.Height = 20; pb.Parent = delbox; pb.Location = new Point(170, 5);
            pb.Image = System.Drawing.Image.FromFile("Image/icon_arrow_down.png");
            pb.Cursor = Cursors.Hand;
            pb.Click += new EventHandler(PictureBox_Click);
            delbox.Controls.Add(pb);

            ParentBox.Controls.Add(delbox);
            ParentBox.Controls.Add(mainbox);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            this.com_Box.DroppedDown = !this.com_Box.DroppedDown;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            lab_value.Tag = lab_value.Text = SelectItem_Pub = com_Box.Text;
            tool_Tip.SetToolTip(lab_value, com_Box.Text);
        }
    }
}
