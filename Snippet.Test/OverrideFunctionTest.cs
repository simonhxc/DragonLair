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

        [Fact(DisplayName = "����override")]
        public void OverrideTest()
        {
            ChildFunction childClass = new ChildFunction();
            Assert.Equal("overrideVirtual", childClass.Virtual());

            BaseClass baseChildClass = new ChildFunction();
            Assert.Equal("overrideVirtual", baseChildClass.Virtual());

            BaseClass baseClass = new BaseClass();
            Assert.Equal("baseVirture", baseClass.Virtual());
        }

        [Fact(DisplayName = "����new")]
        public void NewTest()
        {
            //new �� override�Ĳ������� ��������ʵ�����Ƕ���Ϊ�����ʱ��
            ChildFunction childClass = new ChildFunction();
            Assert.Equal("newNormal", childClass.Normal());

            BaseClass baseChildClass = new ChildFunction();
            Assert.Equal("baseNormal", baseChildClass.Normal());

            BaseClass baseClass = new BaseClass();
            Assert.Equal("baseNormal", baseClass.Normal());
        }
    }
}
