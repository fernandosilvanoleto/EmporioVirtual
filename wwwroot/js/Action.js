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

    $(".input-file").change(function () {
        // FORMULÁRIO DE DADOS VIA JAVASCRIPT
        var Binary = $(this)[0].files[0]; // campo selecionado
        var formulario = new FormData();
        formulario.append("file", Binary);

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
                alert("Arquivo enviado com sucesso!!!" + data.caminho )
            }
        });
    });
});