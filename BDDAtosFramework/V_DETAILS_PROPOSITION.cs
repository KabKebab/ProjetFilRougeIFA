namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_DETAILS_PROPOSITION
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column("Date de relance", Order = 1)]
        public DateTime Date_de_relance { get; set; }

        [Key]
        [Column("Date d'échéance", Order = 2)]
        public DateTime Date_d_échéance { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Tarif { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string État { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Satisfait { get; set; }

        [Key]
        [Column("Nom du collaborateur", Order = 6)]
        [StringLength(50)]
        public string Nom_du_collaborateur { get; set; }

        [Key]
        [Column("Prénom du collaborateur", Order = 7)]
        [StringLength(50)]
        public string Prénom_du_collaborateur { get; set; }

        [Key]
        [Column("id du besoin", Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_du_besoin { get; set; }
    }
}
