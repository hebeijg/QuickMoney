using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuickMonery.Common;
namespace QuickMonery
{
    public partial class TestMonery : Form
    {
        public TestMonery()
        {
            InitializeComponent();
        }
        MainFrm _frm;
        public TestMonery(MainFrm frm)
        {
            _frm = frm;

            InitializeComponent();
        }
        private void TestMonery_Load(object sender, EventArgs e)
        {

        }

        private void TestMonery_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frm.monStatus = false;
            string filePath = Application.StartupPath + "\\config.ini";
            IniFile ini = new IniFile(filePath);

            string ss = ini.IniReadValue("VersionInfo", "Version");
        }
    }
}
