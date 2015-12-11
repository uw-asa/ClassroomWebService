using System.Web.Http;
using Microsoft.Restier.WebApi;
using Microsoft.Restier.WebApi.Batch;
using ClassroomWebService.Models;

namespace ClassroomWebService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            RegisterClassroom(config, GlobalConfiguration.DefaultServer);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static async void RegisterClassroom(HttpConfiguration config, HttpServer server)
        {
            await config.MapRestierRoute<ClassroomApi>(
               "ClassroomApi", "api/Classroom",
                new RestierBatchHandler(server));
        }
    }
}
