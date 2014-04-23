using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Personalization;

namespace SitefinityWebApp.SalesForce.Personalization
{
    public class SalesForceRatingEvaluator : ICriterionEvaluator
    {
        public bool IsMatch(string settings, IPersonalizationTestContext testContext)
        {

            string rating = "hot";

            //Get the current user
            //rating = Request the rating of the user from SalesForce
            if(rating.Equals(settings)){
              return true;
            }else{
              return false;
            }
        }
    }
}