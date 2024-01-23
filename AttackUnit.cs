//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public abstract class AttackUnit : RangedUnit
    {
        public override void Attack(Unit target, int targetDistance)
        {
            targetDistance = 43;

            if (CheckRange(target, targetDistance) == false) return;

            if (CheckRange(target, targetDistance) == true)
            {
                Console.WriteLine(target + "As been attacked");

                if (HP() > 0) { Damage(); }

                else if (HP() == 0) { return; }
            }
        }
    }
}
