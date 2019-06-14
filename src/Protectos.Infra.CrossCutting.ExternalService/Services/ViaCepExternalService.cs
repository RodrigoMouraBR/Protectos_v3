using Newtonsoft.Json;
using Protectos.Domain.DTO;
using Protectos.Domain.Generics.Interfaces.Services;
using Protectos.Infra.CrossCutting.ExternalService.Utils;
using System.Configuration;
using System.Net;
using System.Text;
namespace Protectos.Infra.CrossCutting.ExternalService.Services
{
    public class ViaCepExternalService : IViaCepExternalService
    {
        public ViaCep ConsultarCEP(string cep)
        {
            using (var WebClient = new WebClient())
            {
                string urlViacep = ConfigurationManager.AppSettings["urlViaCep"];
                string rawJson = WebClient.DownloadString(urlViacep + TextoHelper.GetNumeros(cep.Trim()) + "/json/");
                string unicodeJson = Encoding.UTF8.GetString(Encoding.GetEncoding("iso-8859-1").GetBytes(rawJson));
                var viaCep = JsonConvert.DeserializeObject<ViaCep>(unicodeJson);        
                return viaCep;
            }           
        }       
    }    
}
