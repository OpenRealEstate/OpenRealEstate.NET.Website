using System.Threading.Tasks;

namespace OpenRealEstate.WebSite
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Homely.AspNetCore.Hosting.CoreApp.Program.Main<Startup>(args);
        }
    }
}
