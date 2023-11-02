using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    [TestFixture]
    internal class Location_Tests
    {
        [Test]
        public void LocationGladeTypeCheck()
        {
            LocationGlade glade = new LocationGlade();
            Assert.AreEqual(TypeOfLocation.Glade, glade.Type);
        }
        [Test]
        public void LocationGladeEffectCheck() 
        {
            LocationGlade glade = new LocationGlade();
            AdventurerSingleton hero = AdventurerSingleton.Instance;
            var hpBefore = hero.Health;
            glade.Effect(hero);
            var hpAfter = hero.Health;
            Assert.Less(hpBefore, hpAfter);
        }
        [Test]
        public void LocationSwampTypeCheck()
        {
            LocationSwamp swamp = new LocationSwamp();
            Assert.AreEqual(TypeOfLocation.Swamp, swamp.Type);
        }
        [Test]
        public void LocationSwampEffectCheck()
        {
            LocationSwamp swamp = new LocationSwamp();
            AdventurerSingleton hero = AdventurerSingleton.Instance;
            var hpBefore = hero.Health;
            swamp.Effect(hero);
            var hpAfter = hero.Health;
            Assert.Greater(hpBefore, hpAfter);
        }
        [Test]
        public void LocationThicketTypeCheck()
        {
            LocationThicket thicket = new LocationThicket();
            Assert.AreEqual(TypeOfLocation.Thicket, thicket.Type);
        }
        [Test]
        public void LocationThicketEffectCheck()
        {
            LocationThicket thicket = new LocationThicket();
            AdventurerSingleton hero = AdventurerSingleton.Instance;
            var hpBefore = hero.Health;
            thicket.Effect(hero);
            var hpAfter = hero.Health;
            Assert.Greater(hpBefore, hpAfter);
        }
    }
}
