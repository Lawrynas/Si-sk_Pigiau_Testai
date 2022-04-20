using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace DemoTest.Baigiamasis.Driver
{
    public class CustomDrivers
    {
        public static IWebDriver GetChrome()
        {
            Browsers webdriver = Browsers.Chrome;
            return GetDriver(webdriver);
        }

        public static IWebDriver GetFirefox()
        {
            return GetDriver(Browsers.Firefox);
        }

        public static IWebDriver GetEdge()
        {
            return GetDriver(Browsers.Edge);
        }
        public static IWebDriver GetIncognitoChrome()
        {
            return GetDriver(Browsers.IncognitoChrome);
        }

        private static IWebDriver GetDriver(Browsers browser)
        {
            IWebDriver driver;
            switch (browser)
            {
                case Browsers.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Browsers.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case Browsers.Edge:
                    driver = new EdgeDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }

    }
}
