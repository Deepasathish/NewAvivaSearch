using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewAvivaSearch.Pages
{ 

    class GoogleHompageLocators
    {
        public By GoogleSearchField => By.Name("q");
        public By links => By.XPath("//div[@class='r']/a[1]/h3");
    }
}
