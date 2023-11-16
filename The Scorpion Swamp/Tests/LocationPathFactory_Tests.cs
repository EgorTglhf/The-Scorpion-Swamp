using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    [TestFixture]
    internal class LocationPathFactory_Tests
    {
        readonly LocationPath path = LocationPathFactory.Create();

        [Test]
        public void LocationPathCheck()
        {
            Assert.IsTrue(path is LocationPath);
        }

        [Test]
        public void LocationPathCompleteCheck()
        {
            int numOfLocations = 0;
            int startNumOfLocations = path.NumOfLocations;
            while (path.IsNextLocationExists)
            {
                numOfLocations++;
                path.GetNextLocation();
            }
            Assert.AreEqual(numOfLocations, startNumOfLocations);
        }
    }
}
