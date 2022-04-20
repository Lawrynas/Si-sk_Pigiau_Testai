using DemoTest.Baigiamasis.Driver;
using DemoTest.Baigiamasis.SPPage;
using DemoTest.Baigiamasis.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace DemoTest.Baigiamasis.SPTest
{
    public class SPBaseTest
    {

        protected static ParcelPriceCalculatorPage parcelPriceCalculatorPage;
        protected static ParcelTrackingPage parcelTrackingPage;
        protected static ParcelVolumeCalculatorPage parcelVolumeCalculatorPage;
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = CustomDrivers.GetIncognitoChrome();
            parcelPriceCalculatorPage = new ParcelPriceCalculatorPage(driver);
            parcelTrackingPage = new ParcelTrackingPage(driver);
            parcelVolumeCalculatorPage = new ParcelVolumeCalculatorPage(driver);
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(driver);
            }
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

    }
}
