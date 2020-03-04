namespace Domaine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("map_ds.candidate")]
    public partial class candidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public candidate()
        {
            passage = new HashSet<passage>();
            passage1 = new HashSet<passage>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [StringLength(255)]
        public string codePostal { get; set; }

        [StringLength(255)]
        public string pays { get; set; }

        [StringLength(255)]
        public string rue { get; set; }

        [StringLength(255)]
        public string ville { get; set; }

        [StringLength(255)]
        public string classType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateNaissance { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [StringLength(255)]
        public string nom { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string prenom { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        [StringLength(255)]
        public string cv { get; set; }

        [StringLength(255)]
        public string etat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<passage> passage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<passage> passage1 { get; set; }
    }
}
