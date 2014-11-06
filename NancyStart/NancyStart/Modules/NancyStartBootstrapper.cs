using System.Text;
using Nancy;

using Nancy.Bootstrappers.StructureMap;

namespace NancyStart.Modules
{
    public class NancyStartBootstrapper : StructureMapNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(StructureMap.IContainer existingContainer)
        {
            StructureMapContainer.Configure(existingContainer);
        }

        protected override void ApplicationStartup(StructureMap.IContainer container, Nancy.Bootstrapper.IPipelines pipelines)
        {
            pipelines.OnError.AddItemToStartOfPipeline((ctxt, error) =>
            {
                if (error is CarNotFoundException)
                    return new Response
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ContentType = "text/html",
                        Contents = (stream) =>
                        {
                            var errorMsg = Encoding.UTF8.GetBytes(error.Message);
                            stream.Write(errorMsg, 0, errorMsg.Length);
                        }
                    };
                return HttpStatusCode.InternalServerError;
            });

        }
    }
}