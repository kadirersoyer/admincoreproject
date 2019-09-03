using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCoreProject.Entities
{
    public class Menu: BaseEntity.BaseEntity
    {
        public string ParentId { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string MenuLink { get; set; }
    }
}
