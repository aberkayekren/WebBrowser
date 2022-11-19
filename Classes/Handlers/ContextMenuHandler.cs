using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebenionBrowser.Classes;
using WebenionBrowser.Classes.Static;
using System.Windows.Forms;

namespace WebenionBrowser.Classes.Handlers
{
    class ContextMenuHandler : IContextMenuHandler
    {
        public void OnBeforeContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            model.Clear();

            if (parameters.SelectionText == "")
            {
                model.AddItem((CefMenuCommand)100, "Geri");
                model.AddItem((CefMenuCommand)101, "İleri");
                if (browser.IsLoading) { model.AddItem((CefMenuCommand)104, "Dur"); } else { model.AddItem((CefMenuCommand)102, "Yenile"); }

                model.AddSeparator();
            }
            else if (parameters.SelectionText != "")
            {
                model.AddItem((CefMenuCommand)116, "Tümünü Seç");
                model.AddItem((CefMenuCommand)110, "Geri Al");
                model.AddItem((CefMenuCommand)111, "Yinele");
                model.AddSeparator();
                model.AddItem((CefMenuCommand)112, "Kes");
                model.AddItem((CefMenuCommand)113, "Kopyala");
                model.AddItem((CefMenuCommand)114, "Yapıştır");
                model.AddSeparator();
            }
            model.AddItem((CefMenuCommand)131, "Yazdır");
            model.AddSeparator();
            model.AddItem((CefMenuCommand)132, "Sayfa Kaynağını Görüntüle");
            model.AddItem((CefMenuCommand)26500, "İncele");
        }
        public bool OnContextMenuCommand(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            WebBrowserInterFace webBrowserInterFace = new WebBrowserInterFace();
            if (commandId == (CefMenuCommand)26500)
            {
                browser.GetHost().ShowDevTools();
                return true;
            }
            
            return false;
        }

        public void OnContextMenuDismissed(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame)
        {

        }

        public bool RunContextMenu(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
