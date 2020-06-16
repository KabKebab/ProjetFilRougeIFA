namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_ROLE_UTILISATEUR
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
        [Column("Nom de compte", Order = 3)]
        [StringLength(50)]
        public string Nom_de_compte { get; set; }

        [Key]
        [Column("Mot de passe", Order = 4)]
        [StringLength(50)]
        public string Mot_de_passe { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string intitule { get; set; }
    }
}
