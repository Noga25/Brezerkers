namespace Brezerkers
{
    public abstract class RangedUnit : Unit
    {
        //Propetie who set the range
        protected abstract float Range { get; }

        // Method to ranged attacks
        public override void Attack(Unit target)
        {
            // Implementation for ranged attack
        }
    }
}
