
using Zion.Domain.Util.Aux.Entities;

namespace Zion.Domain.Security.Auth.Entities
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }
        public int AccessLevel { get; set; }
    }
}
