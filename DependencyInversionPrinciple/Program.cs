using DependencyInversionPrinciple.WithoutDIP;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WithoutDIP

            Notification notification = new Notification();
            notification.SendGmail();
            notification.SendHotmail();

            #endregion

            #region WithDIP

            WithDIP.Notification notification1 = new WithDIP.Notification(new WithDIP.GmailService());

            notification1.Send(new WithDIP.HotmailService());

            #endregion
        }
    }
}
