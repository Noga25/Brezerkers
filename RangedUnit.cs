//----c# II (Dor Ben Dor) ----
//       Noga Levkovitz
//---------------------------

namespace Brezerkers
{
    public abstract class RangedUnit : Unit
    {
        //Propetie who set the range / has defult range
        protected virtual float Range { get; } = 10;

        public virtual bool CheckRange(Unit target, int TargetDistance)
        {
            if(TargetDistance <= Range)
            {
                return true;
            }

            return false;
        }
    }
}
