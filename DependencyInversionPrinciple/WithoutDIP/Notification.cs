namespace DependencyInversionPrinciple.WithoutDIP
{
    public class Notification
    {
        private Gmail _gmail;
        private Hotmail _hotmail;

        public void SendGmail()
           => _gmail.SendGmail();

        public void SendHotmail()
           => _hotmail.SendHotmail();

        //Adding new Service          //OCP Vaiolation
        private Webmail _Webmail;

        public void SendWebmail()
            => _Webmail.SendWebmail();
    }
}
