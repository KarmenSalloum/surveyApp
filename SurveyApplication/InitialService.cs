using Microsoft.Extensions.DependencyInjection;
using SurveyApplication.Services.Contract;
using SurveyApplication.Services.ContractImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication
{
    public static class InitialService
    {
        public static void AddMyServices(this IServiceCollection services)
        {
            services.AddTransient<IPersonBus, PersonBus>();
        }
    }
}
