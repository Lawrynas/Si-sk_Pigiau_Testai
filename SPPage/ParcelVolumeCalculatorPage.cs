using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoTest.Baigiamasis.SPPage
{
    public class ParcelVolumeCalculatorPage : SPBasePage
    {
        private const string pageAddress = "https://www.siuskpigiau.lt/irankiai/siuntos-turio-skaiciuokle";
        private IWebElement lenghtInputField => Driver.FindElement(By.Id("length"));
        private IWebElement widthInputField => Driver.FindElement(By.Id("width"));
        private IWebElement heightInputField => Driver.FindElement(By.Id("height"));
        private IWebElement quoteButton => Driver.FindElement(By.CssSelector("body > div:nth-child(8) > div > div > div > div > div > div > div:nth-child(2) > div > div:nth-child(1) > div > div:nth-child(4) > button"));
        private IWebElement resultFromPage => Driver.FindElement(By.Id("volume-inner_express"));

        public ParcelVolumeCalculatorPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != pageAddress)
            {
                Driver.Url = pageAddress;
            }
        }

        public void InsertLenghtInput(string firstParameter)
        {
            lenghtInputField.Clear();
            lenghtInputField.SendKeys(firstParameter);
        }
        public void InsertWidthInput(string secondParameter)
        {
            widthInputField.Clear();
            widthInputField.SendKeys(secondParameter);
        }
        public void InsertHeightInput(string thirdParameter)
        {
            heightInputField.Clear();
            heightInputField.SendKeys(thirdParameter);
        }

        public void InsertAllThreeInputs(string firstInput, string secondInput, string thirdInput)
        {
            InsertLenghtInput(firstInput);
            InsertWidthInput(secondInput);
            InsertHeightInput(thirdInput);
        }
        public void VolumeQuoteButton()
        {
            quoteButton.Click();
        }

        public void VerifyResult(string volume)
        {
            Assert.AreEqual(volume, resultFromPage.Text, $"Result is not the same, actual result is {resultFromPage.Text}");
        }
    }
}
