/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Org_peopleController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Org.Manage.IServices;
namespace Org.Manage.Controllers
{
    [Route("api/Org_people")]
    [PermissionTable(Name = "Org_people")]
    public partial class Org_peopleController : ApiBaseController<IOrg_peopleService>
    {
        public Org_peopleController(IOrg_peopleService service)
        : base(service)
        {
        }
    }
}

