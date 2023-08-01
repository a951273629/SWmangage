/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Org_peopleService与IOrg_peopleService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class Org_peopleService : ServiceBase<Org_people, IOrg_peopleRepository>
    , IOrg_peopleService, IDependency
    {
    public Org_peopleService(IOrg_peopleRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IOrg_peopleService Instance
    {
      get { return AutofacContainerModule.GetService<IOrg_peopleService>(); } }
    }
 }
