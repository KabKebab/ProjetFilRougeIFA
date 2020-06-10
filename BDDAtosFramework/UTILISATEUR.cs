namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UTILISATEUR")]
    public partial class UTILISATEUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UTILISATEUR()
        {
            concerner = new HashSet<concerner>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string nom { get; set; }

        [Required]
        [StringLength(10)]
        public string prenom { get; set; }

        [Required]
        [StringLength(10)]
        public string nomDeCompte { get; set; }

        [Required]
        [StringLength(10)]
        public string motDePasse { get; set; }

        public int id_ROLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<concerner> concerner { get; set; }

        public virtual ROLE ROLE { get; set; }
    }
}
