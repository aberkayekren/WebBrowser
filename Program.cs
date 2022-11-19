using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace WebenionBrowser
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            getOutArgs();

            AppContainer container = new AppContainer();
            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new WebBrowserInterFace
                    {
                        Text = "Yeni Sekme"
                    }
                }
            );

            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }

        public static void getOutArgs()
        {
            string[] inArgs = Environment.GetCommandLineArgs();
            foreach (string arg in inArgs)
            {
                if (arg == "-debug")
                    Functions.Debug = true;
            }
        }
    }
}
