using System;

namespace EducationCenterDAL
{
    public class StudentModel : BaseModel
    {
        public string FIO { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string ParentFIO { get; set; }

        public string Remark { get; set; }

        public StudentStatus? Status { get; set; }

        public bool? IsFirstLessonFree { get; set; }

        public bool? IsFirstLessonFreeUsed { get; set; }
    }

    public enum StudentStatus
    {
        Active = 1,
        Inactive = 0
    }
}
