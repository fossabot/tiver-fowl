﻿namespace Tiver.Fowl.WebDriverExtended.Configuration
{
    using System.Configuration;
    using Contracts.Configuration;

    public class BrowserConfigurationSection : ConfigurationSection, IBrowserConfiguration
    {
        public IResolution Resolution
        {
            get
            {
                return this.ResolutionElement;
            }
        }

        public string BrowserType
        {
            get
            {
                return this.BrowserTypeElement;
            }
        }

        [ConfigurationProperty("resolution", IsRequired = false)]
        private ResolutionElement ResolutionElement
        {
            get
            {
                return (ResolutionElement)this["resolution"];
            }

            set
            {
                this["resolution"] = value;
            }
        }

        [ConfigurationProperty("browserType", DefaultValue = null, IsRequired = false)]
        private string BrowserTypeElement
        {
            get
            {
                return (string)this["browserType"];
            }

            set
            {
                this["browserType"] = value;
            }
        }
    }
}
