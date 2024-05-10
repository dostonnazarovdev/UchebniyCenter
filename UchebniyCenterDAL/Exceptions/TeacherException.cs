using System;

namespace UchebniyCenterDAL.Exceptions
{
    public class TeacherException:Exception
    {
        public int statusCode;
        public TeacherException(int code,string message) :base(message)
        {
            statusCode=code;
        }
    }
}
