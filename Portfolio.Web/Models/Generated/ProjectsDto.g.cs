using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Portfolio.Web.Models
{
    public partial class ProjectsDtoGen : GeneratedDto<Portfolio.Data.Models.Projects>
    {
        public ProjectsDtoGen() { }

        private int? _ProjectId;
        private string _Name;
        private string _Description;
        private string _ProjectType;

        public int? ProjectId
        {
            get => _ProjectId;
            set { _ProjectId = value; Changed(nameof(ProjectId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public string Description
        {
            get => _Description;
            set { _Description = value; Changed(nameof(Description)); }
        }
        public string ProjectType
        {
            get => _ProjectType;
            set { _ProjectType = value; Changed(nameof(ProjectType)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Portfolio.Data.Models.Projects obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ProjectId = obj.ProjectId;
            this.Name = obj.Name;
            this.Description = obj.Description;
            this.ProjectType = obj.ProjectType;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Portfolio.Data.Models.Projects entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ProjectId))) entity.ProjectId = (ProjectId ?? entity.ProjectId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(Description))) entity.Description = Description;
            if (ShouldMapTo(nameof(ProjectType))) entity.ProjectType = ProjectType;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override Portfolio.Data.Models.Projects MapToNew(IMappingContext context)
        {
            var entity = new Portfolio.Data.Models.Projects();
            MapTo(entity, context);
            return entity;
        }
    }
}
