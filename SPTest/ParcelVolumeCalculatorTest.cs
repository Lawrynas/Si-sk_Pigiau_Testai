using NUnit.Framework;

namespace DemoTest.Baigiamasis.SPTest
{
    public class ParcelVolumeCalculatorTest : SPBaseTest
    {
        [TestCase("1000", "1000", "1000", "1000.000", TestName = "Test 1000x1000x1000")]
        [TestCase("0001", "0001", "0001", "0.000", TestName = "Test 0001x0001x0001")]
        [TestCase("10", "10", "10", "0.001", TestName = "Test 10x10x10")]
        public static void TestVolumeCalculatorFromWebPage(string firstParameter, string secondParameter, string thirdParameter, string volume)
        {
            parcelVolumeCalculatorPage.NavigateToPage();
            parcelVolumeCalculatorPage.InsertAllThreeInputs(firstParameter, secondParameter, thirdParameter);
            parcelVolumeCalculatorPage.VolumeQuoteButton();
            parcelVolumeCalculatorPage.VerifyResult(volume);
        }
        
    }
}
