﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using MaterialSkin;
using MaterialSkin.Controls;
using WebenionBrowser.Classes;
using WebenionBrowser.Classes.Static;

namespace WebenionBrowser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);

        }
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new WebBrowserInterFace
                {
                    Text = "Yeni Sekme"
                }
            };
        }

        private void AppContainer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
