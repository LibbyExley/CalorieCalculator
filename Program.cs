using System;
using CodingChallenges.CalorieCalculator;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(180, 71, 26, Sex.Male, ActivityLevel.ModeratelyActive, Goal.Lose);

            var calculator = new Calculator(person);

            var calories = calculator.GetCalories();

            Console.WriteLine(calories);
        }
    }
}
