using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAvivaSearch.Pages
{
    class GooglePageExecutors
    {
        GoogleHompageLocators googlehomelocators = new GoogleHompageLocators();

        public void GoogleSearchKeyword(string keyword)
        {
            OpenBrowsers.driver.FindElement(googlehomelocators.GoogleSearchField).SendKeys(keyword);
            OpenBrowsers.driver.FindElement(googlehomelocators.GoogleSearchField).SendKeys(Keys.Enter);
        }
        public int GetAllLinks()
        {
            int countAllLinks = OpenBrowsers.driver.FindElements(googlehomelocators.links).Count;
            return countAllLinks;
        }
        public String GetLinkText(int indexOf)
        {
            string getText = OpenBrowsers.driver.FindElements(googlehomelocators.links)[indexOf - 1].Text;
            return getText;
        }

    }
}