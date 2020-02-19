using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriver.Configuration;

namespace SeleniumWebdriver.Interfaces
{
    public interface IConfig
    {
        double GetPageLoadTimeOut { get; }

        BrowserType GetBrowser();
        string GetUsername();
        string GetPassword();
        string GetWebsite();
        int GetPageLoadTimeout();
        int GetElementLoadTimeOut();
    }
}
