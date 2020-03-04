namespace Domaine
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("map_ds.project")]
    public partial class project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public project()
        {
            mandate = new HashSet<mandate>();
            client2 = new HashSet<client>();
            mandate1 = new HashSet<mandate>();
        }

        public int projectId { get; set; }

        [StringLength(255)]
        public string ProjectType { get; set; }

        [StringLength(255)]
        public string codePostal { get; set; }

        [StringLength(255)]
        public string pays { get; set; }

        [StringLength(255)]
        public string rue { get; set; }

        [StringLength(255)]
        public string ville { get; set; }

        [StringLength(255)]
        public string competence { get; set; }

        public DateTime? dateDebut { get; set; }

        public DateTime? dateFin { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int nbrResource { get; set; }

        [StringLength(255)]
        public string photo { get; set; }

        [StringLength(255)]
        public string projectName { get; set; }

        public int? client { get; set; }

        public virtual client client1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mandate> mandate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<client> client2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mandate> mandate1 { get; set; }
    }
}
