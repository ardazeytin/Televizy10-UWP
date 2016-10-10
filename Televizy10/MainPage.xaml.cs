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
using Televizy10.Models;
using Windows.UI.Core;
using Windows.Foundation.Metadata;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Televizy10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<Channel> Channels;

        public MainPage()
        {
            this.InitializeComponent();
            //Check Device Platform
            //DetectPlatform();
            Channels = ChannelManager.GetChannels();
            

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, a) =>
            {
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                    a.Handled = true;
                }
            };
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }

        private void CloseHamburger()
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }
        

        private void ChannelGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var channel = (Channel)e.ClickedItem;
            App.ChannelPlayNowLink = channel.ChannelLink;
            App.ChannelWebLink1 = channel.ChannelWebLink1;
            App.ClickedChannelName = channel.ChannelName;
            App.ClickedChannelId = channel.ChannelId;
            Frame.Navigate(typeof(VideoPage));
        }

        private void HomePageButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CloseHamburger();
            Frame.Navigate(typeof(MainPage));
        }

        private void FavButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CloseHamburger();
            Frame.Navigate(typeof(FavChannelsPage));
        }

        private void btnSettings_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
