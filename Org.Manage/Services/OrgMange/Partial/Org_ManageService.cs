/*
 *所有关于Org_Manage类的业务代码应在此处编写
*可使用repository.调用常用方法，获取EF/Dapper等信息
*如果需要事务请使用repository.DbContextBeginTransaction
*也可使用DBServerProvider.手动获取数据库相关信息
*用户信息、权限、角色等使用UserContext.Current操作
*Org_ManageService对增、删、改查、导入、导出、审核业务代码扩展参照ServiceFunFilter
*/
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;
using System.Linq;
using VOL.Core.Utilities;
using System.Linq.Expressions;
using VOL.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using Org.Manage.IRepositories;
using VOL.Core.Enums;

namespace Org.Manage.Services
{
    public partial class Org_ManageService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOrg_ManageRepository _repository;//访问数据库

        [ActivatorUtilitiesConstructor]
        public Org_ManageService(
            IOrg_ManageRepository dbRepository,
            IHttpContextAccessor httpContextAccessor
            )
        : base(dbRepository)
        {
            this._httpContextAccessor = httpContextAccessor;
            this._repository = dbRepository;
            //多租户会用到这init代码，其他情况可以不用
            //base.Init(dbRepository);
        }

        //public override PageGridData<Org_Manage> GetPageData(PageDataOptions options)
        //{
        //    //options.Value可以从前台查询的方法提交一些其他参数放到value里面
        //    //前端提交方式，见文档：组件api->viewgrid组件里面的searchBefore方法
        //    object extraValue = options.Value;

        //    //此处是从前台提交的原生的查询条件，这里可以自己过滤
        //    QueryRelativeList = (List<SearchParameters> parameters) =>
        //    {

        //    };

        //    //2020.08.15
        //    //设置原生查询的sql语句，这里必须返回select * 表所有字段
        //    //（先内部过滤数据,内部调用EF方法FromSqlRaw,自己写的sql注意sql注入的问题），不会影响界面上提交的查询
        //    /*  
        //     *  string date = DateTime.Now.AddYears(-10).ToString("yyyy-MM-dd");
        //        QuerySql = $@"select * from SellOrder  
        //                               where createdate>'{date}'
        //                                   and  Order_Id in (select Order_Id from SellOrderList)
        //                                   and CreateID={UserContext.Current.UserId}";
        //    */

        //    //2020.08.15
        //    //此处与上面QuerySql只需要实现其中一个就可以了
        //    //查询前可以自已设定查询表达式的条件
        //    QueryRelativeExpression = (IQueryable<Org_Manage> queryable) =>
        //    {
        //        //当前用户只能操作自己(与下级角色)创建的数据,如:查询、删除、修改等操作
        //        //IQueryable<int> userQuery = RoleContext.GetCurrentAllChildUser();
        //        //queryable = queryable.Where(x => x.CreateID == UserContext.Current.UserId || userQuery.Contains(x.CreateID ?? 0));
        //        return queryable;
        //    };

        //    //指定多个字段进行排序
        //    OrderByExpression = x => new Dictionary<object, QueryOrderBy>() {
        //    //{ x.Id.QueryOrderBy.desc },
        //    //{ x.SellNo,QueryOrderBy.Asc}
        //};

        //    //int a = 1;
        //    ////指定多个字段按条件进行排序（需要2021.07.04更新LambdaExtensions类后才能使用）
        //    //OrderByExpression = x => new Dictionary<object, QueryOrderBy>() {
        //    //    { x.CreateDate,QueryOrderBy.Desc },
        //    //    { x.SellNo,a==1?QueryOrderBy.Desc:QueryOrderBy.Asc}
        //    //};

        //    //查询完成后，在返回页面前可对查询的数据进行操作
        //    GetPageDataOnExecuted = (PageGridData<Org_Manage> grid) =>
        //    {
        //        //可对查询的结果的数据操作
        //        List<Org_Manage> sellOrders = grid.rows;
        //    };
        //    //查询table界面显示求和
        //    SummaryExpress = (IQueryable<Org_Manage> queryable) =>
        //    {
        //        return queryable.GroupBy(x => 1).Select(x => new
        //        {
        //            //AvgPrice注意大小写和数据库字段大小写一样
        //            Qty = x.Sum(o => o.Id).ToString("f2")
        //        })
        //        .FirstOrDefault();
        //    };

        //    return base.GetPageData(options);
        //}
    }
}
