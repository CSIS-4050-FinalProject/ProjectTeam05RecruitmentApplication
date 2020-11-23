namespace RecruitmentCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Interview")]
    public partial class Interview
    {
        public int InterviewId { get; set; }

        [Required]
        [StringLength(50)]
        public string RecruiterName { get; set; }

        public int? InterviewRound { get; set; }

        public int ApplicationId { get; set; }

        [StringLength(50)]
        public string Medium { get; set; }

        public int? Score { get; set; }

        public virtual Application Application { get; set; }
    }
}
