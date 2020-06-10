namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMMENTAIRE_DEMARCHE
    {
        public int id { get; set; }

        [Required]
        [StringLength(5)]
        public string contenu { get; set; }

        public int id_DEMARCHE { get; set; }

        public virtual DEMARCHE DEMARCHE { get; set; }
    }
}
