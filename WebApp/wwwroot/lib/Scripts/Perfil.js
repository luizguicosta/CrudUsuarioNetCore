$(document).ready(function () {

    $("#btnSalvar").click(function () {
        var form = $('#__AjaxAntiForgeryForm');
        var token = $('input[name="__RequestVerificationToken"]', form).val();
        var perfil = JSON.stringify(getPerfil());
        var funcionalidades = JSON.stringify(getFunc());
        $.ajax({
            url: $(this).data('/Perfil/Create'),
            type: 'POST',
            data: {
                __RequestVerificationToken: token,
                perfil: perfil,
                Funcionalidades: funcionalidades
            },
            success: function (result) {
                alert(result.someValue);
            }
        });
        return false;
    });
    function getPerfil() {
        var perfil = new Object();
        perfil.NomePerfil = $("#NomePerfil").val();
        return perfil;
    }

    function getFunc() {
        var funcionalidades = new Array();
        $("#tablePerfilFunc input[type=checkbox]:checked").each(function () {
            var IdFuncionalidade = ($(this).closest("tr").find('td:eq(0)').text().trim());
            var Nome = ($(this).closest("tr").find('td:eq(1)').text().trim());
            funcionalidades.push({ IdFuncionalidade });
        });
        return funcionalidades;
    }
});