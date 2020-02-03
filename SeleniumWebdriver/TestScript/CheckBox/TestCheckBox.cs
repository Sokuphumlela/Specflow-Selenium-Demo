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
            TextBoxHelper.TypeInTextBox(By.Id("email"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("passwd"), ObjectRepository.Config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Id("email"));
              //Check box element
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("id_gender2"));
            //ele.Click();
            //Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("id_gender2")));
            //CheckBoxHelper.CheckedCheckBox(By.Id("id_gender2"));
            //Console.WriteLine(CheckBoxHelper.IsCheckBoxChecked(By.Id("id_gender2")));
        }
    }
}
