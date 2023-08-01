/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Finished_Check_WorksController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Org.Manage.IServices;
namespace Org.Manage.Controllers
{
    [Route("api/Finished_Check_Works")]
    [PermissionTable(Name = "Finished_Check_Works")]
    public partial class Finished_Check_WorksController : ApiBaseController<IFinished_Check_WorksService>
    {
        public Finished_Check_WorksController(IFinished_Check_WorksService service)
        : base(service)
        {
        }
    }
}

