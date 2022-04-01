using Microsoft.Extensions.Configuration;

using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace CatchException.BlobStoring.Aliyun;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IBlobUrlCalculator))]
public class AliyunBlobUrlCalculator : DefaultBlobUrlCalculator
{
    private readonly string _aliyunEndpoint;

    public AliyunBlobUrlCalculator(ICurrentTenant currentTenant,
        IConfiguration configuration) : base(currentTenant)
    {
        _aliyunEndpoint = configuration["BlobStoring:Aliyun:PublicAccessEndpoint"].EnsureEndsWith('/');
    }

    public override string Calculate(string fileName)
    {
        var name = base.Calculate(fileName);
        return _aliyunEndpoint + name;
    }
}