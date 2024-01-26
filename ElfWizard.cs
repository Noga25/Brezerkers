//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class ElfWizard : AttackUnit
    {
        // Properties
        protected override Race UnitRace => Race.Elf;
        protected override float Range => 40;

        protected override int Damage()
        {
            DamageRate = 10;

            return DamageRate;
        }

        // Methods
        public override void Defend(Unit player)
        {
            Defend(player);
            DefenseRate = 2;
        }
    }
}
