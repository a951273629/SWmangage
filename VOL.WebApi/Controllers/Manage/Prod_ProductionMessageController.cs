/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Prod_ProductionMessageController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Org.Manage.IServices;
namespace Org.Manage.Controllers
{
    [Route("api/Prod_ProductionMessage")]
    [PermissionTable(Name = "Prod_ProductionMessage")]
    public partial class Prod_ProductionMessageController : ApiBaseController<IProd_ProductionMessageService>
    {
        public Prod_ProductionMessageController(IProd_ProductionMessageService service)
        : base(service)
        {
        }
    }
}

