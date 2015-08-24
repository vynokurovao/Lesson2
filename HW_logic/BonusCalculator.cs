using System;

namespace HW_logic
{
    public static class BonusCalculator
    {
        private static double GetBonusCoefByExperienceYears(uint experienceYears)
        {
            if (experienceYears < 5)
            {
                return 0.1;
            }

            if (experienceYears >= 5 && experienceYears < 10)
            {
                return 0.15;
            }

            if (experienceYears >= 10 && experienceYears < 15)
            {
                return 0.25;
            }

            if (experienceYears >= 15 && experienceYears < 20)
            {
                return 0.35;
            }
            
            if (experienceYears >= 20 && experienceYears < 25)
            {
                return 0.45;
            }

            return 0.5;
        }

        public static double CalculateBonus(double salary, uint experienceYears) 
        {
            return salary * GetBonusCoefByExperienceYears(experienceYears);
        }
    }
}
