﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver.Configuration
{
    public class XmlReader : IConfig
    {
        public double GetPageLoadTimeOut => throw new NotImplementedException();

        public BrowserType GetBrowser()
        {
            throw new NotImplementedException();
        }

        public int GetElementLoadTimeOut()
        {
            throw new NotImplementedException();
        }

        public int GetPageLoadTimeout()
        {
            throw new NotImplementedException();
        }

        public string GetPassword()
        {
            throw new NotImplementedException();
        }

        public string GetUsername()
        {
            throw new NotImplementedException();
        }

        public string GetWebsite()
        {
            throw new NotImplementedException();
        }
    }
}
