namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TYPE_COMPETENCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TYPE_COMPETENCE()
        {
            COMPETENCE = new HashSet<COMPETENCE>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string intitule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPETENCE> COMPETENCE { get; set; }
    }
}
