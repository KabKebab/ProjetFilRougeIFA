namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_COMPETENCE_EXPERIENCE_COLLAB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Nom { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Prénom { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Compétence { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Expérience { get; set; }
    }
}
