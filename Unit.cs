namespace Brezerkers
{
    // Enum of the race
    public enum Race
    {
        Human,
        Orc,
        Elf
    }

    public abstract class Unit
    {
        // Properties
        protected abstract int Damage { get;}
        protected abstract int HP { get;}
        protected abstract Race UnitRace { get; }

        // Methods
        public abstract void Attack(Unit target);
        public abstract void Defend(Unit attacker);
    }
}
