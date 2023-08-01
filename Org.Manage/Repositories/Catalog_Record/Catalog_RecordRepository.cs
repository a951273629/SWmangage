/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Catalog_RecordRepository编写代码
 */
using Org.Manage.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Repositories
{
    public partial class Catalog_RecordRepository : RepositoryBase<Catalog_Record> , ICatalog_RecordRepository
    {
    public Catalog_RecordRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static ICatalog_RecordRepository Instance
    {
      get {  return AutofacContainerModule.GetService<ICatalog_RecordRepository>(); } }
    }
}
