namespace CodeWars
{
    public class Fighter
    {
        public string Name;
        public int Health;
        public int DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            Name = name;
            Health = health;
            DamagePerAttack = damagePerAttack;
        }

        public int AttacksTo(Fighter fighterAttacked)
        {
            return fighterAttacked.Health -= DamagePerAttack;
        }
    }
}