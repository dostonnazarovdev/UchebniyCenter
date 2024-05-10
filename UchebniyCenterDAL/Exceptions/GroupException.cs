using System;

namespace UchebniyCenterDAL.Exceptions
{
    public class GroupException:Exception
    {
        public int statusCode;
        public GroupException(int code,string message) : base(message)
        {
            statusCode = code;

        }
    }
}
