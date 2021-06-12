using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl();

        }
    }
}
