using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebenionBrowser.Classes.Database;
using WebenionBrowser.Classes.Libs;

namespace WebenionBrowser.Forms
{
    public partial class AddFavorite : Form
    {
        public AddFavorite()
        {
            InitializeComponent();
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            databaseConfig.FavoritesSettings.Add(txtSiteUrl.Text, txtSiteAdi.Text);
            this.Close();
        }

        private void AddFavorite_Load(object sender, EventArgs e)
        {
            txtSiteUrl.Text = favoritesStrings.url;
            txtSiteAdi.Text = favoritesStrings.siteName;
        }

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
