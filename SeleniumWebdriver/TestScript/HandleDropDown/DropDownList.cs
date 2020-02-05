﻿using System;
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
            LinkHelper.ClickLink(By.ClassName("login"));
            TextBoxHelper.TypeInTextBox(By.Id("email_create"), ObjectRepository.Config.GetUsername());
            ButtonHelper.ClickButton(By.Id("SubmitCreate"));
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("id_state"));
            //SelectElement select = new SelectElement(element);
            //select.SelectByIndex(2);
            //select.SelectByValue("4");
            //select.SelectByText("California");
            //Console.WriteLine("Selected value : {0}", select.SelectedOption.Text);
            //IList<IWebElement> list = select.Options;
            //foreach (IWebElement ele in list)
            //{
            //    Console.WriteLine("Value : {0}, Text : {1}", ele.GetAttribute("Value"),ele.Text);
            //}
            ComboBoxHelper.SelectElement(By.Id("id_state"),2);
            ComboBoxHelper.SelectElement(By.Id("id_state"), "California");
            foreach (string str in ComboBoxHelper.GetAllItem(By.Id("id_state"))) 
            {
                Console.WriteLine("Text : {0}",str);
            }
        }
    }
}
