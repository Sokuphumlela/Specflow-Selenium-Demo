using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.HandleDropDown
{
    [TestClass]
    public class DropDownList
    {
        [TestMethod]
        public void TestList()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("month"));
            //SelectElement select = new SelectElement(element);
            //select.SelectByIndex(3);
            //select.SelectByValue("3");
            //select.SelectByText("Mar");
            //Console.WriteLine("Selected value : {0}", select.SelectedOption.Text);
            //IList<IWebElement> list = select.Options;
            //foreach(IWebElement ele in list)
            //{
            //    Console.WriteLine("Value : {0}, Text : {1}",ele.GetAttribute("value"),ele.Text);
            //}
            ComboBoxHelper.SelectElement(By.Id("month"), 2);
            ComboBoxHelper.SelectElement(By.Id("month"), "Mar");
            foreach (string str in ComboBoxHelper.GetAllItem(By.Id("month")))
            {
                Console.WriteLine("Text : {0}", str);
            }
        }
    }
}
