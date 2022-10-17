using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace EHealthcareTesting.StepDefinitions
{
    [Binding]
    public class AddtocartStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public AddtocartStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\Sumit.Rana\\Downloads\\chromedriver_win32");

        [Given(@"I have navigated to EHealthcare website")]
        public void GivenIHaveNavigatedToEHealthcareWebsite()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:3000/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

        [When(@"I need to click on Catalog button")]
        public void WhenINeedToClickOnCatalogButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var ListProductButton = chromeDriver.FindElement(By.XPath("/html/body/div/header/div/ul/a[1]"));
            chromeDriver.ExecuteScript("arguments[0].click();", ListProductButton);
        }

        [Then(@"It shows catalog")]
        public void ThenItShowsCatalog()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2500));
        }

        [When(@"I click on Add to cart button")]
        public void WhenIClickOnAddToCartButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var AddtocartButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/div/div[4]/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", AddtocartButton);
        }

        [When(@"I click on Cart symbol button")]
        public void WhenIClickOnCartSymbolButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var cartButton = chromeDriver.FindElement(By.XPath("/html/body/div/header/div/div[2]/a/span[1]/svg/path"));
            chromeDriver.ExecuteScript("arguments[0].click();", cartButton);
        }

        [Then(@"It will navigate to checkout page")]
        public void ThenItWillNavigateToCheckoutPage()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2500));
        }

        [When(@"I click on Checkout button")]
        public void WhenIClickOnCheckoutButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var checkoutButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", checkoutButton);
        }

        [Then(@"Checkout Page appears")]
        public void ThenCheckoutPageAppears()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(2500));
        }
    }
}
