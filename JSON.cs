using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace BNS
{
    internal class JSON
    {
        /// <summary>
        /// 配置文件路径
        /// </summary>
        readonly string jsonfile = Environment.CurrentDirectory + "jl.json";
        /// <summary>
        /// 读取Json
        /// </summary>
        /// <param name="jsonfile"></param>
        /// <returns></returns>
        public JObject Readjson()
        {
            StreamReader file;
            try
            {
                file = File.OpenText(jsonfile);
            }
            catch (FileNotFoundException)
            {
                //如果发生未找到文件的异常则新建配置文件
                JObject json = new JObject
                {
                    { "date", DateTime.Now.ToLocalTime().ToString() },
                    { "language", "cn" }
                };
                JObject data = new JObject();
                //剑灵主要服务
                JObject PrimaryServiceJson = new JObject
                {
                    { "itselfName", "PrimaryService" },
                    { "textName", "PrimaryServiceTime" },
                    { "time", 100 }
                };
                data.Add("PrimaryService", PrimaryServiceJson);
                //排行榜进程
                JObject RankingDaemonJson = new JObject
                {
                    { "itselfName", "RankingDaemon" },
                    { "textName", "RankingDaemonTime" },
                    { "time", 10 }
                };
                data.Add("RankingDaemon", RankingDaemonJson);
                //账户库存进程
                JObject AccountInventoryDaemonJson = new JObject
                {
                    { "itselfName", "AccountInventoryDaemon" },
                    { "textName", "AccountInventoryDaemonTime" },
                    { "time", 10 }
                };
                data.Add("AccountInventoryDaemon", AccountInventoryDaemonJson);
                //缓存进程
                JObject CacheDaemonJson = new JObject
                {
                    { "itselfName", "CacheDaemon" },
                    { "textName", "CacheDaemonTime" },
                    { "time", 10 }
                };
                data.Add("CacheDaemon", CacheDaemonJson);
                //缓存网关
                JObject CacheGateJson = new JObject
                {
                    { "itselfName", "CacheGate" },
                    { "textName", "CacheGateTime" },
                    { "time", 10 }
                };
                data.Add("CacheGate", CacheGateJson);
                //邮件系统进程
                JObject PostOfficeDaemonJson = new JObject
                {
                    { "itselfName", "PostOfficeDaemon" },
                    { "textName", "PostOfficeDaemonTime" },
                    { "time", 10 }
                };
                data.Add("PostOfficeDaemon", PostOfficeDaemonJson);
                //角色界面进程
                JObject LobbyDaemonJson = new JObject
                {
                    { "itselfName", "LobbyDaemon" },
                    { "textName", "LobbyDaemonTime" },
                    { "time", 10 }
                };
                data.Add("LobbyDaemon", LobbyDaemonJson);
                //市场客户端进程
                JObject MarketReaderDaemonJson = new JObject
                {
                    { "itselfName", "MarketReaderDaemon" },
                    { "textName", "MarketReaderDaemonTime" },
                    { "time", 10 }
                };
                data.Add("MarketReaderDaemon", MarketReaderDaemonJson);
                //市场代理
                JObject MarketAgentReaderJson = new JObject
                {
                    { "itselfName", "MarketAgentReader" },
                    { "textName", "MarketAgentReaderTime" },
                    { "time", 10 }
                };
                data.Add("MarketAgentReader", MarketAgentReaderJson);
                //市场商人端进程
                JObject MarketDealerDaemonJson = new JObject
                {
                    { "itselfName", "MarketDealerDaemon" },
                    { "textName", "MarketDealerDaemonTime" },
                    { "time", 10 }
                };
                data.Add("MarketDealerDaemon", MarketDealerDaemonJson);
                //市场代理
                JObject MarketAgentDealerJson = new JObject
                {
                    { "itselfName", "MarketAgentDealer" },
                    { "textName", "MarketAgentDealerTime" },
                    { "time", 10 }
                };
                data.Add("MarketAgentDealer", MarketAgentDealerJson);
                //竞技场大厅
                JObject ArenaLobbyJson = new JObject
                {
                    { "itselfName", "ArenaLobby" },
                    { "textName", "ArenaLobbyTime" },
                    { "time", 10 }
                };
                data.Add("ArenaLobby", ArenaLobbyJson);
                //成就进程
                JObject AchievementDaemonJson = new JObject
                {
                    { "itselfName", "AchievementDaemon" },
                    { "textName", "AchievementDaemonTime" },
                    { "time", 10 }
                };
                data.Add("AchievementDaemon", AchievementDaemonJson);
                //决斗机器人进程
                JObject DuelBotDaemonJson = new JObject
                {
                    { "itselfName", "DuelBotDaemon" },
                    { "textName", "DuelBotDaemonTime" },
                    { "time", 10 }
                };
                data.Add("DuelBotDaemon", DuelBotDaemonJson);
                //游戏进程
                JObject GameDaemonJson = new JObject
                {
                    { "itselfName", "GameDaemon" },
                    { "textName", "GameDaemonTime" },
                    { "time", 10 }
                };
                data.Add("GameDaemon", GameDaemonJson);
                //信息网关进程
                JObject InfoGateDaemonJson = new JObject
                {
                    { "itselfName", "InfoGateDaemon" },
                    { "textName", "InfoGateDaemonTime" },
                    { "time", 10 }
                };
                data.Add("InfoGateDaemon", InfoGateDaemonJson);
                //角色网关
                JObject LobbyGateJson = new JObject
                {
                    { "itselfName", "LobbyGate" },
                    { "textName", "LobbyGateTime" },
                    { "time", 10 }
                };
                data.Add("LobbyGate", LobbyGateJson);
                //聊天频道服务器
                JObject ChannelChattingServerJson = new JObject
                {
                    { "itselfName", "ChannelChattingServer" },
                    { "textName", "ChannelChattingServerTime" },
                    { "time", 10 }
                };
                data.Add("ChannelChattingServer", ChannelChattingServerJson);
                //管理代理
                JObject ManagementAgentJson = new JObject
                {
                    { "itselfName", "ManagementAgent" },
                    { "textName", "ManagementAgentTime" },
                    { "time", 10 }
                };
                data.Add("ManagementAgent", ManagementAgentJson);
                json.Add("data", data);
                //写入配置
                Writejson(json);
                //再次读取配置
                file = File.OpenText(jsonfile);
            }
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject jObject = JObject.Parse(JToken.ReadFrom(reader).ToString());
                return jObject;
            }
        }
        /// <summary>
        /// 写入Json
        /// </summary>
        /// <param name="jsonfile"></param>
        /// <param name="jObject"></param>
        public void Writejson(JObject jObject)
        {
            using (StreamWriter file = new StreamWriter(jsonfile))
            {
                file.Write(jObject.ToString());
            }
        }
    }
}
