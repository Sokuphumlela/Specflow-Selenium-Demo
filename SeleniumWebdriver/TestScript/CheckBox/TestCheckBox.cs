using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void TestBox() 
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("Forgotten account?"));
            TextBoxHelper.TypeInTextBox(By.Id("email"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("pass"), ObjectRepository.Config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Id("email"));
        }
    }
}