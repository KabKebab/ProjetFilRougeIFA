namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_CLIENT_CONTACT_CLIENT
    {
        [Key]
        [Column("Nom du contact", Order = 0)]
        [StringLength(50)]
        public string Nom_du_contact { get; set; }

        [Key]
        [Column("Prénom du contact", Order = 1)]
        [StringLength(50)]
        public string Prénom_du_contact { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Poste { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Courriel { get; set; }

        [Key]
        [Column("Téléphone fixe", Order = 4)]
        [StringLength(10)]
        public string Téléphone_fixe { get; set; }

        [Key]
        [Column("Téléphone personnel", Order = 5)]
        [StringLength(10)]
        public string Téléphone_personnel { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string Fax { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Client { get; set; }
    }
}
