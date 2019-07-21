using Microsoft.Extensions.DependencyInjection;

namespace Snippet.Test
{
    public class SnippetTestFixture
    {
        public SnippetTestFixture()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSnippetService();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}
