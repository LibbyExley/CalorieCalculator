namespace CodingChallenges.CalorieCalculator
{
    public class Calculator
    {
        private readonly Person _person;

        public Calculator(Person person)
        {
            this._person = person;
        }
        private double CalculateMaleBMR()
        {
            return 66.47 + (6.24 * _person.Weight) + (12.7 * _person.Height) - (6.755 * _person.Age);
        }
        private double CalculateFemaleBMR()
        {
            return 655.1 + (4.35 * _person.Weight) + (4.7 * _person.Height) - (4.7 * _person.Age);
        }
        public double CalculateTDEE()
        {
            var bmr = GetBMR();

            switch (_person.ActivityLevel)
            {
                case ActivityLevel.Sedentary:
                    return bmr * 1.2;
                case ActivityLevel.LightlyActive:
                    return bmr * 1.375;
                case ActivityLevel.ModeratelyActive:
                    return bmr * 1.55;
                case ActivityLevel.ExtremelyActive:
                    return bmr * 1.725;
                case ActivityLevel.VeryActive:
                    return bmr * 1.9;
                default:
                    return bmr;
            }
        }

        private double GetBMR()
        {
            double bmr;
            if (_person.Sex == Sex.Female)
            {
                bmr = CalculateFemaleBMR();
            }
            else
            {
                bmr = CalculateMaleBMR();
            }

            return bmr;
        }

        public double GetCalories()
        {
            if (_person.Goal == Goal.Lose)
            {
                return CalculateTDEE() - 500;
            }
            else if (_person.Goal == Goal.Gain)
            {
                return CalculateTDEE() + 500;
            }
            else
            {
                return CalculateTDEE();
            }
        }

    }
}