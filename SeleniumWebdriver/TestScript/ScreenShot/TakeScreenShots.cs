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
using System.Drawing.Imaging;

namespace SeleniumWebdriver.TestScript.ScreenShot
{
    [TestClass]
    public class TakeScreenShots
    {
        public object ScreenshotImageFormat { get; private set; }

        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            screen.SaveAsFile("Screenshot.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("Test.Jpeg");
        }
    }
}
