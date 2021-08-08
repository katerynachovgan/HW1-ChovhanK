using Interfaces;
using Services;
using Microsoft.Extensions.DependencyInjection;

namespace HW1_ChovhanK
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IArticleInfo, ArticleInfo>();
            services.AddScoped<IAddContent, AddContent>();
            services.AddTransient<ICheckArticle, CheckArticle>();
            services.AddScoped<IPublishArticle, PublishArticle>();
            services.AddScoped<AllProcessess>();

            return services;
        }
    }
}
