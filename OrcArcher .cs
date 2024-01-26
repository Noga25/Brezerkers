//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class OrcWarrior : AttackUnit
    {
        // Properties
        protected override float Range => 10;
        protected override Race UnitRace => Race.Orc;

        protected override int Damage()
        {
            DamageRate = 10;

            return DamageRate;
        }

        // Methods
        public override void Defend(Unit player)
        {
            Defend(player);
            DefenseRate = 4;
        }
    }
}
