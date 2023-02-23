using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CromiumBrowserWinFormsDotNet4_2022_2023
{
    public partial class Browser : Form
    {
        ChromiumWebBrowser chromiumBrowser = null;
        List<ChromiumWebBrowser> chromiumBrowsers = new List<ChromiumWebBrowser>();

        public Browser()
        {
            InitializeComponent();
            InitializeBrowswer();
        }

        public void InitializeBrowswer()
        {
            var settings = new CefSettings();
            Cef.Initialize(settings);

            chromiumBrowser = new ChromiumWebBrowser("https://google.com");
            BrowserTabs.TabPages[0].Controls.Add(chromiumBrowser);            
            chromiumBrowser.Dock = DockStyle.Fill;

            chromiumBrowser = new ChromiumWebBrowser("https://google.com");
            BrowserTabs.TabPages[1].Controls.Add(chromiumBrowser);
            chromiumBrowser.Dock = DockStyle.Fill;
        }

        private void Go_Click(object sender, EventArgs e)
        {
        }

        private void addBrowserTab_Click(object sender, EventArgs e)
        {
            AddBrowserTab();
        }

        private void AddBrowserTab()
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "Browser page";

            chromiumBrowser = new ChromiumWebBrowser("https://google.com");
            tabPage.Controls.Add(chromiumBrowser);
            chromiumBrowser.Dock = DockStyle.Fill;

            BrowserTabs.TabPages.Add(tabPage);
        }

        private void removeBrowserTab_Click(object sender, EventArgs e)
        {
            try
            {
                if (BrowserTabs.TabCount > 1)
                {
                    BrowserTabs.TabPages.Remove(BrowserTabs.SelectedTab);
                }
                else
                {
                    BrowserTabs.TabPages.Remove(BrowserTabs.SelectedTab);
                    AddBrowserTab();
                }
                
                    
            }
            catch (Exception)
            {
                
            }     

        }
        private void AleksejMethod()
        {
            //methode
        }
    }
}
