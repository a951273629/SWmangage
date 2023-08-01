/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Finished_Check_WorksRepository编写代码
 */
using Org.Manage.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Repositories
{
    public partial class Finished_Check_WorksRepository : RepositoryBase<Finished_Check_Works> , IFinished_Check_WorksRepository
    {
    public Finished_Check_WorksRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IFinished_Check_WorksRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IFinished_Check_WorksRepository>(); } }
    }
}
