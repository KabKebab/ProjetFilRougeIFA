namespace BDDAtosFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("disposer")]
    public partial class disposer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_COMPETENCE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_EXPERIENCE { get; set; }

        public virtual COLLABORATEUR COLLABORATEUR { get; set; }

        public virtual COMPETENCE COMPETENCE { get; set; }

        public virtual EXPERIENCE EXPERIENCE { get; set; }
    }
}
