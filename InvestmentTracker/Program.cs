using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI; 
using System;
using System.Drawing; 
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace InvestmentTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            IWebDriver driver = new ChromeDriver(); 

            p.GateIO(driver);
            p.Quit(driver);
        }

        /// <summary>
        /// GateIO Data Collector.
        /// </summary>
        /// <param name="driver">Chrome driver.</param>
        public void GateIO(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://www.gate.io/trade/ETH_USDT");
            Thread.Sleep(2000);
            //driver.Manage().Window.Size = new Size(1, 1); 

            Display d = new Display();
            //Test 1: Repeat Collection every 5 seconds, for 5 times. 
            int displays = 1; 
            while (displays < 5)
            {
                string price = driver.FindElement(By.Id("currPrice")).Text;
                string high = driver.FindElement(By.Id("tHigh")).Text;
                string low = driver.FindElement(By.Id("tLow")).Text; 
                string rate = driver.FindElement(By.Id("currRateNum")).Text;
                d.SetValues(price, rate, high, low);

                Application.EnableVisualStyles();
                Application.Run(d);
            }
            //ObtainVisual(driver); 
            Thread.Sleep(3000);
        }


        /// <summary>
        /// Logs user into their profile, collecting their data, (then logging out and deleting data) - maybe don't do this, only worried about personal privacy.
        /// </summary>
        /// <param name="driver">Chrome Driver</param>
        public void DataCollection_Gemini(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://exchange.gemini.com/signin");

            //get log in information from a UI method. Later on, ENCRYPT the password. Make many different encryptions.
            string[] signIn = SignInInfo(); 
            string username = signIn[0];
            string password = signIn[1];
            //Console.WriteLine(username + "\n" + password); 

            IWebElement usernameEntry = driver.SwitchTo().ActiveElement();
            usernameEntry.SendKeys(username);
            usernameEntry.SendKeys(Keys.Tab);

            IWebElement passwordEntry = driver.SwitchTo().ActiveElement();
            passwordEntry.SendKeys(password);
            passwordEntry.SendKeys(Keys.Enter);

            //PROBLEM
            //Authenticator limits my ability to access profile information.

            Thread.Sleep(3000);
            Quit(driver);
        }





        /// <summary>
        /// Obtains screenshots of the visual on certain websites. Maybe add a param with the website used name. 
        /// </summary>
        /// <param name="driver">Chrome Driver.</param>
        /// <returns>A screenshot of the graph.</returns>
        public Screenshot ObtainVisual(IWebDriver driver)
        {
            //Visual: This can be a class/method of its own. Easily accessible to any website's visual I like the most. 
            string localDate = DateTime.Now.ToString("MM_dd_yyyy");
            
            IWebElement ssElement = driver.FindElement(By.Id("kline_tradingView"));
            string fileName = "C:/Users/johnnyvgoode/source/reposPersonalProjects/InvestmentTracker1/Data/Visual_" + localDate + ".png";

            Console.WriteLine("\n\n\nFile Name:  " + fileName);
            Thread.Sleep(2000); 
            
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(fileName , ScreenshotImageFormat.Png);

            return ss; 
        }

        /// <summary>
        /// For gathering username and password information. 
        /// </summary>
        public string[] SignInInfo()
        {
            UserInterface signIn = new UserInterface();
            Application.EnableVisualStyles();
            Application.Run(signIn);

            return new string[2] { signIn.Username, signIn.Password };
        }


        /// <summary>
        /// Closes the webpage and command console.
        /// </summary>
        /// <param name="driver">Chrome Driver.</param>
        private void Quit(IWebDriver driver)
        {
            driver.Close();
            driver.Quit();
            Environment.Exit(0);
        }


    }

}
