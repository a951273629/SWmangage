/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Finished_Check_TicketController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Org.Manage.IServices;
namespace Org.Manage.Controllers
{
    [Route("api/Finished_Check_Ticket")]
    [PermissionTable(Name = "Finished_Check_Ticket")]
    public partial class Finished_Check_TicketController : ApiBaseController<IFinished_Check_TicketService>
    {
        public Finished_Check_TicketController(IFinished_Check_TicketService service)
        : base(service)
        {
        }
    }
}

