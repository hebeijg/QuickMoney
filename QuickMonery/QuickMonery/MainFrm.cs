using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QuickMonery
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        KeyboardHook kh;
        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HTCAPTION = 2;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();

        private void MainFrm_Load(object sender, EventArgs e)
        {
            kh = new KeyboardHook();

            kh.SetHook();

            kh.OnKeyDownEvent += kh_OnKeyDownEvent;
        }

        TestSystem sys ;
        TestMonery monery;

        public  bool sysStatus = false;
        public  bool monStatus = false;
        void kh_OnKeyDownEvent(object sender, KeyEventArgs e)

        {
           

            if (e.KeyData == (Keys.S | Keys.Control))
            {
                if(sysStatus ==false &&monStatus== false)
                {
                    sys = new TestSystem(this);
                    sysStatus = true;
                    sys.ShowDialog();
                }
                

            }//Ctrl+S显示窗口

            if (e.KeyData == (Keys.M | Keys.Control))
            {
                if (monStatus == false && sysStatus == false)
                {
                    monery = new TestMonery(this);
                    monStatus = true;
                    monery.ShowDialog();
                }


            }//Ctrl+S显示窗口


            if (e.KeyData == (Keys.H | Keys.Control))
            {
                if(sysStatus ==true)
                {
                    sysStatus = false;
                    sys.Close();
                }
                if(monStatus ==true)
                {
                    monStatus = false;
                    monery.Close();
                }
               
                
            }//Ctrl+H隐藏窗口


           
         
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)  // 按下的是鼠标左键             
            {
                ReleaseCapture();   // 释放捕获                
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);    // 拖动窗体             
            }
        }

        private void SystemSet_Click(object sender, EventArgs e)
        {
            sys = new TestSystem(this);
            sysStatus = true;
            sys.Show();
        }

        private void QuickMonery_Click(object sender, EventArgs e)
        {
            monery = new TestMonery(this);
            monStatus = true;
            monery.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
    }
}
