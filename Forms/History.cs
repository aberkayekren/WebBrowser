using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WebenionBrowser.Classes;
using WebenionBrowser.Classes.Database;

namespace WebenionBrowser.Forms
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();

        }

        int Move, MouseX, MouseY;

        private void webonionHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.webonionHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webonionWebBrowserDataSet);

        }
        SqlConnection con = databaseConfig.connection;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;

        void GridViewDoldur()
        {
            dataAdapter = new SqlDataAdapter("Select * From WebonionHistory Order by Id DESC", con);
            dataSet = new DataSet();
            con.Open();
            dataAdapter.Fill(dataSet, "WebonionHistory");
            webonionHistoryBunifuDataGridView.DataSource = dataSet.Tables["WebonionHistory"];
            con.Close();
        }


        private void History_Load_1(object sender, EventArgs e)
        {
            GridViewDoldur();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formBorder_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            MouseX = e.X;
            MouseY = e.Y;
        }

        private void formBorder_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0; 
        }

        private void formBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
                this.SetDesktopLocation(MousePosition.X - MouseX, MousePosition.Y - MouseY);
        }

        private void btnSeciliSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow viewRow in webonionHistoryBunifuDataGridView.SelectedRows)
            {
                int number = Convert.ToInt32(viewRow.Cells[0].Value);
                databaseConfig.HistorySettings.KayıtSil(number);
            }
            GridViewDoldur();
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            databaseConfig.HistorySettings.AllClear();

            GridViewDoldur();
        }

        private void History_Load(object sender, EventArgs e)
        {
            GridViewDoldur();
        }

    }
}
