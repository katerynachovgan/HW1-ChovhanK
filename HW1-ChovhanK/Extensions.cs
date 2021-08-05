using Interfaces;
using Services;
using Microsoft.Extensions.DependencyInjection;

namespace HW1_ChovhanK
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IAddContent, AddContent>();
            services.AddSingleton<ISaveArticleInfo, SaveArticleInfo>();
            services.AddTransient<ICheckArticle, CheckArticle>();
            services.AddSingleton<IPublishArticle, PublishArticle>();


            return services;
        }
    }
}
