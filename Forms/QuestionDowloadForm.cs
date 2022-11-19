using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebenionBrowser.Forms
{
    public partial class QuestionDowloadForm : Form
    {
        public QuestionDowloadForm(string fileName, string fileSize, string fileUrl)
        {
            InitializeComponent();

            lblFileName.Text = fileName;
            lblFileSize.Text = fileSize;
            lblFileUrl.Text = fileUrl;
        }

        private void DowloadForm_Load(object sender, EventArgs e)
        {

        }

        private void btnİndirAc_Click(object sender, EventArgs e)
        {

        }
    }
}
