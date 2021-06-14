﻿using OpenQA.Selenium;
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

            p.GateIO(new ChromeDriver()); 
        }
        /// <summary>
        /// GateIO Data Collector.
        /// </summary>
        /// <param name="driver">Chrome driver.</param>
        public void GateIO(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.gate.io/trade/ETH_USDT");

            //Current Price
            string currPrice = driver.FindElement(By.Id("currPrice")).Text;
            //Daily High and Low
            string high = driver.FindElement(By.Id("tHigh")).Text;
            string low = driver.FindElement(By.Id("tLow")).Text; 
            //Daily % Change
            string currRate = driver.FindElement(By.Id("currRateNum")).Text;

            Console.WriteLine("currPrice: " + currPrice + "\nHigh and Low: " + high + " and " + low);
            Console.WriteLine("currRate: " + currRate);

            ObtainVisual(driver); 

            

            Thread.Sleep(6000);
            Quit(driver); 
        }


        public Screenshot ObtainVisual(IWebDriver driver)
        {
            //Visual: This can be a class/method of its own. Easily accessible to any website's visual I like the most. 
            string localDate = DateTime.Now.ToString("MM_dd_yyyy");
            
            IWebElement ssElement = driver.FindElement(By.Id("kline_tradingView"));
            string fileName = "C:/Users/johnnyvgoode/source/reposPersonalProjects/InvestmentTracker/Data/Visual_" + localDate + ".png";

            Console.WriteLine("\n\n\nFile Name:  " + fileName);
            Thread.Sleep(2000); 
            
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(fileName , ScreenshotImageFormat.Png);

            return ss; 
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
