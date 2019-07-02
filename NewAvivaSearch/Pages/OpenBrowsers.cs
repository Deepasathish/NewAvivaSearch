using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAvivaSearch.Pages
{
    class OpenBrowsers
    {
        public static IWebDriver driver;

        public static void OpenChromeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static void CloseBrowser()
        {
            driver.Close();
            driver.Dispose();
        }
        
    }
}
