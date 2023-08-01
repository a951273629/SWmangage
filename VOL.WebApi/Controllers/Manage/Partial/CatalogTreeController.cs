/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("CatalogTree",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.Entity.DomainModels;
using Org.Manage.IServices;
using VOL.Core.Extensions;
using VOL.Core.Filters;
using VOL.Core.Utilities;
using Microsoft.AspNetCore.Authorization;
using VOL.Core.ManageUser;
using Org.Manage.Services;

namespace Org.Manage.Controllers
{
    public partial class CatalogTreeController
    {
        private readonly ICatalogTreeService _service;//访问业务代码
        private readonly ICatalog_RecordService _record_service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public CatalogTreeController(
            ICatalogTreeService service,
            ICatalog_RecordService record_service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _record_service = record_service;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost, Route("test_01")]
        [AllowAnonymous]
        public virtual ActionResult test_01()
        {

            return Json(new
            {
                userName = UserContext.Current.UserTrueName,
                date= DateTime.Now.ToString("yyyy-MM--dd HH:mm:ss")
            });
        }
        [HttpGet, Route("GetAll")]
        [AllowAnonymous]
        public virtual ActionResult GetCatalogTreeAll()
        {
            return Json(_service.GetCatalogTreeAll());
        }

        [HttpPost, Route("GetSerialNumber")]
        [AllowAnonymous]
        public virtual ActionResult<int> GetSerialNumber([FromBody] CatalogTree ct)
        {
            Console.WriteLine(ct.ID);
            return _service.GetSerialNumberById(ct.ID);
        }
        /// <summary>
        /// 获取流水号接口
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPost, Route("GetCode")]
        [AllowAnonymous]
        public virtual ActionResult<string> GetCode([FromBody] Submit date)
        {
            Catalog_Record catalog =
                _service.GetCodeComplete(date);
            //添加到数据库
            var result = _record_service.AddEntity(catalog,false);
            Console.WriteLine(result);
            //Console.WriteLine(catalog);
            //_service.GetCode(CatalogIdArrary)
            return catalog.PartNumber;
        }
        [HttpPost, Route("GetRuleTypeCode")]
        [AllowAnonymous]
        public virtual ActionResult GetRuleTypeCode([FromBody] CatalogTree catalogTree)
        {
            if(catalogTree is null)
            {
                Json(new { RuleTypeCode = "-1" });
            }
            return Json(new { 
                _service.GetRuleTypeCode(catalogTree.ID).RuleTypeCode 
            });
        }
    }
}
