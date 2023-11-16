using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace The_Scorpion_Swamp
{
    [TestFixture]
    internal class AdventurerSingleton_Tests
    {
        [Test]
        public void AdventurerAttributesCheck()
        {
            AdventurerSingleton Hero = AdventurerSingleton.Instance;
            Assert.AreEqual("The Adventurer", Hero.Name);
            Assert.GreaterOrEqual(Hero.Dexterity, 6);
            Assert.LessOrEqual(Hero.Dexterity, 11);
            Assert.GreaterOrEqual(Hero.Health, 14);
            Assert.LessOrEqual(Hero.Health, 24);
        }
        [Test]
        public void AdventurerDeleteAndGetInstanceCheck()
        {
            AdventurerSingleton Hero = AdventurerSingleton.Instance;
            AdventurerSingleton.DeleteInstance();
            Hero = AdventurerSingleton.Instance;
            Assert.IsInstanceOf<AdventurerSingleton>(Hero);
        }

        [Test]
        public void AdventurerGetDamageCheck()
        {
            AdventurerSingleton Hero = AdventurerSingleton.Instance;
            var fullHealth = Hero.Health;
            Hero.GetDamage(10);
            Assert.AreEqual(fullHealth - 10, Hero.Health);
        }
        [Test]
        public void AdventurerGetHealCheck()
        {
            AdventurerSingleton Hero = AdventurerSingleton.Instance;
            var fullHealth = Hero.Health;
            Hero.GetHeal(10);
            Assert.AreEqual(fullHealth + 10, Hero.Health);
        }
        [Test]
        public void AdventurerAttackThemselfCheck()
        {
            AdventurerSingleton Hero = AdventurerSingleton.Instance;
            var fullHealth = Hero.Health;
            Hero.Attack(Hero);
            Assert.AreEqual(fullHealth - Hero.AttackDamage, Hero.Health);
        }
    }
}
