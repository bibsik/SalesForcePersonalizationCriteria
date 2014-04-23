SalesForcePersonalizationCriteria
=================================
Sitefinity allows you to add any custom criteria for grouping users into user segments.
This is an example of how you can add a criteria for evaluating is a lead is hot/warm/cold.
Add the SalesForce folder to the root of your project and merge the Global.asax files.

Under SalesForceRatingEvaluator.IsMatch() is where you actually evaluate if the current user matches the criteria or not. Here you can execute any logic, call any services and compare the results with the settings for the user segment.