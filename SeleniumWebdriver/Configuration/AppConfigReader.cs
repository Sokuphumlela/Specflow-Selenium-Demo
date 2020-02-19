﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.Configuration
{
    public class AppConfigReader : IConfig
    {
        public double GetPageLoadTimeOut => throw new NotImplementedException();

        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public int GetElementLoadTimeOut()
        {
            string timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementLoadTimeout);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }

        public int GetPageLoadTimeout()
        {
            string timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeout);
            if (timeout == null)
             return 30; 
            return Convert.ToInt32(timeout);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
    }
}
