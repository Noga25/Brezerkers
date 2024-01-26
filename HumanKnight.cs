//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class HumanKnight : AttackUnit
    {
        // Properties
        protected override float Range => 20;
        protected override Race UnitRace => Race.Human;

        protected override int Damage()
        {
            DamageRate = 10;

            return DamageRate;
        }

        // Methods
        public override void Defend(Unit player)
        {
            Defend(player);
            DefenseRate = 6;
        }
    }
}
