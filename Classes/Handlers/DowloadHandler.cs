using CefSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebenionBrowser.Forms;
using WebenionBrowser.Classes.Database;


namespace WebenionBrowser.Classes.Handlers
{
    public class DowloadHandler : IDownloadHandler
    {

        bool isOpenWhenComplete = false;
        public string name;
        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            bool _continue = true;
            var dowloadDialog = new QuestionDowloadForm(downloadItem.SuggestedFileName, downloadItem.TotalBytes.ToString(), downloadItem.OriginalUrl);
            var dialogResults = dowloadDialog.ShowDialog();

            if (dialogResults  == System.Windows.Forms.DialogResult.Yes)
            {
                isOpenWhenComplete = true;
            }
            else if (dialogResults == System.Windows.Forms.DialogResult.Cancel)
            {
                downloadItem.IsCancelled = true;
                callback.Dispose();
                _continue = false;
            }
            if (_continue)
            {
                var fullPath = configDefines.dowloadLocation + downloadItem.SuggestedFileName;
                callback.Continue(fullPath,showDialog: false);
                databaseConfig.DowloadSettings.Add(downloadItem.SuggestedFileName, configDefines.dowloadLocation, downloadItem.TotalBytes.ToString(), downloadItem.OriginalUrl, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString(), _continue.ToString());
                name = downloadItem.SuggestedFileName;
            }
        }

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {

            if (downloadItem.IsComplete && isOpenWhenComplete)
            {
                Process.Start(downloadItem.FullPath);
            }

        }
    }
}
