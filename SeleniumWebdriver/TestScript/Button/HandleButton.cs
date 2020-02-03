using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.Button
{
    [TestClass]
    public static class HandleButton
    {
        [TestMethod]
        public static void TestButton() 
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.LinkText("lost_password form-group"));
            TextBoxHelper.TypeInTextBox(By.Id("email"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("passwd"), ObjectRepository.Config.GetPassword());
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("SubmitLogin"));
            //element.Click();
            Console.WriteLine("Enabled : {0}", ButtonHelper.IsButtonEnable(By.Id("SubmitLogin")));
            Console.WriteLine("Button Text : {0}", ButtonHelper.GetButtonText(By.Id("SubmitLogin")));
            ButtonHelper.ClickButton(By.Id("SubmitLogin"));
        }
    }
}
