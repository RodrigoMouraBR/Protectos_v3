using Newtonsoft.Json;
using Protectos.Domain.DTO;
using Protectos.Infra.CrossCutting.ExternalService.Utils;
using System.Configuration;
using System.Net;
using System.Text;
using System.Threading;
namespace Protectos.Infra.CrossCutting.ExternalService.Services
{
    public class ReceitawsExternalService
    {
        

        public ReceitaWs ConsultaJsonUnitario(string cnpj)
        {
            ReceitaWs plantCollection = new ReceitaWs();
            using (var WebClient = new WebClient())
            {
                Thread.Sleep(1000);
               var urlCnpj = ConfigurationManager.AppSettings["UrlReceitaCnpj"]; 
                string rawJson = WebClient.DownloadString(urlCnpj + TextoHelper.GetNumeros(cnpj.Trim()));
                string unicodeJson = Encoding.UTF8.GetString(Encoding.GetEncoding("iso-8859-1").GetBytes(rawJson));
                plantCollection = JsonConvert.DeserializeObject<ReceitaWs>(unicodeJson);
                plantCollection.Cnpj = TextoHelper.GetNumeros(plantCollection.Cnpj);                
            }
            return plantCollection;
        }
    }
}
