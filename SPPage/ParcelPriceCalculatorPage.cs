using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace DemoTest.Baigiamasis.SPPage
{
    public class ParcelPriceCalculatorPage : SPBasePage
    {
        private const string pageAddress = "https://www.siuskpigiau.lt/irankiai/siuntu-kainos-skaiciuokle";
        private IWebElement countryFromField => Driver.FindElement(By.Id("country-from"));
        private IWebElement postalCodeFromField => Driver.FindElement(By.Id("calculator_form_postalCodeFrom"));
        private IWebElement countryToField => Driver.FindElement(By.Id("country-to"));
        private IWebElement postalCodeToField => Driver.FindElement(By.Id("calculator_form_postalCodeTo"));
        private IWebElement envelopeButton => Driver.FindElement(By.CssSelector("#calculator-form > div.calc-form-footer > div > div:nth-child(1) > div > ul.tabs.d-md-flex > li.envelope"));
        private IWebElement boxButton => Driver.FindElement(By.CssSelector("#calculator-form > div.calc-form-footer > div > div:nth-child(1) > div > ul.tabs.d-md-flex > li:nth-child(2) > div"));
        private IWebElement documentsButton => Driver.FindElement(By.CssSelector("#calculator-form > div.calc-form-footer > div > div:nth-child(1) > div > ul.tabs.d-md-flex > li:nth-child(3) > div"));
        private IWebElement palletButton => Driver.FindElement(By.CssSelector("#calculator-form > div.calc-form-footer > div > div:nth-child(1) > div > ul.tabs.d-md-flex > li:nth-child(4) > div"));
        private IWebElement weightField => Driver.FindElement(By.Id("calculator_form_packages_0_weight"));
        private IWebElement lenghtField => Driver.FindElement(By.Id("calculator_form_packages_0_length"));
        private IWebElement widthField => Driver.FindElement(By.Id("calculator_form_packages_0_width"));
        private IWebElement heightField => Driver.FindElement(By.Id("calculator_form_packages_0_height"));
        private IWebElement quoteAndBookButton => Driver.FindElement(By.Id("skaiciuoti"));
        private IWebElement resultFromWebPage => Driver.FindElement(By.CssSelector("#calcErrorModal > div > div > div.modal-body.error-modal-body > div"));
        private IWebElement closeButton => Driver.FindElement(By.CssSelector("#calcErrorModal > div > div > div.modal-header > button"));

        public ParcelPriceCalculatorPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToPage()
        {
            if (Driver.Url != pageAddress)
            {
                Driver.Url = pageAddress;
            }
        }

        public void InsertCountryFromInput(string firstParameter)
        {
            countryFromField.Clear();
            countryFromField.SendKeys(firstParameter);
        }
        public void InsertPostalCodeFromInput(string secondParameter)
        {
            postalCodeFromField.Clear();
            postalCodeFromField.SendKeys(secondParameter);
        }
        public void InsertCountryToInput(string thirdParameter)
        {
            countryToField.Clear();
            countryToField.SendKeys(thirdParameter);
        }
        public void InsertPostalCodeToInput(string fourthParameter)
        {
            postalCodeToField.Clear();
            postalCodeToField.SendKeys(fourthParameter);
        }
        public void InsertWeighttInput(string fifthParameter)
        {
            weightField.Clear();
            weightField.SendKeys(fifthParameter);
        }
        public void InsertLenghtInput(string sixthParameter)
        {
            lenghtField.Clear();
            lenghtField.SendKeys(sixthParameter);
        }
        public void InsertWidthInput(string seventhParameter)
        {
            widthField.Clear();
            widthField.SendKeys(seventhParameter);
        }
        public void InsertHeightInput(string eighthParameter)
        {
            heightField.Clear();
            heightField.SendKeys(eighthParameter);
        }

        public void InsertAllEmptyInputs(string secondInput, string thirdInput, string fourthInput, string fifthInput, string sixthInput, string seventhInput, string eighthInput)
        {
            InsertPostalCodeFromInput(secondInput);
            InsertCountryToInput(thirdInput);
            InsertPostalCodeToInput(fourthInput);
            InsertWeighttInput(fifthInput);
            InsertLenghtInput(sixthInput);
            InsertWidthInput(seventhInput);
            InsertHeightInput(eighthInput);
        }
        public void ClickEnvelopePackageButton()
        {
            envelopeButton.Click();
        }
        public void ClickBoxPackageButton()
        {
            boxButton.Click();
        }
        public void ClickDocumentsPackageButton()
        {
            documentsButton.Click();
        }
        public void ClickPalletPackageButton()
        {
            palletButton.Click();
        }
        public void ClickQuoteAndBookButton()
        {
            quoteAndBookButton.Click();
        }
        public void ClickErrorBoxCloseButton()
        {
            closeButton.Click();
        }
        public void VerifyResult(string answer)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(tempDriver => tempDriver.FindElement(By.CssSelector("#calcErrorModal > div > div > div.modal-body.error-modal-body > div")).Displayed);
            Assert.AreEqual(answer, resultFromWebPage.Text, $"Result is not the same, actual result is {resultFromWebPage.Text}");
        }

    }
}
