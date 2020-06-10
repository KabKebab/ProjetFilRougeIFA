namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BESOIN")]
    public partial class BESOIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BESOIN()
        {
            concerner = new HashSet<concerner>();
            necessiter = new HashSet<necessiter>();
        }

        public int id { get; set; }

        public DateTime dateDemande { get; set; }

        [Required]
        [StringLength(50)]
        public string etat { get; set; }

        public bool satisfait { get; set; }

        public bool recurrent { get; set; }

        public int id_CLIENT { get; set; }

        public virtual CLIENT CLIENT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<concerner> concerner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<necessiter> necessiter { get; set; }
    }
}
