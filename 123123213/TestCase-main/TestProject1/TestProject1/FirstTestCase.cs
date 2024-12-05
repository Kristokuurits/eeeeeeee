using com.sun.tools.@internal.xjc.reader.gbind;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace TestProject1
{
    public class FirstTestCase
    {
        public event EventHandler? Clicked;

        static void Main(string[] args)
        {
            //AnimatedButton()
            //TestClickTwice();
            //TestDisabledInput();
            //TestHidingButton();
            //TestSampleApp();
            //TestTextInput();

        }
        [Test]
        public static void AnimatedButton()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/animation";


            IWebElement element = driver.FindElement(By.Id("animationButton"));
            element.Click();
            System.Threading.Thread.Sleep(10000);
            IWebElement eleement = driver.FindElement(By.Id("movingTarget"));
            eleement.Click();

            driver.Quit();
        }
 
        [Test]
        public static void TestClickTwice()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/mouseover";

            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.ClassName("text-primary"));
            actions.DoubleClick(element).Perform();

        }
        [Test]
        public static void TestDisabledInput()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/disabledinput";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement textField = wait.Until(d => d.FindElement(By.Id("inputField")));

            textField.SendKeys("This is a test input!");

            Assert.AreEqual("This is a test input!", textField.GetAttribute("value"));

            driver.Quit();
        }
        [Test]
        public static void TestHidingButton()
        {

            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";


            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;


            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);

            driver.Url = "http://www.uitestingplayground.com/scrollbars";

            IWebElement element = driver.FindElement(By.Id("hidingButton"));
            element.Click();
        }
        [Test]
        public static void TestSampleApp()
        {

            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";


            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;


            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);

            driver.Url = "http://www.uitestingplayground.com/sampleapp";

            IWebElement element = driver.FindElement(By.ClassName("form-control"));
            element.SendKeys("hi");
            IWebElement eleement = driver.FindElement(By.ClassName("form-control"));
            eleement.SendKeys("pwd");
            IWebElement eleeement = driver.FindElement(By.Id("login"));
            eleeement.Click();
        }
        [Test]
        public static void TestTextInput()
        {

            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";


            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;


            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);

            driver.Url = "http://www.uitestingplayground.com/textinput";

            IWebElement element = driver.FindElement(By.ClassName("form-control"));
            element.SendKeys("hi");
            IWebElement eleeement = driver.FindElement(By.Id("updatingButton"));
            eleeement.Click();
        }
    }
}