/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Catalog_RecordService与ICatalog_RecordService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class Catalog_RecordService : ServiceBase<Catalog_Record, ICatalog_RecordRepository>
    , ICatalog_RecordService, IDependency
    {
    public Catalog_RecordService(ICatalog_RecordRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ICatalog_RecordService Instance
    {
      get { return AutofacContainerModule.GetService<ICatalog_RecordService>(); } }
    }
 }
