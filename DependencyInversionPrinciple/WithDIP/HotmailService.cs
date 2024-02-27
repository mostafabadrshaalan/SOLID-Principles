namespace DependencyInversionPrinciple.WithDIP
{
    public class HotmailService : IMessageService
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string To { get; set; }

        public void Send()
        {
            //Code
        }
    }
}
