using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
using MernisServiceReference;

namespace InterfaceAndAbstractDemo.Adapters
{
    public class MernisServiceAdapters : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            /*KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);*/

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new 
                TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName, customer.LastName, customer.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
