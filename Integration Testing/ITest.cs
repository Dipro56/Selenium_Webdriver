
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace INTEGRATION_TESTING
{
    class ITest
    {
        IWebDriver driver;  //
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://corporate3.bdjobs.com/";
            Thread.Sleep(2000); 
            IWebElement element = driver.FindElement(By.Id("NAME"));  
            element.SendKeys("Sadat Shahriar");
            Thread.Sleep(1000);
            IWebElement password = driver.FindElement(By.Id("PASS"));
            password.SendKeys("lkhjg2123");
            Thread.Sleep(2000);

      
            String at = driver.Title; 

            String et = "bdjobs.com";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("//*[@id='sighIn']"));

                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}