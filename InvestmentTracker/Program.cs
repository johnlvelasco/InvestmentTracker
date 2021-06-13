using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace InvestmentTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();

            //For CoinDesk data collection: 
            p.CoinDesk(new ChromeDriver()); 
        }

        public void CoinDesk(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.coindesk.com/price/ethereum");

            string price = driver.FindElement(By.ClassName("price-large")).Text; 
            string dailyChange = driver.FindElement(By.ClassName("percent-value-text")).Text; 
            string stockChart = driver.FindElement(By.ClassName("stock-chart")).Text; 

            Console.WriteLine("Price: " + price);
            Console.WriteLine("Daily Change: " + dailyChange);

            //My investments..
            //original price, date, and NET change since date.

            Thread.Sleep(5000); 
            //Quit(driver);
        }





















        private void Quit(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
            Environment.Exit(0);
        }


    }

}
