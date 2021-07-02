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
using System.IO;

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

            SetVisual();
            /*
            Thread.Sleep(3000);
            driver.Quit();
            Environment.Exit(0);
            */
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
        public void SetVisual()
        {
            IWebDriver visualDriver = new ChromeDriver();

            visualDriver.Navigate().GoToUrl("https://www.tradingview.com/chart/?symbol=BITSTAMP%3AETHUSD");
            //Size graph = visualDriver.FindElement(By.ClassName("chart-gui-wrapper")).Size;
            //Size priceAxis = visualDriver.FindElement(By.ClassName("price-axis")).Size;

            //Screenshot & Display works, lets try to dark mode it.
            //visualDriver.SwitchTo().ActiveElement().SendKeys(Keys.Shift + Keys.F10);


            Screenshot screenshot = ((ITakesScreenshot)visualDriver).GetScreenshot();
            string localDate = DateTime.Now.ToString("MM_dd_yyyy");
            string path = "C:/Users/johnv/Desktop/Personal Projects/Visual_" + localDate + ".png";
            screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);

            uxVisual.Image = Image.FromFile(path);
            uxVisual.SizeMode = PictureBoxSizeMode.StretchImage;

            //visualDriver.Quit();
        }








        private void Display_Load(object sender, EventArgs e)
        {

        }
    }
}
