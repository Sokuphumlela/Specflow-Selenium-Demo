using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.DefaultWait
{
    [TestClass]
    public class HandleDefaultWait
    {
        [TestMethod]
        public void TestDefaultWait()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(1));

            GenericHelper.WaitForWebElement(By.Id("bug_severity"), TimeSpan.FromSeconds(50));
            IWebElement ele = GenericHelper.WaitForWebElementPage(By.Id)

            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(ObjectRepository.Driver.FindElement(By.Id("month")));
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            Console.WriteLine(wait.Until(changeofvalue()));
        }

        private Func<IWebDriver, string> changeofvalue()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for value change");
                SelectElement select = new SelectElement(x);
                if (select.SelectedOption.Text.Equals("Mar"))
                    return select.SelectedOption.Text;
                return null;
            });
        }

    }
}
