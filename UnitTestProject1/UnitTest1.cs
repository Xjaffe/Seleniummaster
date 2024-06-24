using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        ChromeOptions options = new ChromeOptions();
       
           



        [TestMethod]
        public void ValidateBestBuy()
        {
            IWebDriver driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");
            driver.Url = "https://www.thecrazycoupons.com/us/";
            driver.FindElement(By.XPath("//li[1]//div[1]//div[1]//a[1]//img[1]")).Click();
            Thread.Sleep(5000);
            driver.Quit();

        }

        [TestMethod]
        public void ValidateCadburry()
        {
            IWebDriver driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");
            driver.Url = "https://www.thecrazycoupons.com/us/";
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/main[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/ul[1]/li[2]/div[1]/div[1]/a[1]/img[1]")).Click();
            Thread.Sleep(5000);
            driver.Quit();

        }
    }
}