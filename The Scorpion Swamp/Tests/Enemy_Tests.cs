using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Scorpion_Swamp
{
    [TestFixture]
    internal class Enemy_Tests
    {
        [Test]
        public void EnemyAttributesCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            Assert.AreEqual("Enemy", enemy.Name);
            Assert.AreEqual(enemy.AttackDamage, 2);
            Assert.AreEqual(enemy.Dexterity, 2);
            Assert.AreEqual(enemy.Health, 10);
        }

        [Test]
        public void EnemyGetDamageCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            var fullHealth = enemy.Health;
            enemy.GetDamage(5);
            Assert.AreEqual(fullHealth - 5, enemy.Health);
        }
        [Test]
        public void EnemyGetHealCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            var fullHealth = enemy.Health;
            enemy.GetHeal(10);
            Assert.AreEqual(fullHealth + 10, enemy.Health);
        }
        [Test]
        public void EnemyAttackThemselfCheck()
        {
            Enemy enemy = new Enemy("Enemy", 10, 2, 2);
            var fullHealth = enemy.Health;
            enemy.Attack(enemy);
            Assert.AreEqual(fullHealth - enemy.AttackDamage, enemy.Health);
        }
    }
}
