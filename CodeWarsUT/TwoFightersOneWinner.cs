using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;

namespace CodeWarsUT
{
    [TestClass]
    public class TwoFightersOneWinner
    {
        private string Tester(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
           return CodeWars.TwoFightersOneWinner.declareWinner(fighter1, fighter2, firstAttacker);           
        }        

        [TestMethod]
        public void Should_return_the_winner()
        {
            Assert.AreEqual("Lew", Tester(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew"));
            Assert.AreEqual("Harry", Tester(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Harry"));
            Assert.AreEqual("Harald", Tester(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry"));
            Assert.AreEqual("Harald", Tester(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald"));
            Assert.AreEqual("Harald", Tester(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"));
            Assert.AreEqual("Harald", Tester(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Harald"));
        }

        [TestMethod]
        public void Should_return_the_fighter_is_alive()
        {
            Fighter fighter = new Fighter("Test", 10, 2);
            Assert.IsTrue(CodeWars.TwoFightersOneWinner.IsFighterAlive(fighter));
        }
        [TestMethod]
        public void Should_return_the_fighter_is_dead()
        {
            Fighter fighter = new Fighter("Test", -10, 2);
            Assert.IsFalse(CodeWars.TwoFightersOneWinner.IsFighterAlive(fighter));
        }
        [TestMethod]
        public void Should_return_the_battle_is_alive()
        {
            Fighter fighter1 = new Fighter("Test1", 10, 2);
            Fighter fighter2 = new Fighter("Test2", 10, 2);
            Assert.IsTrue(CodeWars.TwoFightersOneWinner.IsBattleAliveBetween(fighter1, fighter2));
        }
        [TestMethod]
        public void Should_return_the_battle_is_finished()
        {
            Fighter fighter1 = new Fighter("Test1", 10, 2);
            Fighter fighter2 = new Fighter("Test2", -10, 2);
            Assert.IsFalse(CodeWars.TwoFightersOneWinner.IsBattleAliveBetween(fighter1, fighter2));
        }
        [TestMethod]
        public void Should_return_fighter_one()
        {
            Fighter fighter1 = new Fighter("Test1", 10, 2);
            Fighter fighter2 = new Fighter("Test2", -10, 2);
            Assert.AreEqual(fighter1, CodeWars.TwoFightersOneWinner.GetAttackerOne(fighter1, fighter2, "Test1"));
        }
        [TestMethod]
        public void Should_return_fighter_two()
        {
            Fighter fighter1 = new Fighter("Test1", 10, 2);
            Fighter fighter2 = new Fighter("Test2", -10, 2);
            Assert.AreEqual(fighter2, CodeWars.TwoFightersOneWinner.GetAttackerTwo(fighter1, fighter2, fighter1));
        }
        [TestMethod]
        public void Should_return_fighter_with_less_health()
        {
            Fighter fighter1 = new Fighter("Test1", 10, 2);
            Fighter fighter2 = new Fighter("Test2", 5, 2);
            CodeWars.TwoFightersOneWinner.Attack(fighter1, fighter2);
            Assert.IsTrue(fighter2.Health == 3);
        }

    }
}
