using System;

namespace UchebniyCenterDAL.Exceptions
{
    public class StudentException:Exception
    {
        public int statusCode;
        public StudentException(int code,string message):base(message)
        {
            statusCode = code;
        }
    }
}
