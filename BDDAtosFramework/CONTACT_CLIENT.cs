namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTACT_CLIENT
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nom { get; set; }

        [Required]
        [StringLength(50)]
        public string prenom { get; set; }

        [Required]
        [StringLength(50)]
        public string poste { get; set; }

        [Required]
        [StringLength(50)]
        public string courriel { get; set; }

        [Required]
        [StringLength(10)]
        public string tel_fixe { get; set; }

        [Required]
        [StringLength(10)]
        public string tel_perso { get; set; }

        [Required]
        [StringLength(10)]
        public string fax { get; set; }

        public int id_CLIENT { get; set; }

        public virtual CLIENT CLIENT { get; set; }
    }
}
