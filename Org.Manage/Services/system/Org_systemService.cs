/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Org_systemService与IOrg_systemService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class Org_systemService : ServiceBase<Org_system, IOrg_systemRepository>
    , IOrg_systemService, IDependency
    {
    public Org_systemService(IOrg_systemRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IOrg_systemService Instance
    {
      get { return AutofacContainerModule.GetService<IOrg_systemService>(); } }
    }
 }
