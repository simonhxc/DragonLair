using System;
using Xunit;
using Snippet.Demo.PartialClass;
using Microsoft.Extensions.DependencyInjection;

namespace Snippet.Test
{
    public class PartialClassTest : IClassFixture<SnippetTestFixture>
    {
        private ServiceProvider _serviceProvide;

        public PartialClassTest(SnippetTestFixture snippetTestFixture)
        {
            this._serviceProvide = snippetTestFixture.ServiceProvider;
        }

        [Fact(DisplayName = "测试部分类中的方法")]
        public void PartialClassFunctionTest()
        {
            using (var context = this._serviceProvide.GetService<PartClass>())
            {
                //分部类只能在同一程序集(.exe)或同一模块(.dll)中
                //并且分部类的不同部分不能定义相同的方法
                //分部类中各部分可以调用其他部分的方法，就像在同一个类中一样
                Assert.Equal("oneFunction", context.OneFunction());
                Assert.Equal("twoFunction", context.TwoFunction());
            }
        }
    }
}
