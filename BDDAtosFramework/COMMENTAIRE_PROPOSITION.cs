namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMMENTAIRE_PROPOSITION
    {
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string contenu { get; set; }

        public int id_PROPOSITION { get; set; }

        public virtual PROPOSITION PROPOSITION { get; set; }
    }
}
