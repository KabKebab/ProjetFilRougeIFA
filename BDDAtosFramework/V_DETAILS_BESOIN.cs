namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_DETAILS_BESOIN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column("Date de demande", Order = 1)]
        public DateTime Date_de_demande { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string État { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Satisfait { get; set; }

        [Key]
        [Column("Besoin récurrent", Order = 4)]
        public bool Besoin_récurrent { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Client { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Compétence { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Expérience { get; set; }
    }
}
