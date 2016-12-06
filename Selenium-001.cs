using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

//using NUnit.Framework;
namespace UnitTestProject2
{
 [TestClass]
    public class herboku
    {
   
        static void Main(string[] args)
            {

            
          
        }
       
        [TestMethod]
        public void accessto()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/disappearing_elements");

            try {
                IWebElement element = driver.FindElement(By.LinkText("Gallery"));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Can't find Gallery link");
               
            }
            // IWebElement listcheck = driver.FindElement(By.XPath ("//*[@id='content']/div/ul/li[4]/a"));

            driver.Navigate().Refresh();
            try
            {
                IWebElement element = driver.FindElement(By.LinkText("Gallery"));
                Console.WriteLine("found it at second instance");
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Can't find Gallery link");

            }

            //driver.Close();

        }
    }
}
