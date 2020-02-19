using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.RadioButton
{
    [TestClass]
    public class HandleRadioButton
    {

        [TestMethod]
        public void TestRadio()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            IWebElement element = ObjectRepository.Driver.FindElement(By.Id("u_0_7"));
            element.Click();
            Console.WriteLine("Selected : {0}", RadioButtonHelper.IsRadioButtonSelected(By.Id("u_0_6")));
            //RadioButtonHelper.ClickRadioButton(By.Id("u_0_7"));
        }
    }
}
