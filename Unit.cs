//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

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
        //Varibales
        protected int Lifes;
        protected int DefenseRate;
        protected int DamageRate;

        // Properties
        protected virtual int Damage()
        {
            DefenseRate = 0;

            DamageRate -= DefenseRate;

            return DamageRate;
        }

        protected virtual int HP()
        {
            Lifes = 100;

            if(Lifes <= 0)
                Lifes = 0;

            return Lifes;
        }
        protected virtual Race UnitRace { get; }

        // Methods
        public abstract void Attack(Unit target, int targetDistance);
        public abstract void Defend(Unit player);
    }
}
