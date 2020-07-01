using System.Threading;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ContentOne.UI.Tests
{
    public class SeleniumTests
    {
        [Trait("Category", "Smoke")]
        [Fact]
        public void LoadContentOneQA()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://content1.qa.travcorpservices.com/");

                Thread.Sleep(900);
            }
        }

        [Trait("Category", "Smoke")]
        [Fact]
        public void IsPageTitlePdms()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://content1.qa.travcorpservices.com/");

                string pageTitle = driver.Title;

                Assert.Equal("Pdms", pageTitle);
            }
        }
    }
}
