using System;

namespace UchebniyCenterDAL
{
    public class UchenikModel : BaseModel
    {
        public string FIO { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string ParentFIO { get; set; }

        public string Remark { get; set; }

        public UchenikStatus? Status { get; set; }

        public bool? IsFirstLessonFree { get; set; }

        public bool? IsFirstLessonFreeUsed { get; set; }
    }

    public enum UchenikStatus
    {
        Active = 1,
        Inactive = 0
    }
}
