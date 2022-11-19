using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebenionBrowser;
using System.Windows.Forms;
using System.Net;
using WebenionBrowser.Classes.Static;

namespace WebenionBrowser
{
    public static class Functions
    {

        public static bool Debug = false;

        public static WebBrowserInterFace getMainForm()
        {
            foreach (WebBrowserInterFace workingForm in Application.OpenForms)
                return workingForm;
            return null;
        }

        public static string getSearchEngine()
        {
            return Properties.Settings.Default.searchEngineParameter;
        }

        public static List<string> getUrlProtocols()
        {
            List<string> protocols = new List<string>();
            protocols.Add("http");
            protocols.Add("https");
            protocols.Add("file");
            protocols.Add("ftp");
            protocols.Add("info");
            protocols.Add("data");

            return protocols;
        }

        public static string getHomeUrl()
        {

            string _homeUrl = Properties.Settings.Default.homeUrl;
            return _homeUrl != "" ? _homeUrl : Config.tabDefaultUrl;

        }

        public static bool checkURL(string _url)
        {
            _url = _url.ToLower();

            if (_url.Contains(" ") || _url.Contains("\n")) return false;

            bool isFounded = false;
            bool isValid = false;

            foreach (string protocolNames in getUrlProtocols())
            {
                if (_url.StartsWith(protocolNames + "://"))
                {
                    isFounded = true;
                    break;
                }
            }

            if (_url.Contains(".") || _url == "localhost")
                isValid = true;

            if (isFounded && !isValid) return true;
            else if (!isFounded && isValid) return true;
            else if (isFounded && isValid) return true;
            else if (!isFounded && !isValid) return false;

            return false;
        }


        public static string getCachePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\WebenionBrowser";
        }

        internal static object getCurrentForm()
        {
            throw new NotImplementedException();
        }
    }
}
