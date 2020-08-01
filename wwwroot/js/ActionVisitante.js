$(document).ready(function () {
    $("#ordenacao").change(function () {
        //TODO - Redirecionar para a tela Home/Index passando as QueryString de Ordenação e mantendo a Página de pesquisa
        var Pagina = 1;
        var Pesquisa = "";
        var Ordenacao = $(this).val();

        MoverScrollOrdenacao();

        var QueryString = new URLSearchParams(window.location.search);
        if (QueryString.has("pagina")) {
            Pagina = QueryString.get("pagina");
        }

        if (QueryString.has("pesquisa")) {
            Pesquisa = QueryString.get("pesquisa");
        }

        // gerar a url
        // não precisa, mas deixa ela aqui
        var URL = window.location.hostname + "//" + window.location.port + window.location.pathname;

        var URLComparametros = "?pagina=" + Pagina + "&pesquisa=" + Pesquisa + "&ordenacao=" + Ordenacao + "#posicao-produto";

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