using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText(""));
            IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("customer_firstname"));
            ele.SendKeys(ObjectRepository.Config.GetUsername());
            ele = ObjectRepository.Driver.FindElement(By.Id("passwd"));
            ele.SendKeys(ObjectRepository.Config.GetPassword());
            ele = ObjectRepository.Driver.FindElement(By.Id("customer_firstname"));
            ele.Clear();
        }

    }
}
