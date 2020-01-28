using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.WebElement 
{
    [TestClass]
    public static class TestWebElement
    {
        [TestMethod]
        public static void GetElement() 
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            try 
            {
                ReadOnlyCollection<IWebElement> col = ObjectRepository.Driver.FindElements(By.TagName("input"));
                Console.WriteLine("Size : {0}", col.Count);
                Console.WriteLine("Size : {0}", col.ElementAt(0));
                //ObjectRepository.Driver.FindElement(By.TagName("input"));
                //ObjectRepository.Driver.FindElement(By.ClassName("btn btn-default button-search"));
                //ObjectRepository.Driver.FindElement(By.CssSelector("#newsletter-input"));
                ////ObjectRepository.Driver.FindElement(By.LinkText("input"));
                ////ObjectRepository.Driver.FindElement(By.Name("email"));
                //ObjectRepository.Driver.FindElement(By.Id("//*[@id='searchbox']/button"));
                ////ObjectRepository.Driver.FindElement(By.Id("//*[@id='searchbox']/button1"));
                //IList<string> list = new List<string>();
                //list.Add("Task 1");
                //list.Add("Task 2");
                //list.Add("Task 3");
                //Console.WriteLine("Size : {0}", list.Count);
                //list.Remove("Task 2");
                //Console.WriteLine("Size : {0}", list.Count);
                //Console.WriteLine("Value : {0}",list[0]);
                //list.Clear();
                //Console.WriteLine("Size : {0}", list.Count);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
