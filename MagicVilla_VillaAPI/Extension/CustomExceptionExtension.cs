using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;

namespace MagicVilla_VillaAPI.Extension
{
    public static class CustomExceptionExtension
    {
        public static void HandelError(this IApplicationBuilder app, bool isDevelopment)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";
                    var feature = context.Features.Get<IExceptionHandlerFeature>();
                    if (feature != null)
                    {
                        if (isDevelopment)
                        {
                            if (feature.Error is BadImageFormatException badImageFormatException)
                            {
                                await context.Response.WriteAsync(JsonConvert.SerializeObject(new
                                {
                                    // If you had custom exeption where you are passing status code then you can pass here
                                    StatusCode = 776,
                                    ErrorMessage = "Hello From Custom Handler! Image Format is invalid"
                                }));
                            }
                            else
                            {
                                await context.Response.WriteAsync(JsonConvert.SerializeObject(new
                                {
                                    Statuscode = context.Response.StatusCode,
                                    ErrorMessage = feature.Error.Message,
                                    Stacktrace = feature.Error.StackTrace
                                }));
                            }
                        }
                        else
                        {
                            await context.Response.WriteAsync(JsonConvert.SerializeObject(new
                            {
                                Statuscode = context.Response.StatusCode,
                                ErrorMessage = "Hello From Program.cs Exception Handler"
                            }));
                        }
                    }
                });
            });
        }
    }
}
