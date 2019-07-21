using Microsoft.Extensions.DependencyInjection;
using Snippet.Demo;
using Snippet.Demo.PartialClass;

public static class SnippetExtention
{
    public static IServiceCollection AddSnippetService(this IServiceCollection serviceCollection) {
        serviceCollection.AddScoped<PartClass>();
        serviceCollection.AddScoped<ChildFunction>();
        return serviceCollection;
    }
}
