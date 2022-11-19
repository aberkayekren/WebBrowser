using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using WebenionBrowser.Classes;
using System.Data.SqlClient;
using WebenionBrowser.Forms;
using EasyTabs;
using WebenionBrowser.Classes.Static;
using WebenionBrowser.Classes.Database;
using WebenionBrowser.Classes.Libs;

namespace WebenionBrowser
{
    public partial class WebBrowserInterFace : Form
    {
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        //public static WebBrowserInterFace getCurrentForm()
        //{
        //    //return Functions.getMainForm().returnTab
        //}

        //CefConfig classımızı çağıralım
        private CefConfig cefConfig;
        //Browserımızı burda bir daha tanımlayalım
        private ChromiumWebBrowser IsWorkingBrowser;


        public WebBrowserInterFace()
        {
            
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            cefConfig = new CefConfig(this, webBrowserPanel);
            IsWorkingBrowser = cefConfig.getBrowser();
        }

        SqlConnection con = databaseConfig.connection;
        SqlDataReader read;

        public void verileriGoster()
        {
            lstFavView.Items.Clear();

            con.Open();
            SqlCommand command = new SqlCommand("select * from WebonionFavorites", con);
            read = command.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["URl"].ToString();
                ekle.SubItems.Add(read["Ad"].ToString());
                ekle.SubItems.Add(read["Id"].ToString());

                lstFavView.Items.Add(ekle);
            }

            con.Close();
        }


        //public void setFavIcon(string favUrl)
        //{
        //    con.Open();
        //    SqlCommand command = new SqlCommand("select * from WebonionFavorites where URl=@url", con);
        //    command.Parameters.AddWithValue("@url", favUrl);
        //    read = command.ExecuteReader();
        //    while (read.Read())
        //    {
        //        if (favUrl == read["URl"].ToString())
        //        {
        //            btnFavorite.Image = Properties.Resources.star__1_;
        //            btnFavorite.Enabled = false;
        //            break;
        //        }
        //        else
        //        {
        //            btnFavorite.Image = Properties.Resources.star;
        //            btnFavorite.Enabled = true;
        //        }
        //    }
        //    con.Close();
        //}

        private void WebBrowserInterFace_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'webonionWebBrowserDataSet.WebonionFavorites' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.webonionFavoritesTableAdapter.Fill(this.webonionWebBrowserDataSet.WebonionFavorites);
            if (Properties.Settings.Default.EmailSite == "https://mail.google.com/mail/u/0/")
            {
                GmailIcon.Image = Properties.Resources.gmail;
                Gmail.Text = "Gmail";
            }
            else if (Properties.Settings.Default.EmailSite == "https://outlook.live.com/mail/0/")
            {
                GmailIcon.Image = Properties.Resources.outlook;
                Gmail.Text = "Outlook";
            }
            setSearchEngineIcon(Properties.Settings.Default.homeUrl);
            verileriGoster();
        }
        public void setSearchEngineIcon(string url)
        {
            if (url == "https://google.com")
            {
                txtAra.RightIcon.Image = Properties.Resources.google;
            }
            else if (url == "https://duckduckgo.com")
            {
                txtAra.RightIcon.Image = Properties.Resources.DDG_icon_256x256;
            }
            else if (url == "https://bing.com")
            {
                txtAra.RightIcon.Image = Properties.Resources.bing;
            }
            else if (url == "https://yandex.com.tr")
            {
                txtAra.RightIcon.Image = Properties.Resources.yandex;
            }
        }

        public  void setFavİcon(string URL)
        {
            btnFavorite.Image = Properties.Resources.star;
            btnFavorite.Enabled = true;
            con.Open();
            SqlCommand command = new SqlCommand("select URl from WebonionFavorites where URl=@url", con);
            command.Parameters.AddWithValue("@url", URL);
            read = command.ExecuteReader();
            while (read.Read())
            {
                if (URL == read["URl"].ToString().Trim())
                {
                    btnFavorite.Image = Properties.Resources.star__1_;
                    btnFavorite.Enabled = false;
                    break;
                }
            }
            con.Close();
        }
        //Girilmiş olan sitenin güvenli olup olmadığını belirten iconları gösteren bir metod tanımlayalım
        public void setUrl(string URL)
        {

            //URL'mizi tanımlayalım
            txtAra.Text = URL;
            //Eğer girilen sayfa https kaynaklıysa
            if (txtAra.Text.Contains("https://"))
                //Güvenli olduğunu belirtelim
                setSecurityPageState("true");
            //Eğer girilen sayfa http kaynaklıysa
            else if (txtAra.Text.Contains("http://"))
                //Güvenliniğinin belli olmadığını belirtelim
                setSecurityPageState("maybe");
            //Eğer girilen sayfa https veya http kaynaklı değil ise
            else
                //Güvenli olmadığını belirtelim
                setSecurityPageState("false");
        }

        public void setSecurityPageState(string secTrue)
        {
           
            //Eğer girilen sayfa https kaynaklıysa
            if (secTrue == "true")
                //Güvenli olmaduğunu belirten bir icon koyalım
                txtAra.LeftIcon.Image = Properties.Resources.shield;
            //Eğer girilen sayfa http kaynaklıysa
            else if (secTrue == "maybe")
                //Güvenliniğinin belli olmadığını belirten bir icon koyalım
                txtAra.LeftIcon.Image = Properties.Resources.warning;
            //Eğer girilen sayfa https veya http kaynaklı değil ise
            else
                //Güvenli olmadığını belirten bir icon koyalım
                txtAra.LeftIcon.Image = Properties.Resources.notShield;
        
        }
        public void setRefreshButtonType(bool isLoading)
        {

            //Yenileme iconunu tanımlayalım
            var refreshIco = Properties.Resources.refreshing;
            //Durdurma iconunu tanımlayalım
            var refreshStopIco = Properties.Resources.cancel;

            //Eğer sayfa yükleniyorsa ? buttonun resmini durdurma : değilse yenileme olarak değişelim
            btnRefresh.Image = isLoading ? refreshStopIco : refreshIco;
        
        }
        public void setButtonState(bool _ifGoBack, bool _ifGoForward)
        {

            //Geri gidebiliyorsa butonu aktifleştirsin
            btnGoBack.Enabled = _ifGoBack;
            //İleri gidebiliyorsa butonu aktifleştirsin
            btnGoForward.Enabled = _ifGoForward;

        }

        private void pctbKullaniciProfili_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowserSettings_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
        
            //Eğer Enter tuşuna basıldıysa 
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                //Bizi sayfaya veya arama motoruna yönlendirmek için metodumuzu çağıralım
                cefConfig.Navigate(txtAra.Text);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            //Eğer sayfa yeniden yükleniyorsa
            if (IsWorkingBrowser.IsLoading)
                //Tıklandığında sayfanın geri yüklenmesini durdursun
                IsWorkingBrowser.Stop();
            else
                //Tıklandığında sayfayı geri yüklesin
                IsWorkingBrowser.Reload();

            setSearchEngineIcon(Properties.Settings.Default.homeUrl);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
        
            //Eğer browserda geri gidilebilirse
            if (IsWorkingBrowser.CanGoBack)
                //Butona tıklandığında geri gitsin
                IsWorkingBrowser.Back();
        
        }

        private void btnGoForward_Click(object sender, EventArgs e)
        {
        
            //Eğer browserda ileri gidilebilirse
            if (IsWorkingBrowser.CanGoForward)
                //Butona tıklandığında ileri gitsin
                IsWorkingBrowser.Forward();
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DefaultMenu.Show(Cursor.Position);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DowloadsPage dowloadsPage = new DowloadsPage();
            dowloadsPage.Show();    
        }

        private void yeniSekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppContainer container = new AppContainer();
            ParentTabs.Tabs.Add(
                new TitleBarTab(ParentTabs)
                {
                    Content = new WebBrowserInterFace
                    {
                        Text = "Yeni Sekme"
                    }
                });
        }

        private void yeniPencereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppContainer container = new AppContainer();
            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new WebBrowserInterFace
                    {
                        Text = "Yeni Sekme"
                    }
                });

            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
        }

        private void geçmişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void indirilenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DowloadsPage dowloadsPage = new DowloadsPage();
            dowloadsPage.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }
    
        private void geçerliSekmeyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webonionFavoritesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.webonionFavoritesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.webonionWebBrowserDataSet);

        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            favoritesStrings.url = txtAra.Text;
            favoritesStrings.siteName = this.Text;
            AddFavorite addFavorite = new AddFavorite();
            addFavorite.Show();
        }

        private void btnFavoritePanelGoster_Click(object sender, EventArgs e)
        {
            if (favoriteShowPanel.Visible == true)
            {
                favoriteShowPanel.Visible = false;
                verileriGoster();
            }
            else
            {
                favoriteShowPanel.Visible = true;
                verileriGoster();
            }
        }

        private void btnFavoritePanelGizle_Click(object sender, EventArgs e)
        {
            favoriteShowPanel.Visible = false;
            verileriGoster();
        }

        private void lstFavView_DoubleClick(object sender, EventArgs e)
        {
            string url = lstFavView.SelectedItems[0].SubItems[0].Text;
            cefConfig.cefBrowser.Load(url);
        }

        private void btnFavKaldır_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem viewRow in lstFavView.SelectedItems)
            {
                string url = viewRow.SubItems[0].Text;
                databaseConfig.FavoritesSettings.Kaldir(url);
            }
            setFavİcon(txtAra.Text);
            verileriGoster();
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            cefConfig.cefBrowser.Load("youtube.com");
        }

        private void SearchEngineIcon_Click(object sender, EventArgs e)
        {
            cefConfig.cefBrowser.Load(Properties.Settings.Default.homeUrl);
        }

        private void Gmail_Click(object sender, EventArgs e)
        {
            cefConfig.cefBrowser.Load(Properties.Settings.Default.EmailSite);
        }

        private void GmailIcon_Click(object sender, EventArgs e)
        {
            cefConfig.cefBrowser.Load(Properties.Settings.Default.EmailSite);
        }

        private void SearchEngine_Click(object sender, EventArgs e)
        {
            cefConfig.cefBrowser.Load(Properties.Settings.Default.homeUrl);
        }

        private void youtubeIcon_Click(object sender, EventArgs e)
        {
            cefConfig.cefBrowser.Load("youtube.com");
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsPage settings = new SettingsPage();
            settings.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
