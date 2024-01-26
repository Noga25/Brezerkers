//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class OrcWarrior : AttackUnit
    {
        Race race = Race.Orc;

        // Properties
        protected override float Range => 10;
        protected override int Damage()
        {
            DamageRate = 10;

            return DamageRate;
        }
        protected override Race UnitRace => Race.Orc;

        // Methods
        public override void Defend(Unit player)
        {
            Defend(player);
            DefenseRate = 4;
        }
    }
}
