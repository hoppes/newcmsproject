// this is used to get the correct url for redirects.
// <a href = "@(EnvironmentVariables.getFrontEndURL(Request.ServerVariables["server_name"]))/@(page.FullUrl)@page.URL" target="_blank">@page.FullUrl @page.URL</a>

namespace Veridian.Web.NewCMSProject.Utilities
{
    public static class EnvironmentVariables
    {
        private static string getEnviornment(string url)
        {
            // backup
            if (url.Contains("veridiancms2"))
            {
                return "Backup";
            }
            // dev
            else if (url.Contains("devveridiancms"))
            {
                return "Dev";
            }
            // live
            else if (url.Contains("veridiancms"))
            {
                return "Live";
            }
            // assume localhost
            else
            {
                return "Localhost";
            }
        }

        public static string getFrontEndURL(string url)
        {
            switch (getEnviornment(url))
            {
                case "Live":
                    return System.Configuration.ConfigurationManager.AppSettings["FrontEndURL"];
                case "Backup":
                    return System.Configuration.ConfigurationManager.AppSettings["FrontEndURLBackup"];
                case "Dev":
                    return System.Configuration.ConfigurationManager.AppSettings["FrontEndURLDev"];
                case "Localhost":
                default:
                    return System.Configuration.ConfigurationManager.AppSettings["FrontEndURLDev"];
            }
        }
    }
}