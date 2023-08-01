/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Finished_Check_TicketService与IFinished_Check_TicketService中编写
 */
using Org.Manage.IRepositories;
using Org.Manage.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace Org.Manage.Services
{
    public partial class Finished_Check_TicketService : ServiceBase<Finished_Check_Ticket, IFinished_Check_TicketRepository>
    , IFinished_Check_TicketService, IDependency
    {
    public Finished_Check_TicketService(IFinished_Check_TicketRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IFinished_Check_TicketService Instance
    {
      get { return AutofacContainerModule.GetService<IFinished_Check_TicketService>(); } }
    }
 }
