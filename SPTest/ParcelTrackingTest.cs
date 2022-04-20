using NUnit.Framework;

namespace DemoTest.Baigiamasis.SPTest
{
    public class ParcelTrackingTest : SPBaseTest
    {
        [TestCase("ąčęė", "Nieko nerasta", TestName = "Test ąčęė")]
        [TestCase("test", "Nieko nerasta", TestName = "Test test")]
        [TestCase("0 1 1 0 1", "Nieko nerasta", TestName = "Test 0 1 1 0 1")]
        public static void TestParcelTrackerFromWebPage(string firstParameter, string answer)
        {
            parcelTrackingPage.NavigateToPage();
            parcelTrackingPage.InsertParcelNumber(firstParameter);
            parcelTrackingPage.ParcelTrackingSearchButton();
            parcelTrackingPage.VerifyResult(answer);
        }
    }
}
