namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        public string _mailTo = String.Empty;
        public string _mailFrom = String.Empty;
        public CloudMailService(IConfiguration configuration) {
            _mailTo = configuration["mailSettings: mailToAddress"];
            _mailFrom = configuration["mailSettings:mailFromAddress"];
        }
        public void Send(string Subject, string Message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " + $"with{nameof(CloudMailService)}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Message: {Message}");
        } 
    }
}
