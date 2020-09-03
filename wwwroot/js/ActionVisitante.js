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
        //var pai = $(this).parent().parent().parent();

        if ($(this).hasClass("diminuir")) {
            LogicaMudarQuantidadeProdutoUnitarioCarrinho("diminuir", $(this));
            //var id = pai.find(".input_produto_id").val();
            //alert("diminuir + :" + id);

        } else if ($(this).hasClass("aumentar")) {
            LogicaMudarQuantidadeProdutoUnitarioCarrinho("aumentar", $(this));
            //var id = pai.find(".input_produto_id").val();
            //alert("aumentar + :" + id);            
        }
    });
});

function LogicaMudarQuantidadeProdutoUnitarioCarrinho(operacao, botao) {
    var pai = botao.parent().parent().parent();

    var produtoId = pai.find(".input_produto_id").val();
    var quantidadeEstoque = parseInt(pai.find(".input_quantidade_produto_estoque").val());
    var valorUnitario = parseFloat( pai.find(".input_valor_unitario").val().replace(",", ".") );    

    var campoQuantidadeProdutoCarrinho = pai.find(".inputQuantidadeProdutoCarrinho");    
    var quantidadeProdutoCarrinho = parseInt(campoQuantidadeProdutoCarrinho.val());

    var campoValor = botao.parent().parent().parent().parent().parent().find(".price");

    if (operacao == "aumentar") {

        if (quantidadeProdutoCarrinho >= quantidadeEstoque) {
            //NÃO PODE AUMENTAR
            alert("Ops! Não temos estoque suficiente que você deseja comprar!");
        } else {
            quantidadeProdutoCarrinho += 1;

            campoQuantidadeProdutoCarrinho.val(quantidadeProdutoCarrinho);

            valorUnitario = parseFloat(valorUnitario);
            quantidadeProdutoCarrinho = parseFloat(quantidadeProdutoCarrinho);

            var resultado = valorUnitario * quantidadeProdutoCarrinho;

            campoValor.text(numberToReal(resultado));
        }
        
    } else if (operacao == "diminuir") {
        alert(quantidadeProdutoCarrinho);
        if (quantidadeProdutoCarrinho == 1)
        {
            alert("Ops! Caso não deseje esse produto, remover!!!");
        }
        else
        {

            quantidadeProdutoCarrinho -= 1;

            campoQuantidadeProdutoCarrinho.val(quantidadeProdutoCarrinho);

            valorUnitario = parseFloat(valorUnitario);
            quantidadeProdutoCarrinho = parseFloat(quantidadeProdutoCarrinho);

            var resultado = valorUnitario * quantidadeProdutoCarrinho;

            campoValor.text(numberToReal(resultado));

        }
    }

    //ATUALIZAR O SUBTOTAL

};


function numberToReal(numero) {
    var numero = numero.toFixed(2).split('.');
    numero[0] = "R$" + numero[0].split(/(?=(?:...)*$)/).join('.');
    return numero.join(',');
}