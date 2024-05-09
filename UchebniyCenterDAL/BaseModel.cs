using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UchebniyCenterDAL
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime? CreateDate { get; set; } = DateTime.Now;

        public DateTime? LastModifyDate { get; set; }

        public long? CreateUserId { get; set; }

        public long? LastModifyUserId { get; set; }
    }
}
