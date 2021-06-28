using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Keys = OpenQA.Selenium.Keys;

namespace InvestmentTracker
{
    public partial class Display : Form
    {
        /// <summary>
        /// Google Chrome WebDriver.
        /// </summary>
        public IWebDriver Driver { get; set; }

        /// <summary>
        /// Timer interval for data collection updates.
        /// </summary>
        private int _interval = 2000; 

        /// <summary>
        /// Displays the defautlt price changes and the visual.
        /// </summary>
        /// <param name="driver">WebDriver that runs the bot.</param>
        public Display(IWebDriver driver)
        {
            InitializeComponent();
            driver.Navigate().GoToUrl("https://www.gate.io/trade/ETH_USDT");

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = _interval;
            timer.Tick += new System.EventHandler(timer_Tick);
            timer.Start();

            Screenshot screenshot = ObtainVisual();
        }

        /// <summary>
        /// Reset the collected values at each timer tick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            uxPrice.Text = Driver.FindElement(By.Id("currPrice")).Text;
            uxRate.Text = Driver.FindElement(By.Id("currRateNum")).Text + "%";
            uxHigh.Text = Driver.FindElement(By.Id("tHigh")).Text;
            uxLow.Text = Driver.FindElement(By.Id("tLow")).Text;
        }

        /// <summary>
        /// Obtains screenshots of the visual on certain websites. Maybe add a param with the website used name. 
        /// </summary>
        /// <param name="Driver">Chrome Driver.</param>
        /// <returns>A screenshot of the graph.</returns>
        public Screenshot ObtainVisual()
        {
            IWebDriver visualDriver = new ChromeDriver();

            visualDriver.Navigate().GoToUrl("https://www.tradingview.com/chart/?symbol=BITSTAMP%3AETHUSD");
            Size graph = visualDriver.FindElement(By.ClassName("chart-gui-wrapper")).Size;
            Size priceAxis = visualDriver.FindElement(By.ClassName("price-axis")).Size;
            Screenshot screenshot = ((ITakesScreenshot)visualDriver).GetScreenshot();

            Size visual = new Size(graph.Width + priceAxis.Width, priceAxis.Height);




            string localDate = DateTime.Now.ToString("MM_dd_yyyy");
            string fileName = "C:/Users/johnnyvgoode/Desktop/Personal Projects/Visual_" + localDate + ".png";

            Screenshot ss = ((ITakesScreenshot)visualDriver).GetScreenshot();
            
            ss.SaveAsFile(fileName, ScreenshotImageFormat.Png);

            /*
            //Visual: This can be a class/method of its own. Easily accessible to any website's visual I like the most. 
            string localDate = DateTime.Now.ToString("MM_dd_yyyy");

            IWebElement ssElement = Driver.FindElement(By.Id("kline_tradingView"));
            string fileName = "C:/Users/johnnyvgoode/source/reposPersonalProjects/InvestmentTracker1/Data/Visual_" + localDate + ".png";

            Console.WriteLine("\n\n\nFile Name:  " + fileName);
            Thread.Sleep(2000);

            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            ss.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            */
            return ss;
        }








        private void Display_Load(object sender, EventArgs e)
        {

        }
    }
}
