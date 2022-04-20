using OpenQA.Selenium;

namespace DemoTest.Baigiamasis.SPPage
{
    public class SPBasePage
    {
        protected static IWebDriver Driver;

        public SPBasePage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }

        public void CloseBrowser()
        {
            Driver.Quit();
        }
    }
}
