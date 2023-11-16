using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    [TestFixture]
    internal class LocationFactory_Tests
    {
        [Test]
        public void LocationFactoryCreateTypeCheck()
        {
            Location location = LocationFactory.Create();
            Assert.IsTrue(location is Location);
        }

        [Test]
        public void LocationFactoryCreateGladeTypeCheck()
        {
            Location glade = LocationFactory.CreateGlade();
            Assert.IsTrue(glade is LocationGlade);
        }

        [Test]
        public void LocationFactoryCreateSwampTypeCheck()
        {
            Location swamp = LocationFactory.CreateSwamp();
            Assert.IsTrue(swamp is LocationSwamp);
        }

        [Test]
        public void LocationFactoryCreateThicketTypeCheck()
        {
            Location thicket = LocationFactory.CreateThicket();
            Assert.IsTrue(thicket is LocationThicket);
        }
    }
}
