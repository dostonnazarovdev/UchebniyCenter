using System;

namespace UchebniyCenterDAL
{
    public class UchitelModel : BaseModel
    {
        public string FIO { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Remark { get; set; }

        public UchitelStatus? Status { get; set; }

        public decimal? ProcentFromUchenik { get; set; }
    }

    public enum UchitelStatus
    {
        Active = 1,
        Inactive = 0
    }
}
