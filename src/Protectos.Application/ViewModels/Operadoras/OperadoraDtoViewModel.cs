namespace Protectos.Application.ViewModels.Operadoras
{
    public class OperadoraDtoViewModel
    {
        public OperadoraDtoViewModel(
                                     OperadoraViewModel operadora, 
                                     OperadoraEnderecoViewModel endereco, 
                                     OperadoraEmailViewModel email, 
                                     OperadoraTelefoneViewModel telefone
                                    )
        {
            Operadora = operadora;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
        }
        protected OperadoraDtoViewModel()
        {
        }
        public OperadoraViewModel Operadora { get; private set; }
        public OperadoraEnderecoViewModel Endereco { get; private set; }
        public OperadoraEmailViewModel Email { get; private set; }
        public OperadoraTelefoneViewModel Telefone { get; private set; }
    }
}
