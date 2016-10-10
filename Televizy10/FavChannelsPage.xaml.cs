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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Televizy10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FavChannelsPage : Page
    {
        private List<Channel> Channels;
        private List<Channel> favChannels;

        public FavChannelsPage()
        {
            this.InitializeComponent();
            favChannels = ChannelManager.GetFavChannels();
            Channels = ChannelManager.GetChannels();
        }

        private void FavChannelGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var channel = (Channel)e.ClickedItem;
            App.ChannelPlayNowLink = channel.ChannelLink;
            App.ChannelWebLink1 = channel.ChannelWebLink1;
            App.ClickedChannelName = channel.ChannelName;
            App.ClickedChannelIsFav = channel.Favorite;
            Frame.Navigate(typeof(VideoPage));
        }
    }
}
