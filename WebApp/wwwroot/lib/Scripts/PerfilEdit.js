$(document).ready(function () {

    $("#btnEditar").click(function () {
        var form = $('#__AjaxAntiForgeryForm');
        var token = $('input[name="__RequestVerificationToken"]', form).val();
        var perfil = new Object();
        perfil.NomePerfil = $("#NomePerfil").val();
        perfil.IdPerfil = $("#IdPerfil").val();
        if (perfil.NomePerfil) {
            $(".error").remove();
            perfil = JSON.stringify(perfil);
            var funcionalidades = JSON.stringify(getFunc());
            $.ajax({
                url: $(this).data('/Perfil/Edit'),
                type: 'POST',
                data: {
                    __RequestVerificationToken: token,
                    perfil: perfil,
                    Funcionalidades: funcionalidades
                },
                success: function (result) {
                    window.location.href = '/Perfil/Index';
                }
            });
            return false;
        } else {
            $(".error").remove();
            $('#NomePerfil').after('<span style="color:red;" class="error">O Campo nome é obrigatório</span>');
        }
    });
    function getPerfil() {

        return perfil;
    }

    function getFunc() {
        var funcionalidades = new Array();
        $("#editTableFun input[type=checkbox]:checked").each(function () {
            var IdFuncionalidade = ($(this).closest("tr").find('td:eq(0)').text().trim());
            var Nome = ($(this).closest("tr").find('td:eq(1)').text().trim());
            funcionalidades.push({ IdFuncionalidade });
        });
        return funcionalidades;
    }
});