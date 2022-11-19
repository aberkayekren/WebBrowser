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
using WebenionBrowser.Classes.Database;
using WebenionBrowser.Classes.Handlers;
using System.Diagnostics;
using System.IO;

namespace WebenionBrowser.Forms
{
    public partial class DowloadsPage : Form
    {
        public DowloadsPage()
        {
            InitializeComponent();
        }

        private void webonionDowloadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.webonionDowloadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webonionWebBrowserDataSet);

        }

        private void webonionDowloadBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.webonionDowloadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webonionWebBrowserDataSet);

        }
        SqlConnection con = databaseConfig.connection;
        SqlDataAdapter dataAdapter;
        DataSet dataSet;
        void GridViewDoldur()
        {
            dataAdapter = new SqlDataAdapter("Select * From WebonionDowload Order by Id DESC", con);
            dataSet = new DataSet();
            con.Open();
            dataAdapter.Fill(dataSet, "WebonionHistory");
            webonionDowloadBunifuDataGridView.DataSource = dataSet.Tables["WebonionHistory"];
            con.Close();
        }
        private void DowloadsPage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'webonionWebBrowserDataSet.WebonionDowload' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.webonionDowloadTableAdapter.Fill(this.webonionWebBrowserDataSet.WebonionDowload);
            GridViewDoldur();
        }

        public int number;
        //DowloadHandler dowloadHandler = new DowloadHandler();
        private void webonionDowloadBunifuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                foreach (DataGridViewRow viewRow in webonionDowloadBunifuDataGridView.SelectedRows)
                {
                    number = Convert.ToInt32(viewRow.Cells[0].Value);
                }
                Process.Start(configDefines.dowloadLocation);
            }
            else if (e.ColumnIndex == 8)
            {
                foreach (DataGridViewRow viewRow in webonionDowloadBunifuDataGridView.SelectedRows)
                {
                    number = Convert.ToInt32(viewRow.Cells[0].Value);
                    databaseConfig.DowloadSettings.IndirilenSil(number);
                    //File.Delete(@"'" + configDefines.dowloadLocation.Replace(@"\", @"\\") + dowloadHandler.name + "'");
                }
                GridViewDoldur();
            }
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
