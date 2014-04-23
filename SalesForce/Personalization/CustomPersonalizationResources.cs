using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Localization;
namespace SitefinityWebApp.SalesForce.Personalization
{
    [ObjectInfo(typeof(CustomPersonalizationResources), Title = "CustomPersonalizationResourcesTitle", Description = "CustomPersonalizationResourcesDescription")]
    public class CustomPersonalizationResources : Resource
    {
        public CustomPersonalizationResources()
        {
        }

        //public CustomPersonalizationResources(ResourceDataProvider dataProvider)
        //    : base(dataProvider)
        //{
        //}

        [ResourceEntry("CustomPersonalizationResourcesTitle",
    Value = "Personalization Custom",
    Description = "Custom Personalization",
    LastModified = "2013/06/30")]
        public string ProductsResourcesTitle
        {
            get { return this["CustomPersonalizationResourcesTitle"]; }
        }

        [ResourceEntry("CustomPersonalizationResourcesDescription",
    Value = "Contains localizable resources for custom personalization.",
    Description = "Contains localizable resources for custom personalization.",
    LastModified = "2013/06/30")]
        public string ProductsResourcesDescription
        {
            get { return this["CustomPersonalizationResourcesDescription"]; }
        }

        [ResourceEntry("LeadRating",
            Value = "Lead Rating",
            Description = "The rating of the SalesForce lead",
            LastModified = "2013/06/30")]
        public string LeadRating
        {
            get { return this["LeadRating"]; }
        }

        [ResourceEntry("Cold",
    Value = "Cold",
    Description = "Custom Personalization",
    LastModified = "2013/06/30")]
        public string Cold
        {
            get { return this["Cold"]; }
        }
        [ResourceEntry("Warm",
    Value = "Warm",
    Description = "Custom Personalization",
    LastModified = "2013/06/30")]
        public string Warm
        {
            get { return this["Warm"]; }
        }
        [ResourceEntry("Hot",
    Value = "Hot",
    Description = "Custom Personalization",
    LastModified = "2013/06/30")]
        public string Hot
        {
            get { return this["Hot"]; }
        }
    }
}