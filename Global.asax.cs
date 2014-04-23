using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Personalization;
using Telerik.Microsoft.Practices.Unity;
using Telerik.Sitefinity.Personalization.Impl.Configuration;
using Telerik.Sitefinity.Personalization.Impl.Evaluators;
using Telerik.Sitefinity.Personalization.Impl;
using Telerik.Sitefinity.Security.Web.UI.Principals;
using SitefinityWebApp.MyControls;
using Telerik.Sitefinity.Web.UI;
using SitefinityWebApp.App_Start;
using System.Web.Optimization;
using Telerik.Sitefinity.Localization;
using SitefinityWebApp.SalesForce.Personalization;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Abstractions.VirtualPath.Configuration;


namespace SitefinityWebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Bootstrapper.Initialized += Bootstrapper_Initialized;
        }

        private readonly string criteriaName = "LeadRating";
        private readonly string virtualPath = "~/SFCustomPersonalization/";

        void Bootstrapper_Initialized(object sender, Telerik.Sitefinity.Data.ExecutedEventArgs e)
        {
            //Register the resource file
            Res.RegisterResource<CustomPersonalizationResources>();

            //Add a virtual path for the embedded resources (the editors)
            var virtualPathConfig = Config.Get<VirtualPathSettingsConfig>();
            if (!virtualPathConfig.VirtualPaths.Contains(virtualPath + "*"))
            {
                var pathConfig = new VirtualPathElement(virtualPathConfig.VirtualPaths)
                {
                    VirtualPath = virtualPath + "*",
                    ResolverName = "EmbeddedResourceResolver",
                    ResourceLocation = "SitefinityWebApp"
                };
                virtualPathConfig.VirtualPaths.Add(pathConfig);

            }

            //Create the criteria
            var personalizationConfig = Config.Get<PersonalizationConfig>();
            if (!personalizationConfig.Criteria.Contains(criteriaName))
            {


                CriterionElement rolesCriterion = new CriterionElement(personalizationConfig.Criteria)
                {
                    Name = criteriaName,
                    Title = criteriaName,
                    ResourceClassId = typeof(CustomPersonalizationResources).Name,
                    CriterionEditorUrl = "SitefinityWebApp.SalesForce.Personalization.SalesForceRatingEditor.ascx",
                    ConsoleCriterionEditorUrl = "SitefinityWebApp.SalesForce.Personalization.SalesForceRatingEditor.ascx",
                    CriterionVirtualPathPrefix = virtualPath
                };
                personalizationConfig.Criteria.Add(rolesCriterion);
            }

            //Register the evaluator for the criteria
            ObjectFactory.Container.RegisterType(
                typeof(ICriterionEvaluator),
                typeof(SalesForceRatingEvaluator),
                criteriaName,
                new ContainerControlledLifetimeManager(),
                new InjectionConstructor());
        }
        
    }
}