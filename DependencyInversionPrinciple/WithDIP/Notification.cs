namespace DependencyInversionPrinciple.WithDIP
{
    public class Notification
    {
        //DependencyInjectionWays

        //1- Constructor Injection
        private readonly IMessageService _messageService;
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        //2- Property Injection
        public IMessageService MessageService { get; set; }


        public void Send(IMessageService messageService) //3- Method Injection
        {
            /*1-*/
            _messageService.Send();

            //Or

            /*2-*/
            MessageService.Send();

            //Or

            /*3-*/
            messageService.Send();
        }
    }
}
