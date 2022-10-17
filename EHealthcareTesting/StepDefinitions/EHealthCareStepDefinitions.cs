using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace EHealthcareTesting.StepDefinitions
{
    [Binding]
    public class EHealthCareStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public EHealthCareStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\Sumit.Rana\\Downloads\\chromedriver_win32");

        [Given(@"I have navigate to EHealthcare website")]
        public void GivenIHaveNavigateToEHealthcareWebsite()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:3000/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

        [When(@"I click on Catalog button")]
        public void WhenIClickOnCatalogButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var ListProductButton = chromeDriver.FindElement(By.XPath("/html/body/div/header/div/ul/a[1]"));
            chromeDriver.ExecuteScript("arguments[0].click();", ListProductButton);
        }

        [Then(@"It shows lists of Products")]
        public void ThenItShowsListsOfProducts()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2500));
        }
    }
}
