
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Portfolio.Web.Api
{
    [Route("api/Projects")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class ProjectsController
        : BaseApiController<Portfolio.Data.Models.Projects, ProjectsDtoGen, Portfolio.Data.AppDbContext>
    {
        public ProjectsController(Portfolio.Data.AppDbContext db) : base(db)
        {
            GeneratedForClassViewModel = ReflectionRepository.Global.GetClassViewModel<Portfolio.Data.Models.Projects>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<ProjectsDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<Portfolio.Data.Models.Projects> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<ProjectsDtoGen>> List(
            ListParameters parameters,
            IDataSource<Portfolio.Data.Models.Projects> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<Portfolio.Data.Models.Projects> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<ProjectsDtoGen>> Save(
            [FromForm] ProjectsDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<Portfolio.Data.Models.Projects> dataSource,
            IBehaviors<Portfolio.Data.Models.Projects> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<ProjectsDtoGen>> Delete(
            int id,
            IBehaviors<Portfolio.Data.Models.Projects> behaviors,
            IDataSource<Portfolio.Data.Models.Projects> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
