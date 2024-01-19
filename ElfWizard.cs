//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class ElfWizard : RangedUnit
    {
        // Properties
        protected override float Range => 40;

        protected override int Damage => 10;

        protected override int HP => 140;

        protected override Race UnitRace => Race.Elf;

        // Methods
        public override void Defend(Unit attacker)
        {
            //Implementation for defending
        }
    }
}
