using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace B78_N2_KTPM_TH_SELENIUM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen27_Click(object sender, EventArgs e)
        {
            IWebDriver hoang27 = new ChromeDriver();
            hoang27.Navigate().GoToUrl("https://id.zing.vn/");
            //classname
            hoang27.FindElement(By.ClassName("zidregbtn")).Click();
            //id 
            hoang27.FindElement(By.Id("regacc_fullname")).SendKeys("hoangga15505");
            //name 
            hoang27.FindElement(By.Name("account")).SendKeys("hoangga15505");

            // Xpath
            hoang27.FindElement(By.XPath("//*[@id='regacc_pwd']")).SendKeys("Abc123@@");
            hoang27.FindElement(By.XPath("//*[@id='regacc_re_pwd']")).SendKeys("Abc123@@");
            
            //selector
            hoang27.FindElement(By.CssSelector("input[tabindex='9']")).Click();

            // link text
            hoang27.FindElement(By.LinkText("Tiếp tục")).Click();
            Thread.Sleep(10000);
            hoang27.Close();
        }

        private void btn_bai2_27_Click(object sender, EventArgs e)
        {
            IWebDriver Lhoang27 = new ChromeDriver();
            Lhoang27.Url="https://en.wikipedia.org/wiki/Otaku";
            Lhoang27.Navigate();
            //IWebElement element27 = Lhoang27.FindElement(By.TagName("h1"));
            IReadOnlyCollection<IWebElement> ee27 = Lhoang27.FindElements(By.TagName("h2"));
            foreach(var element27 in ee27)
            {
                Console.WriteLine(element27.Text);
            }    

        }
    }
}
