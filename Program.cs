using StrategyPattern;

// Create the concrete strategy objects
var strengthStrategy = new StrengthTrainingStrategy();
var cardioStrategy = new CardioStrategy();
var flexibilityStrategy = new FlexibilityStrategy();

// Store strategies in a dictionary for easy access and usage tracking
Dictionary<string, IWorkoutStrategy> strategies = new Dictionary<string, IWorkoutStrategy>
{
    { "Strength Training", strengthStrategy },
    { "Cardio Training", cardioStrategy },
    { "Flexibility Training", flexibilityStrategy }
};

// Create the context with an initial strategy
WorkoutPlanner workoutPlanner = new WorkoutPlanner(strengthStrategy);

Console.WriteLine("==== FITNESS WORKOUT PLANNER ====");
Console.WriteLine("Using the Strategy Pattern to provide different workout plans");
Console.WriteLine("Constraint: Must show usage count for each strategy");

// First workout plan - strength training
Console.WriteLine("\n[DAY 1] Your workout plan:");
Console.WriteLine(workoutPlanner.GetWorkoutPlan());

// Switch to cardio strategy
Console.WriteLine("\n[DAY 2] Switching to Cardio Training:");
workoutPlanner.SetWorkoutStrategy(cardioStrategy);
Console.WriteLine(workoutPlanner.GetWorkoutPlan());

// Switch to flexibility strategy
Console.WriteLine("\n[DAY 3] Switching to Flexibility Training:");
workoutPlanner.SetWorkoutStrategy(flexibilityStrategy);
Console.WriteLine(workoutPlanner.GetWorkoutPlan());

// Switch back to strength training for a second session
Console.WriteLine("\n[DAY 4] Back to Strength Training:");
workoutPlanner.SetWorkoutStrategy(strengthStrategy);
Console.WriteLine(workoutPlanner.GetWorkoutPlan());

// Switch back to cardio for a second session
Console.WriteLine("\n[DAY 5] Back to Cardio Training:");
workoutPlanner.SetWorkoutStrategy(cardioStrategy);
Console.WriteLine(workoutPlanner.GetWorkoutPlan());

// Display the usage statistics for each strategy (satisfying the constraint)
WorkoutPlanner.DisplayUsageStatistics(strategies);

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
