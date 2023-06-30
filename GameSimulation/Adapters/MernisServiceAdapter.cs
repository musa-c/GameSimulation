using InterfaceAbstractExample.Abstract;
using InterfaceAbstractExample.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractExample.Adapters
{
    public class MernisServiceAdapter : ICheckUser
    {
        public bool CheckifUser(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(new KPSPublicSoapClient.EndpointConfiguration());
            var isUser = client.TCKimlikNoDogrulaAsync(user.TcNo, user.FirstName, user.LastName, user.BirthDay.Year);
            return isUser.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
