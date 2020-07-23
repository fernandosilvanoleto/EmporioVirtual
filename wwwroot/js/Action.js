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
        $(this).parent().parent().find(".input-file").click();
        //alert('oi');
    });

    $(".btn-Imagens-excluir").click(function () {
        var CampoHidden = $(this).parent().find("input[name=imagem]");
        var Imagem = $(this).parent().find(".img-upload");
        var BtnExcluir = $(this).parent().find(".btn-Imagens-excluir");
        var InputFile = $(this).parent().find(".input-file");

        $.ajax({
            type: "GET",
            url: "/Colaborador/Imagem/Deletar?caminho=" + CampoHidden.val(),
            error: function () {
                alert("Teve erro ao deletar o arquivo");
            },
            success: function (data) {
                Imagem.attr("src", "/img/Img_Padrao.png");
                alert("Arquivo excluído com sucesso!!!");
                BtnExcluir.addClass("btn-ocultar");
                CampoHidden.val("");
                InputFile.val("");
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
        var BtnExcluir = $(this).parent().find(".btn-Imagens-excluir");
        //TODO -Requisição Ajax enviando o formulário para model

        //APRESENTA IMAGEM LOADING
        Imagem.attr("src", "/img/Loading.gif");
        Imagem.addClass("thumb");

        // IR COM TOKEN DO REQUEST TOKEN, ISSO É CAUSADO POR CAUSA DO ColaboradorAutorizacao E DO ValidateAntiForgeryToken e dos ataques CRSF
        var AntiToken = $('[name=__RequestVerificationToken]').val();

        $.ajax({
            type: "POST",
            url: "/Colaborador/Imagem/Armazenar",
            headers: {
                "RequestVerificationToken": AntiToken
            },
            data: formulario,
            contentType: false,
            processData: false,
            error: function () {
                alert("Teve erro no envio do arquivo");
                Imagem.attr("src", "/img/Img_Padrao.png");
                Imagem.removeClass("thumb");
            },
            success: function (data) {
                var caminho = data.caminho;
                Imagem.attr("src", caminho);
                Imagem.removeClass("thumb");
                CampoHidden.val(caminho);
                BtnExcluir.removeClass("btn-ocultar");
            }
        });
    });
});