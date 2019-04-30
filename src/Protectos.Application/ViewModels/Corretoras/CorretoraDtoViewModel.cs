namespace Protectos.Application.ViewModels.Corretoras
{
    public class CorretoraDtoViewModel
    {
        public CorretoraDtoViewModel(CorretoraViewModel corretora, CorretoraEnderecoViewModel endereco, CorretoraEmailViewModel email, CorretoraTelefoneViewModel telefone)
        {
            Corretora = corretora;
            Endereco = endereco;
            Email = email;
            Telefone = telefone;
        }
        protected CorretoraDtoViewModel()
        {
        }
        public CorretoraViewModel Corretora { get; private set; }
        public CorretoraEnderecoViewModel Endereco { get; private set; }
        public CorretoraEmailViewModel Email { get; private set; }
        public CorretoraTelefoneViewModel Telefone { get; private set; }
    }
}
