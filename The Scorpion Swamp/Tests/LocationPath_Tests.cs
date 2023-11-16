using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    [TestFixture]
    internal class LocationPath_Tests
    {
        readonly LocationPath path = new LocationPath();
        readonly Location firstLocation = LocationFactory.Create();
        readonly Location secondLocation = LocationFactory.Create();

        [Test]
        public void LocationPathEmptyCheck()
        {
            Assert.IsFalse(path.IsNextLocationExists);
            Assert.IsNull(path.GetNextLocation());
            Assert.AreEqual(path.NumOfLocations, 0);
        }

        [Test]
        public void LocationPathOneLocationCheck()
        {
            path.AddLocation(firstLocation);
            Assert.AreEqual(path.NumOfLocations, 1);
            Assert.IsTrue(path.IsNextLocationExists);
            Assert.AreEqual(firstLocation, path.GetNextLocation());
            Assert.AreEqual(path.NumOfLocations, 0);
            Assert.IsNull(path.GetNextLocation());
        }

        [Test]
        public void LocationPathTwoLocationCheck()
        {
            path.AddLocation(firstLocation);
            path.AddLocation(secondLocation);
            Assert.AreEqual(path.NumOfLocations, 2);
            Assert.IsTrue(path.IsNextLocationExists);
            Assert.AreEqual(firstLocation, path.GetNextLocation());
            Assert.AreEqual(path.NumOfLocations, 1);
            Assert.IsTrue(path.IsNextLocationExists);
            Assert.AreEqual(secondLocation, path.GetNextLocation());
            Assert.IsFalse(path.IsNextLocationExists);
            Assert.AreEqual(path.NumOfLocations, 0);
            Assert.IsNull(path.GetNextLocation());
        }
    }
}
