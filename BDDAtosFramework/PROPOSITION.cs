namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROPOSITION")]
    public partial class PROPOSITION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROPOSITION()
        {
            COMMENTAIRE_PROPOSITION = new HashSet<COMMENTAIRE_PROPOSITION>();
            concerner = new HashSet<concerner>();
        }

        public int id { get; set; }

        public DateTime dateRelance { get; set; }

        public DateTime dateEcheance { get; set; }

        [Column(TypeName = "money")]
        public decimal tarif { get; set; }

        [Required]
        [StringLength(10)]
        public string etat { get; set; }

        public bool satisfait { get; set; }

        public int id_COLLABORATEUR { get; set; }

        public virtual COLLABORATEUR COLLABORATEUR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENTAIRE_PROPOSITION> COMMENTAIRE_PROPOSITION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<concerner> concerner { get; set; }
    }
}
