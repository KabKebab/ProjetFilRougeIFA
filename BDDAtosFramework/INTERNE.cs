namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INTERNE")]
    public partial class INTERNE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public int id_AGENCE { get; set; }

        public virtual AGENCE AGENCE { get; set; }

        public virtual COLLABORATEUR COLLABORATEUR { get; set; }
    }
}
