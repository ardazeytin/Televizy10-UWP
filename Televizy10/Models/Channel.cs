using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televizy10.Models
{
    public class Channel
    {
        public bool Favorite { get; set; }
        public int ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string ChannelImage { get; set; }
        public Uri ChannelLink { get; set; }
        public Uri ChannelLink2 { get; set; }
        public Uri ChannelWebLink1 { get; set; }
        
         
    }

    public class ChannelManager
    {

        static List<Channel> channels = new List<Channel>();
        static List<Channel> favChannels = new List<Channel>();

        public static  List<Channel> GetChannels()
        {
            //var channels = new List<Channel>();
            channels.Clear();
            //List<Channel> channels = new List<Channel>();



            //channels.Add(new Channel { ChannelId = 0, ChannelName = "", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("")), ChannelWebLink1 = (new Uri("")) });
            channels.Add(new Channel { Favorite = false, ChannelId = 0, ChannelName = "Redundant", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://212.224.80.84/S2/HLS_LIVE/kanald/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=kanal-d-canli-izle&yayin=1")) });
            channels.Add(new Channel { Favorite = false, ChannelId = 1, ChannelName = "Kanal D", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri ("http://212.224.80.84/S2/HLS_LIVE/kanald/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=kanal-d-canli-izle&yayin=1")) });
            channels.Add(new Channel { Favorite = false, ChannelId = 2, ChannelName = "KanalTürk", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri ("http://kanalturk-live.ercdn.com/kanalturk.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=kanalturk-canli-izle&yayin=1")) });
            channels.Add(new Channel { Favorite = false, ChannelId = 3, ChannelName = "CNN Türk", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://212.224.109.101/S2/HLS_LIVE/cnn_turk/index.m3u8?key=f2e092017f09e82cb5a1e85734baa6fa&live=true&app=com.cnnturk")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=cnn-turk&yayin=1")) });
            channels.Add(new Channel { Favorite = false, ChannelId = 4, ChannelName = "Show TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://mn-l.mncdn.com/showtv/smil:showtv.smil/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=show-tv-canli-izle&yayin=1")) });
            channels.Add(new Channel { Favorite = false, ChannelId = 5, ChannelName = "Fox TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://foxtv-i.mncdn.com/r_foxtv/foxtv3/chunklist_w1495990562.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=fox-tv-canli-izle&yayin=4")) });
            channels.Add(new Channel { ChannelId = 6, ChannelName = "Star TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/7acfc999bbde179fc45f18506125345f_live_0_0/index.m3u8")), ChannelWebLink1 = (new Uri("http://web.tv/embed/live/32280/1/0")) });
            channels.Add(new Channel { ChannelId = 7, ChannelName = "TRT 1", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/b5306512cde2565f1566ad35c241674c_live_0_0/index.m3u8")), ChannelWebLink1 = (new Uri("http://web.tv/embed/live/3460/1/0"))});
            channels.Add(new Channel { ChannelId = 8, ChannelName = "ATV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trkvz-m.ercdn.net/trkvz-temp/atvhdm.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=atv-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 9, ChannelName = "TV 8", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://ls.viviso.tv/i/tv8sdi_1@349694/master.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=tv8-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 10, ChannelName = "Bloomberg HT", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://mn-l.mncdn.com/bloomberght/smil:bloomberght.smil/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=bloomberg-ht&yayin=1")) });
            channels.Add(new Channel { ChannelId = 11, ChannelName = "HaberTürk", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://mn-l.mncdn.com/haberturk/smil:haberturk.smil/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=haberturk-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 12, ChannelName = "NTV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://mn-l.mncdn.com:1935/ntv_live/ntv1/playlist.m3u8?token=6704f6468ce2206d6ca091914ece090cea665ed5a7d9f274")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=ntv-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 13, ChannelName = "NTV Spor", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://mn-l.mncdn.com:1935/ntvspor_live/ntvspor1/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=ntv-spor-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 14, ChannelName = "e2", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/5dac5e87d17d40f5bca18d2b211a4dd2_live_0_0/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=e2-tv-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 15, ChannelName = "TLC", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/9044496707bcc259f6cdf58eb93cbfe9_live_0_0/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=cnbc-e&yayin=1")) });
            channels.Add(new Channel { ChannelId = 16, ChannelName = "Cine5", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://cine5.mobil.cubecdn.net/cine5/stream_1.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=cine5&yayin=1")) });
            channels.Add(new Channel { ChannelId = 17, ChannelName = "Samanyolu TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://vivisolivegrp01-lh.akamaihd.net/i/stv_1@398177/master.m3u8?hdnea=st=1450712181~exp=1450713581~acl=/*~hmac=7589b953e7cb9a36d1fb9d48aea62bd20c5f760084052aa5549625189c28c99f")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=stv-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 18, ChannelName = "Samanyolu Haber", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://vivisolivegrp01-lh.akamaihd.net/i/shabertv_1@398173/master.m3u8?hdnea=st=1450712925~exp=1450714325~acl=/*~hmac=91b4ab402f27d2e4a9735b14c848cf317466ea80b619f0408411b30590ee447b")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=stv-haber&yayin=2")) });
            channels.Add(new Channel { ChannelId = 19, ChannelName = "TRT HD", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trtcanlitv-lh.akamaihd.net/i/TRTHD_1@182045/master.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=trt-hd-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 20, ChannelName = "A Haber", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trkvz-m.ercdn.net/trkvz-temp/ahaberhdm.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=a-haber&yayin=1")) });
            channels.Add(new Channel { ChannelId = 21, ChannelName = "A Spor", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trkvz-m.ercdn.net/trkvz-temp/asporhdm.m3u8")),ChannelLink2 = (new Uri("http://origin2.live.web.tv.streamprovider.net/streams/a6784af7d08a9c91dbfa0e4eab17e3bf_live_0_0/index.m3u8")) , ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=a-spor-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 22, ChannelName = "Beyaz TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://37.77.2.236:1935/beyaz/beyaz.stream/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=beyaz-tv-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 23, ChannelName = "Bugün TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://buguntv-live.ercdn.com/buguntv.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=bugun-tv&yayin=1")) });
            channels.Add(new Channel { ChannelId = 24, ChannelName = "Halk TV", ChannelImage = "Assets/Channels/test123.png",  ChannelLink = (new Uri("http://origin2.live.web.tv.streamprovider.net/streams/4da1be863730bb975a52b3341be8f037/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=halk-tv-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 25, ChannelName = "Kanal 7", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://livetr.gostream.nl/kanal7hq/kanal7hq/radyodelisi.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=kanal-7-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 26, ChannelName = "Flash TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://184.173.181.2:1935/8158/8158/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=flash-tv-canli-izle&yayin=2")) });
            channels.Add(new Channel { ChannelId = 27, ChannelName = "TV 2", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://212.224.80.79//S2/HLS_LIVE/tv2/track_2_500/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=tv2-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 28, ChannelName = "TRT Spor", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trtcanlitv-lh.akamaihd.net/i/TRTSPOR1_1@182042/master.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=trt-spor-canli-izle&yayin=2")) });
            channels.Add(new Channel { ChannelId = 29, ChannelName = "TRT Haber", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trtcanlitv-lh.akamaihd.net/i/TRTHABERHD_1@181942/master.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=trt-haber-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 30, ChannelName = "TRT Belgesel", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trtcanlitv-lh.akamaihd.net/i/asdasdTRTHABERHD_1@181942/master.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=trt-belgesel&yayin=1")) });
            channels.Add(new Channel { ChannelId = 31, ChannelName = "TRT Türk", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trtcanlitv-lh.akamaihd.net/i/TRTTURK_1@182144/master.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=trt-turk-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 32, ChannelName = "Ülke TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://mobil.gostream.nl/ulkeiphone/smil:ulketv.smil/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=ulke-tv&yayin=1")) });
            channels.Add(new Channel { ChannelId = 33, ChannelName = "Ulusal Kanal", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://184.173.181.2:1935/8132/8132/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=ulusal-kanal&yayin=2")) });
            channels.Add(new Channel { ChannelId = 34, ChannelName = "Cartoon Network", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/e0abd0b3943ae7bbcff8e3b570ef4612_live_0_0/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=cartoon-network&yayin=1")) });
            channels.Add(new Channel { ChannelId = 35, ChannelName = "Yumurcak TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://vivisolive-lh.akamaihd.net/i/syg_yumurcak_1@382421/master.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=cartoon-network&yayin=1")) });
            channels.Add(new Channel { ChannelId = 36, ChannelName = "TRT Çocuk", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trtcanlitv-lh.akamaihd.net/i/TRTCOCUK_1@181844/index_1200_av-p.m3u8?sd=10&rebase=on")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=trt-cocuk&yayin=2")) });
            channels.Add(new Channel { ChannelId = 37, ChannelName = "Planet Çocuk", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://77.223.146.117:1935/live/planetc/chunklist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=planet-cocuk&yayin=2")) });
            channels.Add(new Channel { ChannelId = 38, ChannelName = "Disney Channel", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://live.netd.com.tr//S2/HLS_LIVE/disney/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=disney-channel-tv-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 39, ChannelName = "TV4", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://strm-i.glb.pr.medianova.tv/karamel/karamel/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=tv4-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 40, ChannelName = "Dream Türk", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://live.netd.com.tr//S1/HLS_LIVE/dreamturktv/500/prog_index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=tv4-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 41, ChannelName = "Dream Tv", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/287b096e02ad5f19c0e92d4f39c33213_live_0_0/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=tv4-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 42, ChannelName = "TV 10", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://5.135.142.60:1935/tv10/xetero/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=tv-10-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 44, ChannelName = "Kanal 24", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://mn-l.mncdn.com/kanal24/kanal243/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=kanal-24-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 45, ChannelName = "360 TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/7b1c4724e7c32f1554013ca5977fd903_live_0_0/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=kanal-24-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 46, ChannelName = "BengüTürk TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://yayin8.canliyayin.org:1935/benguturk/benguturk/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=benguturk-tv&yayin=2")) });
            channels.Add(new Channel { ChannelId = 47, ChannelName = "Kanal B", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://212.174.233.129/hls-live/livepkgr/_definst_/liveevent/mylivestream.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=kanal-b-izle&yayin=1")) });
            //channels.Add(new Channel { ChannelId = 48, ChannelName = "TJK TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://stream.farm.cdnline.com/liveedge/smil:tjkstream.smil/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=tjk-tv-canli-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 49, ChannelName = "HT 7/24", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://mn-l.mncdn.com:1935/kanal724_live/724live2/chunklist_w8125230.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=ht-7-24-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 50, ChannelName = "Sports TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://stream.sportstv.com.tr/sportstv/smil:sportstv.smil/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=sports-tv&yayin=1")) });
            //channels.Add(new Channel { ChannelId = 51, ChannelName = "Yaban TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/b5bcc039336d725a0a4aab44347e5b36_live_0_0/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=sports-tv&yayin=1")) });
            channels.Add(new Channel { ChannelId = 52, ChannelName = "TGRT Belgesel", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://origin.live.web.tv.streamprovider.net/streams/72ea283235f55344ae98853fcab1020c/index.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=animal-planet-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 53, ChannelName = "Uçankuş TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://37.77.2.236:1935/ucak/ucak.stream/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=ucankus-tv-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 54, ChannelName = "TRT Kürdi", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://sol.trtcdn.com/tv/trt6/smil:trt6.smil/playlist.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=trt-kurdi-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 55, ChannelName = "TRT Avaz", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://trtcanlitv-lh.akamaihd.net/i/TRTAVAZ_1@182244/master.m3u8")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=trt-avaz-izle&yayin=1")) });
            channels.Add(new Channel { ChannelId = 56, ChannelName = "Köy TV", ChannelImage = "Assets/Channels/test123.png", ChannelLink = (new Uri("http://37.75.10.20/koytv/koytv/tvizlehd.m3u8?ext=.mp4")), ChannelWebLink1 = (new Uri("http://www.ehdcanlitvizle.com/kanallar.php?kanal=koy-tv-izle&yayin=1")) });

            
            
                
                
            

            return channels;
        }

        public static List<Channel> GetFavChannels()
        {
            //favChannels.Clear();
            foreach (Channel item in channels)
            {
                if (item.Favorite == true)
                {
                    favChannels.Add(item);
                }
            }
            return favChannels;
        }
    }
}
