/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Org_ManageController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Org.Manage.IServices;
namespace Org.Manage.Controllers
{
    [Route("api/Org_Manage")]
    [PermissionTable(Name = "Org_Manage")]
    public partial class Org_ManageController : ApiBaseController<IOrg_ManageService>
    {
        public Org_ManageController(IOrg_ManageService service)
        : base(service)
        {
        }
    }
}

