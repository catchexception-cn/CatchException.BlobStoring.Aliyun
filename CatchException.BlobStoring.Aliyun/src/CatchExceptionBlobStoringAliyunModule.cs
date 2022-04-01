using Volo.Abp.BlobStoring.Aliyun;
using Volo.Abp.Modularity;

namespace CatchException.BlobStoring.Aliyun;

[DependsOn(
    typeof(AbpBlobStoringAliyunModule))]
public class CatchExceptionBlobStoringAliyunModule : AbpModule
{

}