namespace CodingChallenges.CalorieCalculator
{
    public enum Sex { Male, Female }
    public enum ActivityLevel {Sedentary, LightlyActive, ModeratelyActive, VeryActive, ExtremelyActive}
    public enum Goal {Lose, Maintain, Gain}
    public class Person
    {
        public Person(int weight, int height, int age, Sex sex, ActivityLevel activityLevel, Goal goal)
        {
            this.Weight = weight;
            this.Height = height;
            this.Age = age;
            this.Sex = sex;
            this.ActivityLevel = activityLevel;
            this.Goal = goal;
        }
       public int Weight { get; set; } 
       public int Height { get; set; }
       public int Age { get; set; }
       public Sex Sex { get; set; }
       public ActivityLevel ActivityLevel { get; set; }
       public Goal Goal { get; set; }

    }
}