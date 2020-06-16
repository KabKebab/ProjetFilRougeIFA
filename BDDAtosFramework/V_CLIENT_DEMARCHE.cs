namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_CLIENT_DEMARCHE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column("Nom du démarcheur", Order = 1)]
        [StringLength(50)]
        public string Nom_du_démarcheur { get; set; }

        [Key]
        [Column("Prénom du démarcheur", Order = 2)]
        [StringLength(50)]
        public string Prénom_du_démarcheur { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Action { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Client { get; set; }
    }
}
