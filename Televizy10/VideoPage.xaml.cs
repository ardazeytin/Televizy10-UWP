using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Televizy10.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Televizy10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VideoPage : Page
    {
        List<Channel> channels;
        List<Channel> favChannels;

        public VideoPage()
        {
            this.InitializeComponent();
            ChannelPlayer.Source = (App.ChannelPlayNowLink);
            ChannelNameHeader.Text = App.ClickedChannelName;
            channels = ChannelManager.GetChannels();
            favChannels = ChannelManager.GetFavChannels();
            

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, a) =>
            {
                App.ClickedChannelIsFav = false;
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                    a.Handled = true;
                }
            };
        }


        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
        }

        private void ChannelPlayer_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            Frame.Navigate(typeof(WebPage));
        }

        //private void btnChannelFav_Checked(object sender, RoutedEventArgs e)
        //{
        //    btnChannelFav.Content = "";
        //    channels[App.ClickedChannelId].Favorite = true;
        //    //channels[App.ClickedChannelId].ChannelName = "sdasdadsad";
            
        //    favChannels.Add(channels[App.ClickedChannelId]);


        //}

        //private void btnChannelFav_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    btnChannelFav.Content = "";
        //    channels[App.ClickedChannelId].Favorite = false;
            
        //}

        private void HomePageButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void ChannelPlayer_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.PageDown)
            {
                ChannelPlayer.Volume--;
            }

            if (e.Key == Windows.System.VirtualKey.PageUp)
            {
                ChannelPlayer.Volume++;
            }
        }

        private void Channel1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[1].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[1].ChannelName;
        }

        private void Channel2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[6].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[6].ChannelName;
        }
        private void Channel3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[4].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[4].ChannelName;
        }
        private void Channel4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[8].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[8].ChannelName;
        }
        private void Channel5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[9].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[9].ChannelName;
        }
        private void Channel6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[5].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[5].ChannelName;
        }
        private void Channel7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[19].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[19].ChannelName;
        }
        private void Channel8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[7].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[7].ChannelName;
        }
        private void Channel9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[12].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[12].ChannelName;
        }
        private void Channel10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[13].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[13].ChannelName;
        }
        private void Channel11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[11].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[11].ChannelName;
        }
        private void Channel12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ChannelPlayer.Source = channels[10].ChannelLink;
            VideoPageSplitView.IsPaneOpen = !VideoPageSplitView.IsPaneOpen;
            ChannelNameHeader.Text = channels[10].ChannelName;
        }

        
    }
}
