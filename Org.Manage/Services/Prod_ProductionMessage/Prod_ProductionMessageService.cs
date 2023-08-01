/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Prod_ProductionMessageService与IProd_ProductionMessageService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class Prod_ProductionMessageService : ServiceBase<Prod_ProductionMessage, IProd_ProductionMessageRepository>
    , IProd_ProductionMessageService, IDependency
    {
    public Prod_ProductionMessageService(IProd_ProductionMessageRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IProd_ProductionMessageService Instance
    {
      get { return AutofacContainerModule.GetService<IProd_ProductionMessageService>(); } }
    }
 }
