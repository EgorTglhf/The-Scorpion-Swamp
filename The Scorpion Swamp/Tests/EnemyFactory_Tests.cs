using NUnit.Framework;

namespace The_Scorpion_Swamp
{
    [TestFixture]
    internal class EnemyFactory_Tests
    {
        [Test]
        public void EnemyFactoryCreateCheck()
        {
            Enemy enemy = EnemyFactory.CreateEnemy();
            Assert.IsTrue(enemy is Enemy);
        }

        [Test]
        public void EnemyFactoryCreateWolfCheck()
        {
            Enemy enemy = EnemyFactory.CreateWolf();
            Assert.IsTrue(enemy is Enemy);
            Assert.AreEqual("Wolf", enemy.Name);
        }

        [Test]
        public void EnemyFactoryCreateOrcCheck()
        {
            Enemy enemy = EnemyFactory.CreateOrc();
            Assert.IsTrue(enemy is Enemy);
            Assert.AreEqual("Orc", enemy.Name);
        }

        [Test]
        public void EnemyFactoryCreateBanditCheck()
        {
            Enemy enemy = EnemyFactory.CreateBandit();
            Assert.IsTrue(enemy is Enemy);
            Assert.AreEqual("Bandit", enemy.Name);
        }

        [Test]
        public void EnemyFactoryCreateBearCheck()
        {
            Enemy enemy = EnemyFactory.CreateBear();
            Assert.IsTrue(enemy is Enemy);
            Assert.AreEqual("Bear", enemy.Name);
        }

        [Test]
        public void EnemyFactoryCreateMinotaurCheck()
        {
            Enemy enemy = EnemyFactory.CreateMinotaur();
            Assert.IsTrue(enemy is Enemy);
            Assert.AreEqual("Minotaur", enemy.Name);
        }
    }
}
