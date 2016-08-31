﻿namespace Tiver.Fowl.WebDriverExtended.Browsers
{
    using System.Configuration;
    using Configuration;
    using Contracts.Configuration;
    using Exceptions;

    public abstract class BrowserFactory
    {
        public static BrowserFactory GetFactory(string browserType)
        {
            switch (browserType)
            {
                // default browser type
                case null:
                case "":

                // other specific values
                case "ff":
                case "firefox":
                    return new FirefoxBrowserFactory();

                default:
                    throw new IncorrectBrowserConfigurationException(string.Format("Unsupported browser type: '{0}'.", browserType));
            }
        }

        public static Browser GetBrowser()
        {
            BrowserConfigurationSection config = (BrowserConfigurationSection)ConfigurationManager.GetSection("browserConfigurationGroup/browserConfiguration");
            var factory = GetFactory(config.BrowserType);
            return factory.Build(config);
        }

        public abstract Browser Build(IBrowserConfiguration configuration);
    }
}