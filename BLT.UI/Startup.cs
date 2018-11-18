using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLT.Service.Implementation;
using BLT.Service.Interface;
using BLT.Service.MockImplementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLT.UI
{
    public class Startup
    {

        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IFeatureServices, MockFeatureServices>();
            services.AddScoped<IProjectServices, MockProjectServices>();
            services.AddScoped<IScenarioServices, MockScenarioServices>();
            services.AddScoped<IStepServicesCRUD, MockStepServiceCRUD>();
            services.AddScoped<IStepServiceNavigable, ComponentStepService>();
            services.AddScoped<IStepServicePresentable, ComponentStepService>();
            services.AddScoped<IStepServiceQueryable, SelectorStepService>();
            services.AddScoped<IStepServiceSelectable, SelectorStepService>();


            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
