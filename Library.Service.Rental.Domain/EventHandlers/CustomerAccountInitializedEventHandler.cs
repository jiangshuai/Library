using System;
using System.Threading.Tasks;
using  Library.Domain.Core;
using  Library.Service.Rental.Domain.DataAccessors;

namespace  Library.Service.Rental.Domain
{
    public class CustomerAccountInitializedEventHandler : IEventHandler<CustomerAccountInitializedEvent>
    {
        private IRentalReportDataAccessor _reportDataAccessor = null;

        public CustomerAccountInitializedEventHandler(IRentalReportDataAccessor reportDataAccessor)
        {
            _reportDataAccessor = reportDataAccessor;
        }

        public void Handle(CustomerAccountInitializedEvent evt)
        {
            
        }

        public Task HandleAsync(CustomerAccountInitializedEvent evt)
        {
            return null;
        }
    }
}