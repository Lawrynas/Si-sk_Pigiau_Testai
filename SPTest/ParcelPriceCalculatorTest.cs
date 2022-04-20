using NUnit.Framework;

namespace DemoTest.Baigiamasis.SPTest
{
    public class ParcelPriceCalculatorTest : SPBaseTest
    {
        [TestCase("Pasirinkite gavėjo šalį", TestName = "Test empty parcel price calculator")]
        public static void TestEmptyParcelPriceCalculatorFromWebPage(string answer)
        {
            parcelPriceCalculatorPage.NavigateToPage();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();
        }

        [TestCase("42136", "Latvija", "3601", "1", "241", "1", "1", "Nurodytas pakuotės ilgis viršija maksimalų 240 cm ilgį", TestName = "Test Lenght error")]
        public static void TestParcelPriceCalculatorFromWebPage(string secondParameter, string thirdParameter, string fourthParameter, string fifthParameter, string sixthParameter, string seventhParameter, string eighthParameter, string answer)
        {
            parcelPriceCalculatorPage.InsertAllEmptyInputs(secondParameter, thirdParameter, fourthParameter, fifthParameter, sixthParameter, seventhParameter, eighthParameter);
            parcelPriceCalculatorPage.ClickEnvelopePackageButton();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();
            parcelPriceCalculatorPage.ClickBoxPackageButton();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();
            parcelPriceCalculatorPage.ClickDocumentsPackageButton();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();
            parcelPriceCalculatorPage.ClickPalletPackageButton();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();

        }

        [TestCase("40115", "1", "Netinkamas Gavėjo pašto kodo formatas. Tinkamas formatas:\r\n1001", TestName = "Test wrong postalcode")]
        public static void TestWrongPostalCodeInParcelPriceCalculatorFromWebPage(string fourthParameter, string sixthParameter, string answer)
        {
            parcelPriceCalculatorPage.InsertPostalCodeToInput(fourthParameter);
            parcelPriceCalculatorPage.InsertLenghtInput(sixthParameter);
            parcelPriceCalculatorPage.ClickEnvelopePackageButton();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();
            parcelPriceCalculatorPage.ClickBoxPackageButton();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();
            parcelPriceCalculatorPage.ClickDocumentsPackageButton();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();
            parcelPriceCalculatorPage.ClickPalletPackageButton();
            parcelPriceCalculatorPage.ClickQuoteAndBookButton();
            parcelPriceCalculatorPage.VerifyResult(answer);
            parcelPriceCalculatorPage.ClickErrorBoxCloseButton();
        }

    }
}
