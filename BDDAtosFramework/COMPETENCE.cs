namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPETENCE")]
    public partial class COMPETENCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPETENCE()
        {
            disposer = new HashSet<disposer>();
            necessiter = new HashSet<necessiter>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string intitule { get; set; }

        public int id_TYPE_COMPETENCE { get; set; }

        public int id_EXPERIENCE { get; set; }

        public virtual EXPERIENCE EXPERIENCE { get; set; }

        public virtual TYPE_COMPETENCE TYPE_COMPETENCE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<disposer> disposer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<necessiter> necessiter { get; set; }
    }
}
