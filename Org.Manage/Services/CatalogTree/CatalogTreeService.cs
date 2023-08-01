/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下CatalogTreeService与ICatalogTreeService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class CatalogTreeService : ServiceBase<CatalogTree, ICatalogTreeRepository>
    , ICatalogTreeService, IDependency
    {
    public CatalogTreeService(ICatalogTreeRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ICatalogTreeService Instance
    {
      get { return AutofacContainerModule.GetService<ICatalogTreeService>(); } }
    }
 }
