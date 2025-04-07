# Adaptive Behavior via Strategy Pattern

## Project Overview
This project demonstrates the implementation of the Strategy Pattern in a Fitness domain for a workout planning system. The Strategy Pattern allows for interchangeable behaviors at runtime, making the system adaptable to different requirements without changing the core implementation.

## Domain Information
- **Domain**: Fitness
- **Behavior Type**: Workout plan
- **Required Constraint**: Must show usage count for each strategy

## Strategy Pattern Implementation

### Components

#### 1. Strategy Interface (`IWorkoutStrategy.cs`)
Defines the contract that all concrete workout strategies must implement:
- `GetWorkoutPlan()`: Returns the workout plan as a string
- `UsageCount`: Property to track how many times the strategy has been used
- `IncrementUsage()`: Method to increment the usage counter

#### 2. Concrete Strategies (`WorkoutStrategies.cs`)
Three different workout plan implementations:
- **Strength Training**: Focuses on resistance exercises like bench press, squats, deadlifts
- **Cardio Training**: Focuses on cardiovascular exercises like running and cycling
- **Flexibility Training**: Focuses on stretching and mobility exercises

#### 3. Context Class (`WorkoutPlanner.cs`)
The `WorkoutPlanner` class maintains a reference to the current strategy and delegates workout plan generation to that strategy. It allows:
- Setting a different strategy at runtime
- Executing the current strategy
- Displaying usage statistics for all available strategies

#### 4. Client Code (`Program.cs`)
Demonstrates the use of the Strategy Pattern by:
- Creating different workout strategies
- Switching between strategies at runtime
- Displaying the usage count for each strategy

## Constraint Implementation
The required constraint "Must show usage count for each strategy" is implemented by:
1. Adding a `UsageCount` property to the `IWorkoutStrategy` interface
2. Incrementing this counter each time a strategy is used via the `IncrementUsage()` method
3. Providing a static `DisplayUsageStatistics()` method in the `WorkoutPlanner` class that shows how many times each strategy has been used

## How to Run
1. Open the solution in Visual Studio or your preferred C# IDE
2. Build the solution
3. Run the Program.cs file
4. Observe the different workout plans generated and the usage statistics at the end

## Benefits of the Strategy Pattern in This Implementation
- **Flexibility**: Can easily add new workout plans without changing existing code
- **Maintainability**: Each workout strategy is encapsulated in its own class
- **Runtime Adaptability**: Can switch between different workout strategies at runtime
- **Single Responsibility**: Each class has a single responsibility - either managing strategies or implementing a specific workout plan
- **Open/Closed Principle**: The system is open for extension (new strategies) but closed for modification

## UML Class Diagram
```
┌───────────────────┐      ┌─────────────────────────┐
│ WorkoutPlanner    │      │ «interface»             │
├───────────────────┤      │ IWorkoutStrategy        │
│ -_strategy        │───-->│                         │
├───────────────────┤      ├─────────────────────────┤
│ +SetWorkoutStrategy│      │ +GetWorkoutPlan()      │
│ +GetWorkoutPlan()  │      │ +UsageCount            │
│ +DisplayUsageStats │      │ +IncrementUsage()      │
└───────────────────┘      └─────────────────────────┘
                                       ▲
                                       │
                 ┌─────────────────────┼─────────────────────┐
                 │                     │                     │
    ┌────────────────────┐  ┌────────────────────┐  ┌────────────────────┐
    │StrengthTraining    │  │CardioStrategy      │  │FlexibilityStrategy │
    │Strategy            │  │                    │  │                    │
    ├────────────────────┤  ├────────────────────┤  ├────────────────────┤
    │-UsageCount         │  │-UsageCount         │  │-UsageCount         │
    ├────────────────────┤  ├────────────────────┤  ├────────────────────┤
    │+GetWorkoutPlan()   │  │+GetWorkoutPlan()   │  │+GetWorkoutPlan()   │
    │+IncrementUsage()   │  │+IncrementUsage()   │  │+IncrementUsage()   │
    └────────────────────┘  └────────────────────┘  └────────────────────┘
```
