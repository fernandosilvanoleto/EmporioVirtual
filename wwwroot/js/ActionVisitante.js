$(document).ready(function () {
    $("#ordenacao").change(function () {
        //TODO - Redirecionar para a tela Home/Index passando as QueryString de Ordenação e mantendo a Página de pesquisa
        var Pagina = 1;
        var Pesquisa = "";
        var Ordenacao = $(this).val();
        var Fragmento = "#posicao-produto";

        MoverScrollOrdenacao();
        MudarImagemPrincipalProduto();

        var QueryString = new URLSearchParams(window.location.search);
        if (QueryString.has("pagina")) {
            Pagina = QueryString.get("pagina");
        }

        if (QueryString.has("pesquisa")) {
            Pesquisa = QueryString.get("pesquisa");
        }

        if ($("#breadcrumb").length > 0) {
            Fragmento = "";
        }

        // gerar a url
        // não precisa, mas deixa ela aqui
        var URL = window.location.hostname + "//" + window.location.port + window.location.pathname;

        var URLComparametros = "?pagina=" + Pagina + "&pesquisa=" + Pesquisa + "&ordenacao=" + Ordenacao + Fragmento;

        //alert(URLComparametros);

        window.location.href = URLComparametros;

    });
});

function MoverScrollOrdenacao() {
    if (window.location.hash.length > 0) {
        var hash = window.location.hash;
        if (hash == "#posicao-produto") {            
            window.scrollBy(0, 450);
        }
    }
}

$(document).ready(function () {
    $(".img-small-wrap img").click(function () {
        var Caminho = $(this).attr("src");
        $(".img-big-wrap img").attr("src", Caminho);
        $(".img-big-wrap a").attr("href", Caminho);
    });
});

$(document).ready(function () {
    $("#code_shopp .btn-primary").click(function () {
        var pai = $(this).parent().parent().parent();
        if ($(this).hasClass("diminuir")) {

            var id = pai.find(".input_produto_id").val();

            alert("diminuir + :" + id);

        } else if ($(this).hasClass("aumentar")) {
            var id = pai.find(".input_produto_id").val();

            alert("aumentar + :" + id);            
        }
    });
});