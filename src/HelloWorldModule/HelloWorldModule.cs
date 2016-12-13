// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.Diagnostics;
using System.Linq;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace HelloWorldModule
{
    public class HelloWorldModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;
        private readonly IRegionManager regionManager;

        public HelloWorldModule(IRegionViewRegistry registry, IRegionManager regionManager)
        {
            this.regionViewRegistry = registry;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.HelloWorldView));

            //MahApps.Metro 1.2.4.0 = region count = 1, ButtonRegion is not in region manager
            //MahApps.Metro 1.3.0.0 = region count = 2, ButtonRegion IS in region manager
            Debug.WriteLine(regionManager.Regions.Count());
            foreach (var region in regionManager.Regions)
            {
                Debug.WriteLine(region.Name);
            }

        }
    }
}
