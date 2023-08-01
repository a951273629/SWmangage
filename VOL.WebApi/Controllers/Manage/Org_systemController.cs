/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Org_systemController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Org.Manage.IServices;
namespace Org.Manage.Controllers
{
    [Route("api/Org_system")]
    [PermissionTable(Name = "Org_system")]
    public partial class Org_systemController : ApiBaseController<IOrg_systemService>
    {
        public Org_systemController(IOrg_systemService service)
        : base(service)
        {
        }
    }
}

