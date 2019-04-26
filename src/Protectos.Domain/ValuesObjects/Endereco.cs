namespace Protectos.Domain.ValuesObjects
{
    public class Endereco
    {
        public Endereco(string logradouro, string numero, string bairro, 
                        string cep, string complemento, string cidade, 
                        string estado, string uF, string pais)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            UF = uF;
            Pais = pais;
        }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cep { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string UF { get; private set; }
        public string Pais { get; private set; }
    }
}