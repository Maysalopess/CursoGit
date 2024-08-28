namespace ReserveiAPI.Objects.Contracts
{
    public class TokenSignature
    {
        public string Issuer { get; set; } = "Course Guide API";
        public string Audience { get; set; } = "Course Guide WebSite";
        public string Key { get; set; } = "CourseGuide _Barrament_API_Autentication";
    }
}
