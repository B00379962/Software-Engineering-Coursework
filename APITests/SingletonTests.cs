using AssetReservation;
using DataAccessManager;
using Xunit;

namespace APITests
{
    public class SingletonTests
    {
        [Fact]
        public void TestAssetReservationSingletonWorking()
        {
            // check asset reservation singleton is working correctly by comparing instances and ensuring there is only 1

            SingletonAssetReservation testConnectionAssetReservation = SingletonAssetReservation.Instance;
            SingletonAssetReservation testConnectionAssetReservation2 = SingletonAssetReservation.Instance;
            SingletonAssetReservation testConnectionAssetReservation3 = SingletonAssetReservation.Instance;
            SingletonAssetReservation testConnectionAssetReservation4 = SingletonAssetReservation.Instance;

            Assert.True(testConnectionAssetReservation != null);
            Assert.True(testConnectionAssetReservation2 == testConnectionAssetReservation);
            Assert.True(testConnectionAssetReservation3 == testConnectionAssetReservation);
            Assert.True(testConnectionAssetReservation4 == testConnectionAssetReservation);

        }

        [Fact]
        public void TestDataAccessSingletonWorking()
        {
            // check data access singleton is working correctly by comparing instances and ensuring there is only 1

            SingletonDataAccessManager testConnectionAssetReservation = SingletonDataAccessManager.Instance;
            SingletonDataAccessManager testConnectionAssetReservation2 = SingletonDataAccessManager.Instance;
            SingletonDataAccessManager testConnectionAssetReservation3 = SingletonDataAccessManager.Instance;
            SingletonDataAccessManager testConnectionAssetReservation4 = SingletonDataAccessManager.Instance;

            Assert.True(testConnectionAssetReservation != null);
            Assert.True(testConnectionAssetReservation2 == testConnectionAssetReservation);
            Assert.True(testConnectionAssetReservation3 == testConnectionAssetReservation);
            Assert.True(testConnectionAssetReservation4 == testConnectionAssetReservation);

        }
    }
}
