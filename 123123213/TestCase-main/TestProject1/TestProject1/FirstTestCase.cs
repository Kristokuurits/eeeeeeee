using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;

namespace SeleniumMarken
{
    public class FirstTestCase
    {
        public event EventHandler? Clicked;

        static void Main(string[] args)
        {
            //TestHidingButton();
            //TestClickTwice();
            //TestHiddenButtons();
            //TestClick();
            //TestWaitForButton();
            //TestTextInput();
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

        public static void TestClientDelay()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/clientdelay";

            IWebElement element = driver.FindElement(By.Id("ajaxButton"));
            element.Click();
            Thread.Sleep(15000);
            IWebElement p = driver.FindElement(By.ClassName("bg-success"));
            p.Click();
        }
        [Test]
        public static void TestClick()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/click";

            IWebElement element = driver.FindElement(By.Id("badButton"));
            element.Click();
            try
            {
                element.Click();
            }
            catch
            {
                Console.WriteLine("Cannot click button");
            }

        }
        [Test]
        public static void TestWaitForButton()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/autowait";

            IWebElement element = driver.FindElement(By.Id("applyButton3"));
            element.Click();
            Task.Delay(4000).Wait();
            IWebElement element2 = driver.FindElement(By.Id("target"));
            element2.Click();

        }
        [Test]
        public static void TestUpload()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\eeeeeeee-main\\123123213\\TestCase-main\\TestProject1\\TestProject1\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/upload";

            IWebElement fileInput = driver.FindElement(By.Id("file-upload"));
            string filePath = @"C:\path\to\your\file.txt";
            fileInput.SendKeys(filePath);

        }
    }
}