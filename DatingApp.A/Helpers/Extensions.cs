using System;
using Microsoft.AspNetCore.Http;

namespace DatingApp.A.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response,string message)
        {
            response.Headers.Add("Application-Error",message);
            response.Headers.Add("Access-Control-Expose-Headers","Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin","*");
        }
        public static int CalculateAge(this DateTime theDate)
        {
            var age=DateTime.Today.Year-theDate.Year;
            if(theDate.AddYears(age)>DateTime.Today)
                age--;
            return age;
        }
    }
}