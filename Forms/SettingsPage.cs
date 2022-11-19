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
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void webonionFavoritesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.webonionFavoritesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.webonionWebBrowserDataSet);

        }
        static string baslangicSearchEngine = Properties.Settings.Default.searchEngineParameter;
        static string baslangicMail = Properties.Settings.Default.EmailSite;
        static string baslangicSitesi = Properties.Settings.Default.homeUrl;
        private void SettingsPage_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'webonionWebBrowserDataSet.WebonionFavorites' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.webonionFavoritesTableAdapter.Fill(this.webonionWebBrowserDataSet.WebonionFavorites);
            
        }
        DialogResult cikis = new DialogResult();
        private void btnFormClose_Click(object sender, EventArgs e)
        {
            cikis = MessageBox.Show("Deüişikleri kaydedip çıkmak istiyor musunuz?","Bilgilendirme",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);

            if (cikis == DialogResult.Yes)
            {
                baslangicSearchEngine = Properties.Settings.Default.searchEngineParameter;
                Properties.Settings.Default.Save();
                baslangicMail = Properties.Settings.Default.EmailSite;
                Properties.Settings.Default.Save();
                baslangicSitesi = Properties.Settings.Default.homeUrl;
                Properties.Settings.Default.Save();
                MessageBox.Show("Değişiklikler uygulamayı kapatıp açıtığınızda güncellenecektir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                Properties.Settings.Default.searchEngineParameter = baslangicSearchEngine;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.EmailSite = baslangicMail;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.homeUrl = baslangicSitesi;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void cmbTarayiciMotoru_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tarayiciMotorlari = { "https://duckduckgo.com/", "https://google.com/search?q=", "https://bing.com/search?q=", "https://yandex.com.tr/search/?text=" };

            if (cmbTarayiciMotoru.Text == "Google")
            {
                pbAramaMotoru.Image = Properties.Resources.google;
                Properties.Settings.Default.searchEngineParameter = tarayiciMotorlari[1];
                Properties.Settings.Default.Save();
                Properties.Settings.Default.homeUrl = "https://google.com";
                Properties.Settings.Default.Save();
            }
            else if (cmbTarayiciMotoru.Text == "DuckDuckGo")
            {
                pbAramaMotoru.Image = Properties.Resources.DDG_icon_256x256;
                Properties.Settings.Default.searchEngineParameter = tarayiciMotorlari[0];
                Properties.Settings.Default.Save();
                Properties.Settings.Default.homeUrl = "https://duckduckgo.com";
                Properties.Settings.Default.Save();
            }
            else if (cmbTarayiciMotoru.Text == "Bing")
            {
                pbAramaMotoru.Image = Properties.Resources.bing;
                Properties.Settings.Default.searchEngineParameter = tarayiciMotorlari[2];
                Properties.Settings.Default.Save();
                Properties.Settings.Default.homeUrl = "https://bing.com";
                Properties.Settings.Default.Save();
            }
            else if (cmbTarayiciMotoru.Text == "Yandex")
            {
                pbAramaMotoru.Image = Properties.Resources.yandex;
                Properties.Settings.Default.searchEngineParameter = tarayiciMotorlari[3];
                Properties.Settings.Default.Save();
                Properties.Settings.Default.homeUrl = "https://yandex.com.tr";
                Properties.Settings.Default.Save();
            }
        }

        private void cmbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmail.Text == "Gmail")
            {
                pbMail.Image = Properties.Resources.gmail;
                Properties.Settings.Default.EmailSite = "https://mail.google.com/mail/u/0/";
                Properties.Settings.Default.Save();
            }
            else if (cmbEmail.Text == "Outlook")
            {
                pbMail.Image = Properties.Resources.outlook;
                Properties.Settings.Default.EmailSite = "https://outlook.live.com/mail/0/";
                Properties.Settings.Default.Save();
            }
        }
    }
}
