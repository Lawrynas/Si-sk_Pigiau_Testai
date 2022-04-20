using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoTest.Baigiamasis.SPPage
{
    public class ParcelTrackingPage : SPBasePage
    {
        private const string pageAddress = "https://www.siuskpigiau.lt/irankiai/siuntu-paieska";
        private IWebElement parcelNumberInputField => Driver.FindElement(By.Id("track-parcel-field"));
        private IWebElement parcelSearchButton => Driver.FindElement(By.CssSelector("body > div.container.static-page-custom > div > div > div > div > div > div.block-content.responsive-table-custom-auto > form > div > div.col-md-2 > button"));
        private IWebElement resultFromWebPage => Driver.FindElement(By.CssSelector("body > div.container.static-page-custom > div > div > div > div > div > div.block-content.responsive-table-custom-auto > div"));

        public ParcelTrackingPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != pageAddress)
            {
                Driver.Url = pageAddress;
            }
        }

        public void InsertParcelNumber(string firstParameter)
        {
            parcelNumberInputField.Clear();
            parcelNumberInputField.SendKeys(firstParameter);
        }
        public void ParcelTrackingSearchButton()
        {
            parcelSearchButton.Click();
        }
        public void VerifyResult(string answer)
        {
            Assert.AreEqual(answer, resultFromWebPage.Text, $"Text is not the same, actual text is {resultFromWebPage.Text}");
        }
    }
}
