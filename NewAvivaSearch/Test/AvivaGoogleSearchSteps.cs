using NewAvivaSearch.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AvivaSearch
{
    [Binding]
    public class AvivaGoogleSearchSteps
    {
        GooglePageExecutors googlepageexecutors = new GooglePageExecutors();
        [BeforeScenario]
        public void BeforeScenario()
        {
            OpenBrowsers.OpenChromeBrowser();
        }

        [Given(@"I am on the google page")]
        public void GivenIAmOnTheGooglePage()

        {
            OpenBrowsers.driver.Navigate().GoToUrl("https://www.google.com");

         }
        
        [Given(@"I Enter '(.*)' in Google search bar")]
        public void GivenIEnterInGoogleSearchBar(string keyword)
        {
            googlepageexecutors.GoogleSearchKeyword(keyword);
        }
        
        [Then(@"the result page with '(.*)' links should be returned in the search page")]
        public void ThenTheResultPageWithLinksShouldBeReturnedInTheSearchPage(int links)
        {
          int acutallLinks= googlepageexecutors.GetAllLinks();
            Assert.AreEqual(links, acutallLinks, "Number of links don't match with the expected links");
        }
        
        [Then(@"print the fifth link text")]
        public void ThenPrintTheFifthLinkText()
        {
            string fifthLinkText = "The links returned is less than 5.";
            if (googlepageexecutors.GetAllLinks() > 5)
            {
               fifthLinkText = googlepageexecutors.GetLinkText(4);
            }
            Console.WriteLine("The fifth link text in Google search page is : " + fifthLinkText);
        }
        [AfterScenario]
        public void AfterScenario()
        {
            OpenBrowsers.CloseBrowser();
        }
    }
}
