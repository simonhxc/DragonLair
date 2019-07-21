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

        [Fact(DisplayName = "���Բ������еķ���")]
        public void PartialClassFunctionTest()
        {
            using (var context = this._serviceProvide.GetService<PartClass>())
            {
                //�ֲ���ֻ����ͬһ����(.exe)��ͬһģ��(.dll)��
                //���ҷֲ���Ĳ�ͬ���ֲ��ܶ�����ͬ�ķ���
                //�ֲ����и����ֿ��Ե����������ֵķ�����������ͬһ������һ��
                Assert.Equal("oneFunction", context.OneFunction());
                Assert.Equal("twoFunction", context.TwoFunction());
            }
        }
    }
}
