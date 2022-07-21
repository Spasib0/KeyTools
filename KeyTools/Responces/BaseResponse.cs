using System;

namespace KeyTools.Responces
{
    public class BaseResponse
    {
        public string value;
        public string details;
        public int delay;

        public const string SERVER_RETURN_OK = "ok";
        public static DateTime CUSTOM_DATE_TIME = new DateTime(2000, 1, 1, 12, 0, 0, DateTimeKind.Utc);
    }
}
