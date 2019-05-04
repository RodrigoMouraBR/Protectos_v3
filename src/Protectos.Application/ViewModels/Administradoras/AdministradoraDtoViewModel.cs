namespace Protectos.Application.ViewModels.Administradoras
{
    public class AdministradoraDtoViewModel
    {
        public AdministradoraDtoViewModel(
                                           AdministradoraViewModel administradora,                                           
                                           AdministradoraEnderecoViewModel endereco,                                        
                                           AdministradoraTelefoneViewModel telefone,                                       
                                           AdministradoraEmailViewModel email
                                         )
        {
            Administradora = administradora;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }
        protected AdministradoraDtoViewModel()
        {
        }
        public AdministradoraViewModel Administradora { get; private set; }
        public AdministradoraEnderecoViewModel Endereco { get; private set; }
        public AdministradoraTelefoneViewModel Telefone { get; private set; }
        public AdministradoraEmailViewModel Email { get; private set; }
    }
}
