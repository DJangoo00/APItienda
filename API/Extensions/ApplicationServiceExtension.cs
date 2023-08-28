//using AspNetCoreRateLimited;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace API.Extensions;

public static class ApplicationServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder => 
        builder.AllowAnyOrigin()    //WithOrigins("http://domini.com")
                .AllowAnyMethod()   //WithMEthods(GET, POST)
                .AllowAnyHeader()); //WithHeaders(accept, content-type)
    });
}
