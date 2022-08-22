namespace DevFreela.Payments.API.Models
{
    public class PaymentAprovedIntegrationEvent
    {
        public PaymentAprovedIntegrationEvent(int idProject)
        {
            IdProject = idProject;
        }

        public int IdProject { get; set; }
    }
}
