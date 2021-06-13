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
            //ISSUE Some data is uncollectable, hidden behind duplicate class names.
            //p.CoinDesk(new ChromeDriver());
            p.TradingView(new ChromeDriver()); 


        }

        /// <summary>
        /// TradingView Data Collector.
        /// </summary>
        /// <param name="driver">Chrome driver.</param>
        public void TradingView(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://tradingview.com/symbols/ETHUSDT");

            //Current Price
            string currPrice = driver.FindElement(By.ClassName("tabValue-HYHP1WHx")).Text;
            Console.WriteLine("Current Price: " + currPrice);
            //Daily High and Low
            string dailyLow = driver.FindElement(By.ClassName("js-symbol-header__range-price-l")).GetAttribute("js-symbol-header__range-price=1").ToString();
            string dailyHigh = driver.FindElement(By.ClassName("js-symbol-header__range-price-r")).Text;
            Console.WriteLine("Daily Low Price: " + dailyLow);
            Console.WriteLine("Daily High Price: " + dailyHigh);

            //Daily % Change

            //Visual

            Thread.Sleep(3000);
            Quit(driver);            
        }

        /// <summary>
        /// CoinDesk Data Collector.
        /// </summary>
        /// <param name="driver">Chrome driver.</param>
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

        /// <summary>
        /// Closes the webpage and command console.
        /// </summary>
        /// <param name="driver"></param>
        private void Quit(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
            Environment.Exit(0);
        }


    }

}
