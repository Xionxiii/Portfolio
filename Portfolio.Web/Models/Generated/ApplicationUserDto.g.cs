using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Portfolio.Web.Models
{
    public partial class ApplicationUserDtoGen : GeneratedDto<Portfolio.Data.Models.ApplicationUser>
    {
        public ApplicationUserDtoGen() { }

        private int? _ApplicationUserId;
        private string _Name;
        private System.DateTime? _BirthDate;

        public int? ApplicationUserId
        {
            get => _ApplicationUserId;
            set { _ApplicationUserId = value; Changed(nameof(ApplicationUserId)); }
        }
        public string Name
        {
            get => _Name;
            set { _Name = value; Changed(nameof(Name)); }
        }
        public System.DateTime? BirthDate
        {
            get => _BirthDate;
            set { _BirthDate = value; Changed(nameof(BirthDate)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Portfolio.Data.Models.ApplicationUser obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.ApplicationUserId = obj.ApplicationUserId;
            this.Name = obj.Name;
            this.BirthDate = obj.BirthDate;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Portfolio.Data.Models.ApplicationUser entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(ApplicationUserId))) entity.ApplicationUserId = (ApplicationUserId ?? entity.ApplicationUserId);
            if (ShouldMapTo(nameof(Name))) entity.Name = Name;
            if (ShouldMapTo(nameof(BirthDate))) entity.BirthDate = BirthDate;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override Portfolio.Data.Models.ApplicationUser MapToNew(IMappingContext context)
        {
            var entity = new Portfolio.Data.Models.ApplicationUser();
            MapTo(entity, context);
            return entity;
        }
    }
}
