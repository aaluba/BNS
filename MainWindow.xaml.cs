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
        readonly AppConfig appConfig = new AppConfig();
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BNSWindows_Loaded(object sender, RoutedEventArgs e)
        {
            //读取时间配置

            //主要服务时间
            PrimaryServiceTime.Text = appConfig.GetAppSettingValueByKey("PrimaryServiceTime", "int");
            //排行榜进程
            RankingDaemonTime.Text = appConfig.GetAppSettingValueByKey("RankingDaemonTime", "int");
            //账户库存进程
            AccountInventoryDaemonTime.Text = appConfig.GetAppSettingValueByKey("AccountInventoryDaemonTime", "int");
            //缓存进程
            CacheDaemonTime.Text = appConfig.GetAppSettingValueByKey("CacheDaemonTime", "int");
            //缓存网关
            CacheGateTime.Text = appConfig.GetAppSettingValueByKey("CacheGateTime", "int");
            //邮件系统进程
            PostOfficeDaemonTime.Text = appConfig.GetAppSettingValueByKey("PostOfficeDaemonTime", "int");
            //角色界面进程
            LobbyDaemonTime.Text = appConfig.GetAppSettingValueByKey("LobbyDaemonTime", "int");
            //市场客户端进程
            MarketReaderDaemonTime.Text = appConfig.GetAppSettingValueByKey("MarketReaderDaemonTime", "int");
            //市场代理
            MarketAgentReaderTime.Text = appConfig.GetAppSettingValueByKey("MarketAgentReaderTime", "int");
            //市场商人端进程
            MarketDealerDaemonTime.Text = appConfig.GetAppSettingValueByKey("MarketDealerDaemonTime", "int");
            //市场代理
            MarketAgentDealerTime.Text = appConfig.GetAppSettingValueByKey("MarketAgentDealerTime", "int");
            //竞技场大厅
            ArenaLobbyTime.Text = appConfig.GetAppSettingValueByKey("ArenaLobbyTime", "int");
            //成就进程
            AchievementDaemonTime.Text = appConfig.GetAppSettingValueByKey("AchievementDaemonTime", "int");
            //决斗机器人进程
            DuelBotDaemonTime.Text = appConfig.GetAppSettingValueByKey("DuelBotDaemonTime", "int");
            //游戏进程
            GameDaemonTime.Text = appConfig.GetAppSettingValueByKey("GameDaemonTime", "int");
            //信息网关进程
            InfoGateDaemonTime.Text = appConfig.GetAppSettingValueByKey("InfoGateDaemonTime", "int");
            //角色网关
            LobbyGateTime.Text = appConfig.GetAppSettingValueByKey("LobbyGateTime", "int");
            //聊天频道服务器
            ChannelChattingServerTime.Text = appConfig.GetAppSettingValueByKey("ChannelChattingServerTime", "int");
            //管理代理
            ManagementAgentTime.Text = appConfig.GetAppSettingValueByKey("ManagementAgentTime", "int");
        }

        /// <summary>
        /// 切换为英文
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LanguageCN_Click(object sender, RoutedEventArgs e)
        {
            string jls =jl.Readjson().ToString();
            Console.WriteLine(jls);
            MessageBox.Show(jls);
        }
        private void LanguageEN_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 启动SpawnSrv服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StratBtn_Click(object sender, RoutedEventArgs e)
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
        //服务及进程启动时间设置
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //主要服务时间
                appConfig.SetAppSettingKeyOrValue("PrimaryServiceTime", PrimaryServiceTime.Text);
                //排行榜进程
                appConfig.SetAppSettingKeyOrValue("RankingDaemonTime", RankingDaemonTime.Text);
                //账户库存进程
                appConfig.SetAppSettingKeyOrValue("AccountInventoryDaemonTime", AccountInventoryDaemonTime.Text);
                //缓存进程
                appConfig.SetAppSettingKeyOrValue("CacheDaemonTime", CacheDaemonTime.Text);
                //缓存网关
                appConfig.SetAppSettingKeyOrValue("CacheGateTime", CacheGateTime.Text);
                //邮件系统进程
                appConfig.SetAppSettingKeyOrValue("PostOfficeDaemonTime", PostOfficeDaemonTime.Text);
                //角色界面进程
                appConfig.SetAppSettingKeyOrValue("LobbyDaemonTime", LobbyDaemonTime.Text);
                //市场客户端进程
                appConfig.SetAppSettingKeyOrValue("MarketReaderDaemonTime", MarketReaderDaemonTime.Text);
                //市场代理
                appConfig.SetAppSettingKeyOrValue("MarketAgentReaderTime", MarketAgentReaderTime.Text);
                //市场商人端进程
                appConfig.SetAppSettingKeyOrValue("MarketDealerDaemonTime", MarketDealerDaemonTime.Text);
                //市场代理
                appConfig.SetAppSettingKeyOrValue("MarketAgentDealerTime", MarketAgentDealerTime.Text);
                //竞技场大厅
                appConfig.SetAppSettingKeyOrValue("ArenaLobbyTime", ArenaLobbyTime.Text);
                //成就进程
                appConfig.SetAppSettingKeyOrValue("AchievementDaemonTime", AchievementDaemonTime.Text);
                //决斗机器人进程
                appConfig.SetAppSettingKeyOrValue("DuelBotDaemonTime", DuelBotDaemonTime.Text);
                //游戏进程
                appConfig.SetAppSettingKeyOrValue("GameDaemonTime", GameDaemonTime.Text);
                //信息网关进程
                appConfig.SetAppSettingKeyOrValue("InfoGateDaemonTime", InfoGateDaemonTime.Text);
                //角色网关
                appConfig.SetAppSettingKeyOrValue("LobbyGateTime", LobbyGateTime.Text);
                //聊天频道服务器
                appConfig.SetAppSettingKeyOrValue("ChannelChattingServerTime", ChannelChattingServerTime.Text);
                //管理代理
                appConfig.SetAppSettingKeyOrValue("ManagementAgentTime", ManagementAgentTime.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("保存成功！");
        }
    }
    //各项进程
    //排行榜进程
    //private string RankingDaemon = "D:\\Server\\RankingDaemon\\bin\\RankingDaemon.exe";
    //账户库存进程
    //private string AccountInventoryDaemon = "D:\\Server\\AccountInventoryDaemon\\bin\\AccountInventoryDaemon.exe";
    //缓存进程
    //private string CacheDaemon = "D:\\Server\\CacheDaemon\\bin\\CacheDaemon.exe";
    //缓存网关
    //private string CacheGate = "D:\\Server\\CacheGate\\bin\\CacheGate.exe";
    //邮件系统进程
    //private string PostOfficeDaemon = "D:\\Server\\PostOfficeDaemon\\bin\\PostOfficeDaemon.exe";
    //角色界面进程
    //private string LobbyDaemon = "D:\\Server\\LobbyDaemon\\bin\\LobbyDaemon.exe";
    //市场客户端进程
    //private string MarketReaderDaemon = "D:\\Server\\MarketReaderDaemon\\bin\\MarketReaderDaemon.exe";
    //市场代理
    //private string MarketAgent = "D:\\Server\\MarketReaderAgent\\bin\\MarketAgent.exe";
    //市场商人端进程
    //private string MarketDealerDaemon = "D:\\Server\\MarketDealerDaemon\\bin\\MarketDealerDaemon.exe";
    //竞技场大厅
    //private string ArenaLobby = "D:\\Server\\ArenaLobby\\bin\\ArenaLobby.exe";
    //成就进程
    //private string AchievementDaemon = "D:\\Server\\AchievementDaemon\\bin\\AchievementDaemon.exe";
    //决斗机器人进程
    //private string DuelBotDaemon = "D:\\Server\\DuelbotDaemon\\bin\\DuelBotDaemon.exe";
    //游戏进程
    //private string GameDaemon = "D:\\Server\\GameDaemon\\bin\\GameDaemon.exe";
    //信息网关进程
    //private string InfoGateDaemon = "D:\\Server\\InfoGateDaemon\\bin\\InfoGateDaemon.exe";
    //角色网关
    //private string LobbyGate = "D:\\Server\\LobbyGate\\bin\\LobbyGate.exe";
    //聊天频道服务器
    //private string ChannelChattingServer = "D:\\Server\\ChannelChattingServer\\bin\\ChannelChattingServer.exe";
    //管理代理
    //private string ManagementAgent = "D:\\Server\\ManagementAgent\\bin\\ManagementAgent.exe";

}
