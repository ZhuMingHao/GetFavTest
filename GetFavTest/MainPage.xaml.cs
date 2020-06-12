using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GetFavTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyWebView.ScriptNotify += MyWebView_ScriptNotify;
        }

        private void MyWebView_ScriptNotify(object sender, NotifyEventArgs e)
        {

        }



        private async void MyWebView_LoadCompleted(object sender, NavigationEventArgs e)
        {
           
        }

        private async void MyWebView_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            string functionString = @"var nodeList = document.getElementsByTagName ('link');
            for (var i = 0; i < nodeList.length; i++)
            {
                if ((nodeList[i].getAttribute('rel') == 'icon') || (nodeList[i].getAttribute('rel') == 'shortcut icon'))
                {
                    favicon = nodeList[i].getAttribute('href');
                    window.external.notify(favicon); 
                }
            }";

            await MyWebView.InvokeScriptAsync("eval", new string[] { functionString });
        }
    }
}
