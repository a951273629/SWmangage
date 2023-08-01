/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Org_ManageService与IOrg_ManageService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class Org_ManageService : ServiceBase<Org_Manage, IOrg_ManageRepository>
    , IOrg_ManageService, IDependency
    {
    public Org_ManageService(IOrg_ManageRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IOrg_ManageService Instance
    {
      get { return AutofacContainerModule.GetService<IOrg_ManageService>(); } }
    }
 }
