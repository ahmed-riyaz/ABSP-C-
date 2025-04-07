namespace StrategyPattern
{
    /// <summary>
    /// Context class that uses the workout strategy.
    /// This class represents the core component in the Strategy Pattern that
    /// maintains a reference to a strategy object and delegates to it.
    /// </summary>
    public class WorkoutPlanner
    {
        /// <summary>
        /// The current workout strategy being used.
        /// </summary>
        private IWorkoutStrategy _strategy;

        /// <summary>
        /// Constructor that initializes the workout planner with a specific strategy.
        /// </summary>
        /// <param name="strategy">The initial workout strategy to use</param>
        public WorkoutPlanner(IWorkoutStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Method to change the strategy at runtime, demonstrating the key
        /// flexibility feature of the Strategy Pattern.
        /// </summary>
        /// <param name="strategy">The new workout strategy to use</param>
        public void SetWorkoutStrategy(IWorkoutStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Method to execute the current strategy, delegating the actual workout plan
        /// generation to the concrete strategy object.
        /// </summary>
        /// <returns>A string representing the workout plan from the current strategy</returns>
        public string GetWorkoutPlan()
        {
            return _strategy.GetWorkoutPlan();
        }

        /// <summary>
        /// Method to display usage statistics for all strategies,
        /// satisfying the required constraint to show usage counts.
        /// </summary>
        /// <param name="strategies">Dictionary containing strategy names and their instances</param>
        public static void DisplayUsageStatistics(Dictionary<string, IWorkoutStrategy> strategies)
        {
            Console.WriteLine("\n--- Workout Strategy Usage Statistics ---");
            foreach (var strategy in strategies)
            {
                Console.WriteLine($"{strategy.Key}: Used {strategy.Value.UsageCount} times");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
