namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COLLABORATEUR")]
    public partial class COLLABORATEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COLLABORATEUR()
        {
            disposer = new HashSet<disposer>();
            PROPOSITION = new HashSet<PROPOSITION>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nom { get; set; }

        [Required]
        [StringLength(50)]
        public string prenom { get; set; }

        [Required]
        [StringLength(200)]
        public string cv { get; set; }

        public double tauxBench { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<disposer> disposer { get; set; }

        public virtual INTERNE INTERNE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPOSITION> PROPOSITION { get; set; }

        public virtual SOUS_TRAITANT SOUS_TRAITANT { get; set; }
    }
}
