//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class HumanKnight : AttackUnit
    {
        // Properties
        protected override int Damage()
        {
            DamageRate = 10;

            return DamageRate;
        }
        protected override Race UnitRace => Race.Human;
        protected override float Range => 20;

        // Methods
        public override void Defend(Unit player)
        {
            Defend(player);
            DefenseRate = 6;
        }
    }
}
