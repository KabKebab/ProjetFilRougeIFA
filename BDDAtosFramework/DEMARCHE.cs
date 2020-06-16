namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEMARCHE")]
    public partial class DEMARCHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEMARCHE()
        {
            COMMENTAIRE_DEMARCHE = new HashSet<COMMENTAIRE_DEMARCHE>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nomDemarcheur { get; set; }

        [Required]
        [StringLength(50)]
        public string prenomDemarcheur { get; set; }

        public DateTime date { get; set; }

        [Required]
        [StringLength(200)]
        public string action { get; set; }

        public int id_CLIENT { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENTAIRE_DEMARCHE> COMMENTAIRE_DEMARCHE { get; set; }
    }
}
