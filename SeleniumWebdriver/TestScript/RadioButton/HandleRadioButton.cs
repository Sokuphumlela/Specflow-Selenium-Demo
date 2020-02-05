﻿using System;
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
            LinkHelper.ClickLink(By.ClassName("login"));
            TextBoxHelper.TypeInTextBox(By.Id("email_create"), ObjectRepository.Config.GetUsername());
            ButtonHelper.ClickButton(By.Id("SubmitCreate"));
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("id_gender1"));
            //element.Click();
            Console.WriteLine("Selected : {0}", RadioButtonHelper.IsRadioButtonSelected(By.Id("id_gender1")));
            RadioButtonHelper.ClickRadioButton(By.Id("id_gender2"));
        }
    }
}
