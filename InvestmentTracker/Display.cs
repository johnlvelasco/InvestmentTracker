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

namespace InvestmentTracker
{
    public partial class Display : Form
    {
        public IWebDriver chromeDriver { get; set; }

        public Display(IWebDriver driver)
        {
            InitializeComponent();
            driver.Navigate().GoToUrl("https://www.gate.io/trade/ETH_USDT");

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += new System.EventHandler(timer_Tick);
            timer.Start();

            /*
            for (int i=0; i < 3; i++)
            {

            }
            */
            


        }


        private void timer_Tick(object sender, EventArgs e)
        {
            SetValues(chromeDriver);
            
        }

        public void SetValues(IWebDriver driver)
        {
            uxPrice.Text = driver.FindElement(By.Id("currPrice")).Text; 
            uxRate.Text = driver.FindElement(By.Id("currRateNum")).Text + "%";
            uxHigh.Text = driver.FindElement(By.Id("tHigh")).Text;
            uxLow.Text = driver.FindElement(By.Id("tLow")).Text;

        }

        public void ShowDisplay(Display d, int displays)
        {

            if (displays == 1)
            {
                displays++;
                //Application.Run(d);
            }
            else
            {
                displays++;
                d.Refresh();
                //Application.DoEvents();
            }
        }
    }
}
