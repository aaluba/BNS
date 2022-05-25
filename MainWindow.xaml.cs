using Newtonsoft.Json.Linq;
using System;
using System.Windows;
using System.Windows.Controls;

namespace BNS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        JSON jl = new JSON();
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BNSWindows_Loaded(object sender, RoutedEventArgs e)
        {
            //读取时间配置
            try
            {
                //主要服务时间
                PrimaryServiceTime.Text = jl.Readjson()["data"]["PrimaryService"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                PrimaryServiceTime.Text = "0";
            }
            try
            {
                //排行榜进程
                RankingDaemonTime.Text = jl.Readjson()["data"]["PrimaryService"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                RankingDaemonTime.Text = "0";
            }
            try
            {
                //账户库存进程
                AccountInventoryDaemonTime.Text = jl.Readjson()["data"]["AccountInventoryDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                AccountInventoryDaemonTime.Text = "0";
            }
            try
            {
                //缓存进程
                CacheDaemonTime.Text = jl.Readjson()["data"]["CacheDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                CacheDaemonTime.Text = "0";
            }
            try
            {
                //缓存网关
                CacheGateTime.Text = jl.Readjson()["data"]["CacheGate"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                CacheGateTime.Text = "0";
            }
            try
            {
                //邮件系统进程
                PostOfficeDaemonTime.Text = jl.Readjson()["data"]["PostOfficeDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                PostOfficeDaemonTime.Text = "0";
            }
            try
            {
                //角色界面进程
                LobbyDaemonTime.Text = jl.Readjson()["data"]["LobbyDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                LobbyDaemonTime.Text = "0";
            }
            try
            {
                //市场客户端进程
                MarketReaderDaemonTime.Text = jl.Readjson()["data"]["MarketReaderDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                MarketReaderDaemonTime.Text = "0";
            }
            try
            {
                //市场代理
                MarketAgentReaderTime.Text = jl.Readjson()["data"]["MarketAgentReader"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                MarketAgentReaderTime.Text = "0";
            }
            try
            {
                //市场商人端进程
                MarketDealerDaemonTime.Text = jl.Readjson()["data"]["MarketDealerDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                MarketDealerDaemonTime.Text = "0";
            }
            try
            {
                //市场代理
                MarketAgentDealerTime.Text = jl.Readjson()["data"]["MarketAgentDealer"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                MarketAgentDealerTime.Text = "0";
            }
            try
            {
                //竞技场大厅
                ArenaLobbyTime.Text = jl.Readjson()["data"]["ArenaLobby"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                ArenaLobbyTime.Text = "0";
            }
            try
            {
                //成就进程
                AchievementDaemonTime.Text = jl.Readjson()["data"]["AchievementDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                AchievementDaemonTime.Text = "0";
            }
            try
            {
                //决斗机器人进程
                DuelBotDaemonTime.Text = jl.Readjson()["data"]["DuelBotDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                DuelBotDaemonTime.Text = "0";
            }
            try
            {
                //游戏进程
                GameDaemonTime.Text = jl.Readjson()["data"]["GameDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                GameDaemonTime.Text = "0";
            }
            try
            {
                //信息网关进程
                InfoGateDaemonTime.Text = jl.Readjson()["data"]["InfoGateDaemon"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                InfoGateDaemonTime.Text = "0";
            }
            try
            {
                //角色网关
                LobbyGateTime.Text = jl.Readjson()["data"]["LobbyGate"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                LobbyGateTime.Text = "0";
            }
            try
            {
                //聊天频道服务器
                ChannelChattingServerTime.Text = jl.Readjson()["data"]["ChannelChattingServer"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                ChannelChattingServerTime.Text = "0";
            }
            try
            {
                //管理代理
                ManagementAgentTime.Text = jl.Readjson()["data"]["ManagementAgent"]["time"].ToString();
            }
            catch (NullReferenceException)
            {
                ManagementAgentTime.Text = "0";
            }
        }

        /// <summary>
        /// 切换为英文
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Language_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 关闭SpawnSrv服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// 主进程服务修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrimaryServiceTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["PrimaryService"]["time"] = PrimaryServiceTime.Text;
            jl.Writejson(jObject);
        }
        /// <summary>
        /// 排行榜进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RankingDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["RankingDaemon"]["time"] = RankingDaemonTime.Text;
            jl.Writejson(jObject);
        }
        /// <summary>
        /// 账户库存进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountInventoryDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["AccountInventoryDaemon"]["time"] = AccountInventoryDaemonTime.Text;
            jl.Writejson(jObject);
        }
        /// <summary>
        /// 缓存进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CacheDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["CacheDaemon"]["time"] = CacheDaemonTime.Text;
            jl.Writejson(jObject);
        }
        /// <summary>
        /// 缓存网关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CacheGateTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["CacheGate"]["time"] = CacheGateTime.Text;
            jl.Writejson(jObject);
        }
        /// <summary>
        /// 邮件进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PostOfficeDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["PostOfficeDaemon"]["time"] = PostOfficeDaemonTime.Text;
            jl.Writejson(jObject);
        }

        private void LobbyDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["LobbyDaemon"]["time"] = LobbyDaemonTime.Text;
            jl.Writejson(jObject);
        }

        private void MarketReaderDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["MarketReaderDaemon"]["time"] = MarketReaderDaemonTime.Text;
            jl.Writejson(jObject);
        }

        private void MarketAgentReaderTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["MarketAgentReader"]["time"] = MarketAgentReaderTime.Text;
            jl.Writejson(jObject);
        }

        private void MarketDealerDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["MarketDealerDaemon"]["time"] = MarketDealerDaemonTime.Text;
            jl.Writejson(jObject);
        }

        private void MarketAgentDealerTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["MarketAgentDealer"]["time"] = MarketAgentDealerTime.Text;
            jl.Writejson(jObject);
        }

        private void ArenaLobbyTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["ArenaLobby"]["time"] = ArenaLobbyTime.Text;
            jl.Writejson(jObject);
        }

        private void AchievementDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["AchievementDaemon"]["time"] = AchievementDaemonTime.Text;
            jl.Writejson(jObject);
        }

        private void DuelBotDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["DuelBotDaemon"]["time"] = DuelBotDaemonTime.Text;
            jl.Writejson(jObject);
        }

        private void GameDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            JObject jObject = JObject.Parse(jl.Readjson().ToString());
            jObject["data"]["GameDaemon"]["time"] = GameDaemonTime.Text;
            jl.Writejson(jObject);
        }

        private void InfoGateDaemonTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            //JObject jObject = JObject.Parse(jl.Readjson().ToString());
            //jObject["data"]["InfoGateDaemon"]["time"] = InfoGateDaemonTime.Text;
            //jl.Writejson(jObject);
        }

        private void LobbyGateTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            //JObject jObject = JObject.Parse(jl.Readjson().ToString());
            //jObject["data"]["LobbyGate"]["time"] = LobbyGateTime.Text;
            //jl.Writejson(jObject);
        }

        private void ChannelChattingServerTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            //JObject jObject = JObject.Parse(jl.Readjson().ToString());
            //jObject["data"]["ChannelChattingServer"]["time"] = ChannelChattingServerTime.Text;
            //jl.Writejson(jObject);
        }

        private void ManagementAgentTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            //JObject jObject = JObject.Parse(jl.Readjson().ToString());
            //jObject["data"]["ManagementAgent"]["time"] = ManagementAgentTime.Text;
            //jl.Writejson(jObject);
        }
    }
}
