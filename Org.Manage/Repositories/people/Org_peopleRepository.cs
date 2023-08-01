/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Org_peopleRepository编写代码
 */
using Org.Manage.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Repositories
{
    public partial class Org_peopleRepository : RepositoryBase<Org_people> , IOrg_peopleRepository
    {
    public Org_peopleRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IOrg_peopleRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IOrg_peopleRepository>(); } }
    }
}
