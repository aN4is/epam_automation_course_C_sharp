using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace LocatorsPractice
{
    public class PythonSearchTestSuite
    {
        IWebDriver driver;    
        
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Search_Element_ById()
        {                     
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.Id("id-search-field"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByClassName()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.ClassName("search-field"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        //by Xpath
        [Test]
        public void Search_Element_ByXpath_Class()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.XPath("//input[@class='search-field placeholder']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByXpath_Id()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.XPath("//input[@id='id-search-field']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByXpath_Name()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.XPath("//input[@name='q']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByXpath_Type()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.XPath("//input[@type='search']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByXpath_Role()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.XPath("//input[@role='textbox']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByXpath_Placeholder()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.XPath("//input[@placeholder='Search']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByXpath_Contains()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.XPath("//input[contains(@name, 'q')]"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByXpath_Count()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.XPath("//fieldset[count(input)=1]/input"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        //css selectors
        [Test]
        public void Search_Element_ByCss_Id()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.CssSelector("input#id-search-field"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByCss_Class()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.CssSelector("input.search-field"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByCss_Id2()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.CssSelector(".search-the-site input[name='q']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByCss_Id3()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.CssSelector(".search-the-site input[type='search']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByCss_Id4()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.CssSelector(".search-the-site input[role='textbox']"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }

        [Test]
        public void Search_Element_ByCss_Id5()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.CssSelector(".search-the-site input:nth-child(3)"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }


        [Test]
        public void Search_Element_ByCss_Id6()
        {
            driver.Navigate().GoToUrl("https://www.python.org/");
            IWebElement searchInput = driver.FindElement(By.CssSelector("div.container fieldset[title='Search Python.org'] > input#id-search-field"));
            searchInput.SendKeys("set");
            searchInput.SendKeys(Keys.Enter);
        }



        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
