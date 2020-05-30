using Microsoft.Extensions.DependencyInjection;
using QuartzCoreDemo.Job;

namespace QuartzCoreDemo
{
    public static class JobExtensions
    {
        public static IServiceCollection SetJobs(this IServiceCollection services)
        {
            // Add our job
            services.AddSingleton<HelloWorldJob>();
            services.AddSingleton(new JobSchedule(
                jobType: typeof(HelloWorldJob),
                cronExpression: "0/5 * * * * ?")); // run every 5 seconds


            return services;
        }
    }
}
