$(document).ready(function () {
    $(".btn-danger").click(function (e) {
        var resultado = confirm("Tem certeza que deseja realizar esta operação?");

        if (resultado == false) {
            e.preventDefault();
        }
    });
    $('.dinheiro').mask('000.000.000.000.000,00', { reverse: true });
});

$(document).ready(function () {
    $(".img-upload").click(function () {
        $(this).parent().find(".input-file").click();
        //alert('oi');
    });
    $(".btn-Imagens-excluir").click(function () {
        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");

        $.ajax({
            type: "GET",
            url: "/Colaborador/Imagem/Deletar?caminho=" + CampoHidden.val(),
            error: function () {
                alert("Teve erro ao deletar o arquivo");
            },
            success: function (data) {
                Imagem.attr("src", "/img/Img_Padrao.png");
                alert("Arquivo excluído com sucesso!!!");
            }
        });
    });

    $(".input-file").change(function () {
        // FORMULÁRIO DE DADOS VIA JAVASCRIPT
        var Binary = $(this)[0].files[0]; // campo selecionado
        var formulario = new FormData();
        formulario.append("file", Binary);

        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");
        //TODO -Requisição Ajax enviando o formulário para model
        $.ajax({
            type: "POST",
            url: "/Colaborador/Imagem/Armazenar",
            data: formulario,
            contentType: false,
            processData: false,
            error: function () {
                alert("Teve erro no envio do arquivo");
            },
            success: function (data) {
                var caminho = data.caminho;
                Imagem.attr("src", caminho);
                CampoHidden.val(caminho);
            }
        });
    });
});