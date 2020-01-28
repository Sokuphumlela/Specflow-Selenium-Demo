using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink()
        {
            //NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement pelement = ObjectRepository.Driver.FindElement(By.LinkText("lost_password form-group"));
            //pelement.Click();
            LinkHelper.ClickLink(By.LinkText("lost_password form-group"));
            //LinkHelper.ClickLink(By.PartialLinkText("File"));
        }
    }
}
