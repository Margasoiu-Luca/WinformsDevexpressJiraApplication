using JiraApplication.Interfaces;

namespace JiraApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JUser:IModelForDB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JUser()
        {
            this.JComments = new HashSet<JComment>();
            this.JEvents = new HashSet<JEvent>();
            this.JTeamUsers = new HashSet<JTeamUser>();
        }
    
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JComment> JComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JEvent> JEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JTeamUser> JTeamUsers { get; set; }
        public virtual JUserType JUserType { get; set; }
    }
}
