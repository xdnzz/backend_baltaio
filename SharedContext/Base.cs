namespace Balta.SharedContext 
{
    public abstract class Base: NotificationContext.Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); //SPOF, Single Point of Failure

        }
        public Guid Id { get; set; }

    }
} 