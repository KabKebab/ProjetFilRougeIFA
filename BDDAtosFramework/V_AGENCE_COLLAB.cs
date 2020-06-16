namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_AGENCE_COLLAB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Nom { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Prénom { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string CV { get; set; }

        [Key]
        [Column("Taux de bench", Order = 4)]
        public double Taux_de_bench { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Agence { get; set; }
    }
}
