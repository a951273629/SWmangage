/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Store_ProviderRegularController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using Org.Manage.IServices;
namespace Org.Manage.Controllers
{
    [Route("api/Store_ProviderRegular")]
    [PermissionTable(Name = "Store_ProviderRegular")]
    public partial class Store_ProviderRegularController : ApiBaseController<IStore_ProviderRegularService>
    {
        public Store_ProviderRegularController(IStore_ProviderRegularService service)
        : base(service)
        {
        }
    }
}

