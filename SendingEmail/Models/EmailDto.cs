namespace SendingEmail.Models
{
    public class EmailDto
    {

        public string EmailTo { get; set; } = string.Empty;
        public string EmailSubject { get; set; } = string.Empty;
        public string EmailBody { get; set; } = string.Empty;

    }
}
