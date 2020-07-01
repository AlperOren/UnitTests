using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ContentOne.UI.Tests
{
    public class SeleniumTests
    {
        [Trait("Category", "Smoke")]
        [Fact]
        public void LoadUmbraco()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:2728/umbraco");
            }
        }
    }
}
