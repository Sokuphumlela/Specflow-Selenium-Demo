using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.ScreenShot
{
    [TestClass]
    public class TakeScreenShots
    {
        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.ClassName("login"));
            TextBoxHelper.TypeInTextBox(By.Id("email_create"), ObjectRepository.Config.GetUsername());
            ButtonHelper.ClickButton(By.Id("SubmitCreate"));
            //Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            //screen.SaveAsFile("Screenshot.jpeg", ScreenshotImageFormat.Jpeg);
            GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("Test.Jpeg");
        }
    }
}
