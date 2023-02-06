namespace SendingEmail.Models
{
    public class EmailDetails
    {
        public string EmailTo { get; set; } = string.Empty;
        public string EmailSubject { get; set; } = string.Empty;
        public string EmailBody { get; set; } = string.Empty;
    }
}
