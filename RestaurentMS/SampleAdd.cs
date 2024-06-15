using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentMS
{
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void SampleAdd_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            guna2PictureBox1.Enabled = true;
            guna2Panel1.Enabled = true;
            guna2Panel2.Enabled = true;

            btnSave.Visible = true;
            btnClose.Visible = true;
            guna2PictureBox1.Visible = true;
            guna2Panel1.Visible = true;
            guna2Panel2.Visible = true;


        }
    }
}
