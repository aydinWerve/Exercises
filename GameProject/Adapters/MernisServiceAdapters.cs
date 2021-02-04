using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;

namespace GameProject.Adapters
{
    public class MernisServiceAdapters : IGamerCheckService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new
                                TCKimlikNoDogrulaRequestBody(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
