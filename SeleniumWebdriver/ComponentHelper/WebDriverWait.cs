using System;
using OpenQA.Selenium;

namespace SeleniumWebdriver.ComponentHelper
{
    internal class WebDriverWait
    {
        private IWebDriver driver;
        private TimeSpan timeout;

        public WebDriverWait(IWebDriver driver, TimeSpan timeout)
        {
            this.driver = driver;
            this.timeout = timeout;
        }

        public TimeSpan PollingInterval { get; set; }

        internal void IgnoreExceptionTypes(Type type1, Type type2)
        {
            throw new NotImplementedException();
        }

        internal bool Until(Func<IWebDriver, bool> func)
        {
            throw new NotImplementedException();
        }

        internal IWebElement Until(Func<IWebDriver, IWebElement> func)
        {
            throw new NotImplementedException();
        }
    }
}