//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class HumanKnight : RangedUnit
    {
        // Properties
        protected override int Damage => 10;
        protected override int HP => 100;
        protected override Race UnitRace => Race.Human;
        protected override float Range => 20;

        // Methods
        public override void Defend(Unit attacker)
        {
            // Implementation for defending
        }
    }
}
