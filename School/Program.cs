using Infrastucture.StartUp;
namespace School
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

         
           
            builder.Services.AddControllers();
            builder.Services.AddInfrastructureServices(builder.Configuration);
          
            IConfiguration configuration = builder.Configuration;

            var app = builder.Build();

            app.MapControllers();
            app.UseFileServer();
            app.UseRouting();
            app.UseStaticFiles();
          
            app.Run();
        }
    }
}