using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Snippet.Demo;

namespace Snippet.Test
{
    public class OverrideFunctionTest : IClassFixture<SnippetTestFixture>
    {
        private ServiceProvider _serviceProvide;

        public OverrideFunctionTest(SnippetTestFixture snippetTestFixture)
        {
            this._serviceProvide = snippetTestFixture.ServiceProvider;
        }

        [Fact(DisplayName = "测试override")]
        public void OverrideTest()
        {
            ChildFunction childClass = new ChildFunction();
            Assert.Equal("overrideVirtual", childClass.Virtual());

            BaseClass baseChildClass = new ChildFunction();
            Assert.Equal("overrideVirtual", baseChildClass.Virtual());

            BaseClass baseClass = new BaseClass();
            Assert.Equal("baseVirture", baseClass.Virtual());
        }

        [Fact(DisplayName = "测试new")]
        public void NewTest()
        {
            //new 和 override的差异在于 创建子类实例但是定义为父类的时候
            ChildFunction childClass = new ChildFunction();
            Assert.Equal("newNormal", childClass.Normal());

            BaseClass baseChildClass = new ChildFunction();
            Assert.Equal("baseNormal", baseChildClass.Normal());

            BaseClass baseClass = new BaseClass();
            Assert.Equal("baseNormal", baseClass.Normal());
        }
    }
}
