using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            Color myDefault = Color.FromArgb(199, 225, 167);
            Color myColor = Color.FromArgb(31, 122, 91);
            btnRezerwacje.BackColor = myDefault;
            btnLista.BackColor = myColor;
            tabControl1.SelectedIndex = 0;

        }

        private void btnRezerwacje_Click(object sender, EventArgs e)
        {
            Color myDefault = Color.FromArgb(199, 225, 167);
            Color myColor = Color.FromArgb(31, 122, 91);
            btnLista.BackColor = myDefault;
            btnRezerwacje.BackColor = myColor;
            tabControl1.SelectedIndex = 2;
        }
    }
}
