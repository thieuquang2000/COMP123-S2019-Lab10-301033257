using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301033257
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void EndFrom_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static StartForm startform;

    }
}
