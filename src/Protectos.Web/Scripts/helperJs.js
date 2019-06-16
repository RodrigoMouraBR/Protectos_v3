$(document).ready(function () {

    $('.edit-cnpj').focusout(function () {

        var cnpj = this.value;

        if (cnpj !== "") {

            $.ajax({
                type: 'GET',
                url: '/base/ObterEmpresaPorCNPJ/',
                data: { id: cnpj },
                success: function (data) {

                    var empresa = data.data;

                    document.querySelector('.edit-razao-social').value = empresa.Nome !== null ? empresa.Nome : '';
                    document.querySelector('.edit-nome-fantasia').value = empresa.Fantasia !== null ? empresa.Fantasia : '';
                    document.querySelector('.edit-logradouro').value = empresa.Logradouro !== null ? empresa.Logradouro : '';
                    document.querySelector('.edit-bairro').value = empresa.Bairro !== null ? empresa.Bairro : '';
                    document.querySelector('.edit-cidade').value = empresa.Municipio !== null ? empresa.Municipio : '';
                    document.querySelector('.edit-complemento').value = empresa.Complemento !== null ? empresa.Complemento : '';
                    document.querySelector('.edit-numero').value = empresa.Numero !== null ? empresa.Numero : '';
                    document.querySelector('.edit-uf').value = empresa.Uf !== null ? empresa.Uf : '';
                    document.querySelector('.edit-cep').value = empresa.Cep !== null ? empresa.Cep.replace(/[^0-9]/g, '') : '';

                    document.querySelector('.edit-email').value = empresa.Email !== null ? empresa.Email : '';
                    if (empresa.Email !== null) {
                        document.querySelector('.edit-tipo-email option:checked').value = 2;
                        document.querySelector('.edit-tipo-email option:checked').text = "Empresarial";
                    }

                }
            });
        } else
            return false;
    });


});