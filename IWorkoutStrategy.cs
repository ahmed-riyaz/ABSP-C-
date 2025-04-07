namespace StrategyPattern
{
    /// <summary>
    /// Strategy interface that defines the behavior for workout plans.
    /// This is the core interface of the Strategy Pattern implementation,
    /// allowing for interchangeable workout plan behaviors.
    /// </summary>
    public interface IWorkoutStrategy
    {
        /// <summary>
        /// Returns a detailed workout plan as a string.
        /// </summary>
        /// <returns>String representation of the workout plan</returns>
        string GetWorkoutPlan();
        
        /// <summary>
        /// Gets the number of times this strategy has been used.
        /// This property is used to fulfill the required constraint to track usage counts.
        /// </summary>
        int UsageCount { get; }
        
        /// <summary>
        /// Increments the usage counter when the strategy is executed.
        /// </summary>
        void IncrementUsage();
    }
}
