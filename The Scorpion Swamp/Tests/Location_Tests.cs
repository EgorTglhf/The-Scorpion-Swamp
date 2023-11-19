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
        //Glade
        [Test]
        public void LocationGladeTypeCheck()
        {
            LocationGlade glade = new LocationGlade();
            Assert.AreEqual(TypeOfLocation.Glade, glade.Type);
        }
        [Test]
        public void LocationGladeEnemyCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            LocationGlade glade = new LocationGlade(enemy);
            Assert.IsTrue(glade.EnemyOnLocation is Enemy);
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
        public void LocationGladeEffectEnemyCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            LocationGlade glade = new LocationGlade(enemy);
            AdventurerSingleton hero = AdventurerSingleton.Instance;
            var hpBefore = hero.Health;
            glade.Effect(hero);
            var hpAfter = hero.Health;
            Assert.AreEqual(hpBefore, hpAfter);
        }
        //Swamp
        [Test]
        public void LocationSwampTypeCheck()
        {
            LocationSwamp swamp = new LocationSwamp();
            Assert.AreEqual(TypeOfLocation.Swamp, swamp.Type);
        }
        [Test]
        public void LocationSwampEnemyCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            LocationSwamp swamp = new LocationSwamp(enemy);
            Assert.IsTrue(swamp.EnemyOnLocation is Enemy);
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
        public void LocationSwampEffectEnemyCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            LocationSwamp swamp = new LocationSwamp(enemy);
            AdventurerSingleton hero = AdventurerSingleton.Instance;
            var hpBefore = hero.Health;
            swamp.Effect(hero);
            var hpAfter = hero.Health;
            Assert.Greater(hpBefore, hpAfter);
        }
        //Thicket
        [Test]
        public void LocationThicketTypeCheck()
        {
            LocationThicket thicket = new LocationThicket();
            Assert.AreEqual(TypeOfLocation.Thicket, thicket.Type);
        }
        [Test]
        public void LocationThicketEnemyCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            LocationThicket thicket = new LocationThicket(enemy);
            Assert.IsTrue(thicket.EnemyOnLocation is Enemy);
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
        [Test]
        public void LocationThicketEffectEnemyCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            LocationThicket thicket = new LocationThicket(enemy);
            AdventurerSingleton hero = AdventurerSingleton.Instance;
            var hpBefore = hero.Health;
            thicket.Effect(hero);
            var hpAfter = hero.Health;
            Assert.AreEqual(hpBefore, hpAfter);
        }
    }
}
