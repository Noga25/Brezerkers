//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class OrcWarrior : AttackUnit
    {
        // Properties
        protected override int Damage => 15;
        protected override int HP => 120;
        protected override Race UnitRace => Race.Orc;

        // Methods
        public override void Defend(Unit attacker)
        {
            // Implementation for defending
        }
    }
}
