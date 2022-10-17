using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace EHealthcareTesting.StepDefinitions
{
    [Binding]
    public class EHealthcareStepDefinitions
    {
        private ChromeDriver chromeDriver;

        public EHealthcareStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\Sumit.Rana\\Downloads\\chromedriver_win32");

        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:5000/login");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var user = chromeDriver.FindElement(By.XPath("//*[@name='username']"));
            user.SendKeys("bob");
        }

        [Then(@"I entered password")]
        public void ThenIEnteredPassword()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var password = chromeDriver.FindElement(By.XPath("//*[@name='password']"));
            password.SendKeys("Pa$$w0rd");

            WebDriverWait wait1 = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var SignInButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div/form/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", SignInButton);
        }

        [When(@"I clicked on Add to cart button")]
        public void WhenIClickedOnAddToCartButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var AddtocartButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/div/div[4]/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", AddtocartButton);
        }

        [Then(@"I click on add to cart symbol button")]
        public void ThenIClickOnAddToCartSymbolButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var cartButton = chromeDriver.FindElement(By.XPath("/html/body/div/header/div/div[2]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", cartButton);
            WebDriverWait wait1 = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
        }

        [When(@"I clicked on Checkout button")]
        public void WhenIClickedOnCheckoutButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var checkoutButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/a"));
            chromeDriver.ExecuteScript("arguments[0].click();", checkoutButton);
        }

        [When(@"Shipping address page displays and click on next button")]
        public void WhenShippingAddressPageDisplaysAndClickOnNextButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var addressButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div/form/div[2]/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", addressButton);
        }
    

        [Then(@"Review order page displays and click on next button")]
        public void ThenReviewOrderPageDisplaysAndClickOnNextButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var reviewButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div/form/div[3]/button[2]"));
            chromeDriver.ExecuteScript("arguments[0].click();", reviewButton);
        }

        [When(@"I enter Card Name")]
        public void WhenIEnterCardName()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var cardname = chromeDriver.FindElement(By.XPath("//*[@name='nameOnCard']"));
            cardname.SendKeys("Bob");
        }

        [Then(@"I enter Card number")]
        public void ThenIEnterCardNumber()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var cardnumber = chromeDriver.FindElement(By.XPath("//*[@id='cardNumber']"));
            cardnumber.SendKeys("4242 4242 4242 4242");
        }

        [Then(@"I enter expiry date")]
        public void ThenIEnterExpiryDate()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var expiry = chromeDriver.FindElement(By.XPath("//*[@id='expDate']"));
            expiry.SendKeys("1225");
        }

        [Then(@"I enter CVV")]
        public void ThenIEnterCVV()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var cvv = chromeDriver.FindElement(By.XPath("//*[@id='cvv']"));
            cvv.SendKeys("123");
        }

        [When(@"I click on place order button payment successful page displays")]
        public void WhenIClickOnPlaceOrderButtonPaymentSuccessfulPageDisplays()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var placeorderButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div/form/div[2]/button[2]"));
            chromeDriver.ExecuteScript("arguments[0].click();", placeorderButton);
        }
    }
}
