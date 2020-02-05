using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PhantomJS
{
    [TestClass]
    public class TestPhantomJS
    {
        [TestMethod]
        public void TestPhantonyJDriver()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            GenericHelper.TakeScreenShot();
            LinkHelper.ClickLink(By.ClassName("login"));
            GenericHelper.TakeScreenShot();
            TextBoxHelper.TypeInTextBox(By.Id("email_create"), ObjectRepository.Config.GetUsername());
            GenericHelper.TakeScreenShot();
            ButtonHelper.ClickButton(By.Id("SubmitCreate"));
            GenericHelper.TakeScreenShot();
        }
    }
}
