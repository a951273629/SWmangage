/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Store_ProviderRegularService与IStore_ProviderRegularService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class Store_ProviderRegularService : ServiceBase<Store_ProviderRegular, IStore_ProviderRegularRepository>
    , IStore_ProviderRegularService, IDependency
    {
    public Store_ProviderRegularService(IStore_ProviderRegularRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IStore_ProviderRegularService Instance
    {
      get { return AutofacContainerModule.GetService<IStore_ProviderRegularService>(); } }
    }
 }
