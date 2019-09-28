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
    public partial class TestSystem : Form
    {
        public TestSystem()
        {
            InitializeComponent();
        }

        MainFrm _frm;
        public TestSystem(MainFrm frm)
        {
            _frm = frm;

            InitializeComponent();
        }

        private void TestSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frm.sysStatus = false;
        }
    }
}
