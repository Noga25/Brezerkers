//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public sealed class ElfWizard : AttackUnit
    {
        Race race = Race.Elf;

        // Properties
        protected override float Range => 40;

        protected override int Damage()
        {
            DamageRate = 10;

            return DamageRate;
        }

        protected override Race UnitRace => Race.Elf;

        // Methods
        public override void Defend(Unit player)
        {
            Defend(player);
            DefenseRate = 2;
        }
    }
}
