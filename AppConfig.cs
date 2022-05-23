using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BNS
{
    internal class AppConfig
    {
        /// <summary>
        /// 根据key获取对应的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetAppSettingValueByKey(string key, string type)
        {
            //获取对应的值
            string value = ConfigurationManager.AppSettings[key].ToString();
            if (string.IsNullOrEmpty(value) || value == "")
            {
                if (type == "string")
                {
                    value = null;
                }
                if (type == "int")
                {
                    value = "0";
                }
                return value;
            }
            return value;
        }

        /// <summary>
        /// 更新Key或者Value
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetAppSettingKeyOrValue(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //判断是否已存在key，如果有则删除
            if (ConfigurationManager.AppSettings[key] != null)
            {
                configuration.AppSettings.Settings[key].Value=value;
            }
            //添加key和value
            configuration.AppSettings.Settings.Add(key, value);
            //保存
            configuration.Save(ConfigurationSaveMode.Modified);
            //强制刷新
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
