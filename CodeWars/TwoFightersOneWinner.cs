using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeWars
{
    public class TwoFightersOneWinner
    {
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            if (fighter1 == null || fighter2 == null || firstAttacker.Equals(string.Empty))
                return string.Empty;

            Fighter attackerOne = GetAttackerOne(fighter1, fighter2, firstAttacker);
            Fighter attackerTwo = GetAttackerTwo(fighter1, fighter2, attackerOne);

            while (IsBattleAliveBetween(attackerOne, attackerTwo))
            {
                //Attack(attackerOne, attackerTwo);
                attackerOne.AttacksTo(attackerTwo);
                Debug.WriteLine(attackerOne.Name + " attacks to " + attackerTwo.Name + ". " + attackerTwo.Name + " has " + attackerTwo.Health + "health");
                if (!IsFighterAlive(attackerTwo))
                    return attackerOne.Name;
                //Attack(attackerTwo, attackerOne);
                attackerTwo.AttacksTo(attackerOne);
                Debug.WriteLine(attackerTwo.Name + " attacks to " + attackerOne.Name + ". " + attackerOne.Name + " has " + attackerOne.Health + "health");
                if (!IsFighterAlive(attackerOne))
                    return attackerTwo.Name;
            }
            return string.Empty;


            //BEST FROM CODEWARS
            //var fighters = new[] { fighter1, fighter2 };

            //var Attacker = fighters.Single(f => f.Name == firstAttacker);
            //var Defender = fighters.Single(f => f.Name != firstAttacker);
            //Defender.Health -= Attacker.DamagePerAttack;
            //if (Defender.Health <= 0)
            //{
            //    return Attacker.Name;
            //}
            //return declareWinner(fighter1, fighter2, Defender.Name);

        }

        public static bool IsFighterAlive(Fighter attacker)
        {
            return attacker.Health <= 0 ? false : true;
        }
        public static bool IsBattleAliveBetween(Fighter attackerOne, Fighter attackerTwo)
        {
            return (attackerOne.Health > 0 && attackerTwo.Health > 0) ? true : false;
        }
        public static Fighter GetAttackerOne(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            return fighter1.Name.Equals(firstAttacker) ? fighter1 : fighter2;
        }
        public static Fighter GetAttackerTwo(Fighter fighter1, Fighter fighter2, Fighter attackerOne)
        {
            return fighter1.Name.Equals(attackerOne.Name) ? fighter2 : fighter1;
        }
        public static void Attack(Fighter fighter1, Fighter fighter2)
        {
            fighter2.Health -= fighter1.DamagePerAttack;
        }
    }

 
}
