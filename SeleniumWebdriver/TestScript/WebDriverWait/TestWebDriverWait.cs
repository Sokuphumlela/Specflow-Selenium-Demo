using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.WebDriverWait
{
    [TestClass]
    public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            //ObjectRepository.Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));
            NavigationHelper.NavigateToUrl("http://automationpractice.com/index.php");
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50));
            TextBoxHelper.TypeInTextBox(By.XPath("//*[@id='search_query_top']"),"C#");
        }
        //[TestMethod]
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0017:Simplify object initialization", Justification = "<Pending>")]
        //public void TestDynamicWait()
        //{
        //    NavigationHelper.NavigateToUrl("http://automationpractice.com");
        //    ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));
        //    WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(50));
        //    wait.PollingInterval = TimeSpan.FromMilliseconds(250);
        //    wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
        //    //Console.WriteLine(wait.Until(waitforTitle()));
        //    wait.Until(waitforElement()).SendKeys("good");
        //    //wait.Until(waitforLastElement()).Click();
        //    //Console.WriteLine("Title {0}", wait.Until(waitforpageTitle()));
        //}

        //private Func<IWebDriver, bool> waitforSearchbox() 
        //{
        //    return ((x) =>
        //    {
        //        Console.WriteLine("Waiting for search box: ");
        //        return x.FindElements(By.XPath("//*[@id='search_query_top']")).Count == 1;
        //    });
        //}

        //private Func<IWebDriver, string> waitforTitle()
        //{
        //    return ((x) =>
        //    {
        //        if (x.Title.Contains("Main"))
        //            return x.Title;
        //        return null;
        //    });
        //}

        //private Func<IWebDriver, IWebElement> waitforElement()
        //{
        //    return ((x) =>
        //    {
        //        Console.WriteLine("Waiting for search text box");
        //        if (x.FindElements(By.XPath("//*[@id='search_query_top']")).Count == 1)
        //            return x.FindElement(By.XPath("//*[@id='search_query_top']"));
        //        return null;
        //    });
        //}

        //This is a function for the last element that will be found on a engine search
        //private Func<IWebDriver, IWebElement> waitforLastElement()
        //{
        //    return ((x) =>
        //    {
        //        Console.WriteLine("Waiting for Last Element: ");
        //        if (x.FindElements(By.XPath("We still need to feel in the website")).Count == 1)
        //            return x.FindElement(By.XPath("We still need to feel in the website"));
        //        return null;
        //    });
        //}

        //This is a function for the last element that will be found on a engine search
        //private Func<IWebDriver, IWebElement> waitforPageTitle()
        //{
        //    return ((x) =>
        //    {
        //        Console.WriteLine("Waiting for Element: ");
        //        if (x.FindElements(By.CssSelector("We still need to feel in the website")).Text.Contains("Web title when its testing is going to be here"))
        //            return x.FindElements(By.CssSelector("We still need to feel in the website")).Text;
        //        return null;
        //    });
        //}


    }
}
