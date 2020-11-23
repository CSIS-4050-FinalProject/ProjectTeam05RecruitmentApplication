namespace RecruitmentCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Application")]
    public partial class Application
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Application()
        {
            Interviews = new HashSet<Interview>();
        }

        public int ApplicationId { get; set; }

        public int JobId { get; set; }

        public int CandidateId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SubmissionDate { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeReferral { get; set; }

        public int ProcessDuration { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime StatusDate { get; set; }

        public virtual Candidate Candidate { get; set; }

        public virtual Job Job { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interview> Interviews { get; set; }
    }
}
