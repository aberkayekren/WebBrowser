using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebenionBrowser;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Data.SqlClient;
using WebenionBrowser.Classes.Handlers;
using WebenionBrowser.Classes.Database;

namespace WebenionBrowser.Classes.Static
{

    public class CefConfig
    {
        
        //Bir browser atayalım
        public ChromiumWebBrowser cefBrowser;

        //AnaFormumuzu burda tanımlayalım
        public WebBrowserInterFace tParent;

        public CefConfig(WebBrowserInterFace parent, Control parentObject)
        {

            tParent = parent;
            //Browser ayarları
            CefSettings cefSettings = new CefSettings();
            cefSettings.UserAgent = Config.userAgent;
            cefSettings.AcceptLanguageList = Config.acceptLanguageList;
            cefSettings.CachePath = Functions.getCachePath();

            //Ayarları her seferinde çağırmamak için bir if oluşturalım
            if (Cef.IsInitialized != true)
                //Ayarları çağıralım
                Cef.Initialize(cefSettings);
            
            //Browser'ımızı çağıralım
            cefBrowser = new ChromiumWebBrowser();
            //Textbox URL'sini Titlebar adını ve sitenin yeniden yüklenme olayını kontrol eden bir metot oluşturalım
            setEventHandlers();
            //Controlleri browserımıza ekleyelim
            parentObject.Controls.Add(cefBrowser);
            //Browserı ana kapayıcıda yerleştirelim
            cefBrowser.Dock = DockStyle.Fill;

            //Webbrowserımız ilk açıldığında ana sayfamıza yönlendirelim
            Navigate(Functions.getHomeUrl());

        }

        public void setEventHandlers()
        {
            //Textbox URL'sini değiştirilmesini kontrol edelim
            cefBrowser.AddressChanged += CefBrowserAddressChaanged;
            //TitleBar adını değiştirilmesini kontrol edelim
            cefBrowser.TitleChanged += CefBrowser_TitleChanged;
            //Sitenin yüklenme olayını kontrol edelim
            cefBrowser.LoadingStateChanged += CefBrowser_LoadingStateChanged;

            cefBrowser.MenuHandler = new ContextMenuHandler();
            cefBrowser.DownloadHandler = new DowloadHandler();

        }

        private void CefBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            //Yeniden yüklen
            tParent.setRefreshButtonType(e.Browser.IsLoading);
            tParent.setButtonState(e.Browser.CanGoBack, e.Browser.CanGoForward);

        }

        public void CefBrowser_TitleChanged(object sender, TitleChangedEventArgs e)

        {
            tParent.Text = e.Title.ToString();

        }

        private void CefBrowserAddressChaanged(object sender, AddressChangedEventArgs e)
        {
            //Formun içindeki arama textbox'ının içine sitenin URL'sini göstermek için
            tParent.setUrl(e.Address);

            tParent.setFavİcon(e.Address);

            //tParent.setFavIcon(e.Address.ToString());

            if (tParent.Text != "Yeni Sekme" && tParent.Text != "Google")
                databaseConfig.HistorySettings.Add(tParent.Text, e.Address.ToString(), DateTime.Now.ToShortDateString() + DateTime.Now.ToLongTimeString());
        }



        public void Navigate(string _url)
        {
            string processUrl = _url.ToLower();

            if (_url.Contains(" ") || _url.Contains("\n"))
                Search(_url);

            else
            {
                if (Functions.checkURL(processUrl))
                    cefBrowser.Load(_url);
                else
                    Search(_url);
            }

        }

        public void Search(string searchText)
        {

            cefBrowser.Load(Functions.getSearchEngine() + searchText);

        }

        public ChromiumWebBrowser getBrowser()
        {

            return cefBrowser;

        }

    }

}
