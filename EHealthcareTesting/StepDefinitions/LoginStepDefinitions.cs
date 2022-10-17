using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace EHealthcareTesting.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private ChromeDriver chromeDriver;

        public LoginStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\Sumit.Rana\\Downloads\\chromedriver_win32");
    
        [Given(@"I log in")]
        public void GivenILogIn()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:5000/login");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var user = chromeDriver.FindElement(By.XPath("//*[@name='username']"));
            user.SendKeys("bob");
        }

        [Then(@"I enter password")]
        public void ThenIEnterPassword()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var password = chromeDriver.FindElement(By.XPath("//*[@name='password']"));
            password.SendKeys("Pa$$w0rd");

            WebDriverWait wait1 = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(1500));
            var SignInButton = chromeDriver.FindElement(By.XPath("/html/body/div/div[2]/div/form/button"));
            chromeDriver.ExecuteScript("arguments[0].click();", SignInButton);
        }
    }
}
