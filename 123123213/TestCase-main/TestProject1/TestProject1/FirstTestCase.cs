using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject1
{
    public  class FirstTestCase
    {
        static void Main(string[] args)
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;
            
            
            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "file:///C:/Users/opilane/source/repos/PEEEEETR/ARLOOO-main/Shoppp-main/M-ng-main/index.html";
        }
        [Test]
        public void TestClick()
        {
            driver.Navigate().GoToUrl("http://www.uitestingplayground.com/click");

            var Button = driver.FindElement(By.Id("badButton"));

            Actions actions = new Actions(driver);
            actions.MoveToElement(Button).Click().Perform();

            string buttonClass = Button.GetAttribute("class");
            Assert.That(buttonClass.Contains("btn-success"), Is.True, "The button did not turn green after clicking.");
        }
        [Test]
        public void TestAlerts()
        {
            driver.Navigate().GoToUrl("http://www.uitestingplayground.com/alerts");

            var alertButton = driver.FindElement(By.Id("alertButton"));
            alertButton.Click();
            driver.SwitchTo().Alert().Accept();

            var confirmButton = driver.FindElement(By.Id("confirmButton"));
            confirmButton.Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();

            var promptButton = driver.FindElement(By.Id("promptButton"));
            promptButton.Click();
            Thread.Sleep(1000);
            var alert = driver.SwitchTo().Alert();
            alert.SendKeys("hello");
            alert.Accept();
        }
        [Test]
        public static void TestClickTwice()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/mouseover";

            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.ClassName("text-primary"));
            actions.DoubleClick(element).Perform();

        }
        [Test]
        public static void TestWaitForButton()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/autowait";

            IWebElement element = driver.FindElement(By.Id("applyButton3"));
            element.Click();
            Task.Delay(4000).Wait();
            IWebElement element2 = driver.FindElement(By.Id("target"));
            element2.Click();

        }
        public void TextInput()
        {
            driver.Navigate().GoToUrl("http://www.uitestingplayground.com/textinput");

            var inputField = driver.FindElement(By.Id("newButtonName"));
            var button = driver.FindElement(By.Id("updatingButton"));

            Actions actions = new Actions(driver);
            actions.Click(inputField)
                .SendKeys("Hello World")
                .Perform();

            button.Click();

            string buttonText = button.Text;
            Assert.That(buttonText, Is.EqualTo("Hello World"), "The button name did not change as expected.");
        }
        [Test]
        public void TestDisabledInput()
        {
            driver.Navigate().GoToUrl("http://www.uitestingplayground.com/disabledinput");

            var button = driver.FindElement(By.Id("enableButton"));
            button.Click();

            var inputField = driver.FindElement(By.Id("inputField"));
            var waitTime = TimeSpan.FromSeconds(0);
            while (inputField.GetAttribute("disabled") == "true" && waitTime.TotalSeconds < 10)
            {
                Thread.Sleep(500);
                waitTime += TimeSpan.FromMilliseconds(500);
            }

            inputField.SendKeys("Hello World!");

            Assert.That(inputField.GetAttribute("value"), Is.EqualTo("Hello World!"), "The input field value was not set correctly.");
        }
    }
}
