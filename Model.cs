using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication
{
    public class Model
    {
        public string Age { get; set; }
        public string DistanceFromHome { get; set; }
        public string Education { get; set; }
        public string PercentSalaryHike { get; set; }
        public string TotalWorkingYears { get; set; }
        public string YearsAtCompany { get; set; }
        public string YearsInCurrentRole { get; set; }
        public string YearsSinceLastPromotion { get; set; }
        public string YearsWithCurrManager { get; set; }

        public Model(string age, string distanceFromHome, string education, string percentSalaryHike,
        string totalWorkingYears, string yearsAtCompany, string yearsInCurrentRole, string yearsSinceLastPromotion,
        string yearsWithCurrManager)
        {
            Age = age;
            DistanceFromHome = distanceFromHome;
            Education = education;
            PercentSalaryHike = percentSalaryHike;
            TotalWorkingYears = totalWorkingYears;
            YearsAtCompany = yearsAtCompany;
            YearsInCurrentRole = yearsInCurrentRole;
            YearsSinceLastPromotion = yearsSinceLastPromotion;
            YearsWithCurrManager = yearsWithCurrManager;
        }

    }
}