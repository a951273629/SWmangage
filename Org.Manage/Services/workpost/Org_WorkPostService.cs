/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Org_WorkPostService与IOrg_WorkPostService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class Org_WorkPostService : ServiceBase<Org_WorkPost, IOrg_WorkPostRepository>
    , IOrg_WorkPostService, IDependency
    {
    public Org_WorkPostService(IOrg_WorkPostRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IOrg_WorkPostService Instance
    {
      get { return AutofacContainerModule.GetService<IOrg_WorkPostService>(); } }
    }
 }
