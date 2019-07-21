using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Minio;

namespace Minio
{
    public partial class MinioClient
    {
        public void complate() {
            //无法拓展minio中的部分类，部分类只能存在于同一程序集或模块中（.exe, .dll）
            //MinioClient minio = new MinioClient();
            //CompleteMultipartUploadAsync();
        }
    }
}
