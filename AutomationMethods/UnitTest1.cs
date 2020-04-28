using System;
using System.Threading;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationMethods
{
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();

        [Fact]
        public void Test1()
        {
            
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.FullScreen();
            Thread.Sleep(5000);
            driver.Quit();
       
        }

        [Fact]
        public void Test2()
        {
            
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.Manage().Window.Minimize();
            Thread.Sleep(3000);
            driver.Manage().Window.Maximize();
            
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Kaggle");
            Thread.Sleep(3000);
            driver.Quit();
            

        }

        [Fact]
        public void Test3()
        {
         
            driver.Navigate().GoToUrl("https://google.com");
            Thread.Sleep(3000);
            driver.Manage().Window.FullScreen();
            //Google search bar, name = "q"
            //driver.FindElement(By.Name("q")).SendKeys("Test Automation");
       
            // enter test automation at search bar
            driver.FindElement(By.XPath("gLFyf")).SendKeys("Test Automation");
            Thread.Sleep(4000);
            //Google search button, name = "btnK"
            driver.FindElement(By.Name("btnK")).Click();
            driver.Navigate().Back();
            //driver.FindElement(By.ClassName("gNO89b")).Click();
            Thread.Sleep(6000);
            driver.Navigate().Forward();
            driver.Quit();
        }

        [Fact]
        public void Test4()
        {
            driver.Navigate().GoToUrl("https://facebook.com");
            driver.FindElement(By.Id("email")).SendKeys("janeperez@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("pasword1234");
            driver.FindElement(By.Id("u_0_4")).Click();
            Thread.Sleep(6000);
            driver.Quit();
        }

        [Fact]
        public void Test5()
        {
            driver.Navigate().GoToUrl("https://www.baidu.com");
            driver.FindElement(By.Id("kw")).SendKeys("百度百科");
            driver.FindElement(By.Id("su")).Click();
            Thread.Sleep(3000);
            driver.Quit();

        }
       
        [Fact]
        public void Test6()
        {
            driver.Navigate().GoToUrl("https://techbroz.co.nz");
            //driver.FindElement(By.ClassName("search")).Submit();
            driver.FindElement(By.XPath("//*[@id='search']")).SendKeys("Router");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='masthead']/div[1]/div[1]/form/div/div[3]/button/i")).Submit();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [Fact]
        public void Test7()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input")).SendKeys("Automation Test");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[1]/div[3]/center/input[1]")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [Fact]
        public void NewTestMethod()
        {
            driver.Navigate().GoToUrl("https://techbroz.co.nz");
            Thread.Sleep(3000);
            driver.Quit();

        }
    }
}
