using System;

namespace EducationCenterDAL
{
    public class TeacherModel : BaseModel
    {
        public string FIO { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }

        public TeacherStatus? Status { get; set; }

        public decimal? ProcentFromTeacher { get; set; }
    }

    public enum TeacherStatus
    {
        Active = 1,
        Inactive = 0
    }
}
