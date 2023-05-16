using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog job = new OpenFileDialog();
            job.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";

            if (job.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = job.FileName;
            }
            else
            {
                MessageBox.Show("Select the file or correct file please");
            }
        }
    }
}
