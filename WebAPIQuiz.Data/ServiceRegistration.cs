using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIQuiz.Core.Repositories;
using WebAPIQuiz.Data.Repo.Implementation;

namespace WebAPIQuiz.Data;

public static class ServiceRegistration
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBlogRepository, BlogRepository>();
    }
}
