using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerCheckManager : IGamerCheck
    {
        public bool GamerCheck(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.Tc), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(),Convert.ToInt32(gamer.BirthYear)))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
