using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Activities;
using Application.Core;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
     public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config) {
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<DataContext>(options => {
            options.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });
        services.AddCors(options => {
            options.AddPolicy("CorsPolicy", policy => {
            policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5174");
        });
        });
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(List.Handler).Assembly));
        services.AddAutoMapper(typeof(MappingProfile).Assembly);

        return services;
     } 
    }
}