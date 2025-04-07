namespace StrategyPattern
{
    /// <summary>
    /// Concrete strategy implementation for strength training workouts.
    /// Focuses on resistance exercises to build muscle and increase strength.
    /// </summary>
    public class StrengthTrainingStrategy : IWorkoutStrategy
    {
        /// <summary>
        /// Gets the number of times this strength training strategy has been used.
        /// Initialized to 0 and incremented with each use.
        /// </summary>
        public int UsageCount { get; private set; } = 0;

        /// <summary>
        /// Returns a detailed strength training workout plan.
        /// Automatically increments the usage count when called.
        /// </summary>
        /// <returns>A formatted string containing the strength training plan</returns>
        public string GetWorkoutPlan()
        {
            IncrementUsage();
            return "Strength Training Plan:\n" +
                   "- Bench Press: 3 sets x 8 reps\n" +
                   "- Squats: 4 sets x 6 reps\n" +
                   "- Deadlifts: 3 sets x 6 reps\n" +
                   "- Pull-ups: 3 sets x 10 reps\n" +
                   "- Military Press: 3 sets x 8 reps";
        }

        /// <summary>
        /// Increments the usage counter by 1 each time the strategy is used.
        /// Part of the constraint implementation for tracking strategy usage.
        /// </summary>
        public void IncrementUsage()
        {
            UsageCount++;
        }
    }    /// <summary>
    /// Concrete strategy implementation for cardiovascular training workouts.
    /// Focuses on exercises that elevate heart rate and improve cardiovascular health.
    /// </summary>
    public class CardioStrategy : IWorkoutStrategy
    {
        /// <summary>
        /// Gets the number of times this cardio training strategy has been used.
        /// Initialized to 0 and incremented with each use.
        /// </summary>
        public int UsageCount { get; private set; } = 0;

        /// <summary>
        /// Returns a detailed cardio training workout plan.
        /// Automatically increments the usage count when called.
        /// </summary>
        /// <returns>A formatted string containing the cardio training plan</returns>
        public string GetWorkoutPlan()
        {
            IncrementUsage();
            return "Cardio Training Plan:\n" +
                   "- 5 minutes warm-up jog\n" +
                   "- 20 minutes interval running (30 sec sprint, 60 sec jog)\n" +
                   "- 10 minutes cycling\n" +
                   "- 5 minutes cool down";
        }

        /// <summary>
        /// Increments the usage counter by 1 each time the strategy is used.
        /// Part of the constraint implementation for tracking strategy usage.
        /// </summary>
        public void IncrementUsage()
        {
            UsageCount++;
        }
    }    /// <summary>
    /// Concrete strategy implementation for flexibility training workouts.
    /// Focuses on stretching and mobility exercises to improve range of motion and prevent injury.
    /// </summary>
    public class FlexibilityStrategy : IWorkoutStrategy
    {
        /// <summary>
        /// Gets the number of times this flexibility training strategy has been used.
        /// Initialized to 0 and incremented with each use.
        /// </summary>
        public int UsageCount { get; private set; } = 0;

        /// <summary>
        /// Returns a detailed flexibility training workout plan.
        /// Automatically increments the usage count when called.
        /// </summary>
        /// <returns>A formatted string containing the flexibility training plan</returns>
        public string GetWorkoutPlan()
        {
            IncrementUsage();
            return "Flexibility Training Plan:\n" +
                   "- Dynamic stretching: 5 minutes\n" +
                   "- Yoga sequence: 20 minutes\n" +
                   "- Static stretching: 10 minutes\n" +
                   "- Foam rolling: 5 minutes";
        }

        /// <summary>
        /// Increments the usage counter by 1 each time the strategy is used.
        /// Part of the constraint implementation for tracking strategy usage.
        /// </summary>
        public void IncrementUsage()
        {
            UsageCount++;
        }
    }
}
