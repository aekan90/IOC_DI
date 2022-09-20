using IOC_DI.Web.Models.Services.Abstract;

namespace IOC_DI.Web.Models.Services.Concrete
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
