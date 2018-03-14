
namespace Alphacert.Acc.Ods.Api
{
    public class AppConfig
    {
        public AppSettingsData AppSettings { get; set; }     

    }
    
    public class AppSettingsData
    {
        public string DBConnectionString { get; set; }

        public string DBServer { get; set; }

        public string VirtualDirectory { get; set; }
    }
}
