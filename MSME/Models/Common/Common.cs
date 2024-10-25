namespace MSME.Models.Common
{
    public class Common
    {

    }

    public class MapPath
    {
        public static string? Path = new ConfigurationBuilder().AddJsonFile($"appsettings.json").Build().GetSection("Path").Value;
    }
}
