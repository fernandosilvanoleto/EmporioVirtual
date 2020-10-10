$(document).ready(function () {

    MascaraCEP();
    AJAXCalcularFrete(false);

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
            OrquestradorDeAçõesProduto("diminuir", $(this));
            //var id = pai.find(".input_produto_id").val();
            //alert("diminuir + :" + id);

        } else if ($(this).hasClass("aumentar")) {
            OrquestradorDeAçõesProduto("aumentar", $(this));
            //var id = pai.find(".input_produto_id").val();
            //alert("aumentar + :" + id);            
        }
    });
});

$(document).ready(function () {
    $(".btn-calcular-frete").click(function (e) {

        AJAXCalcularFrete(true);
        e.preventDefault();

    });
});

function AJAXCalcularFrete(callByButton) {
    if (callByButton == false) {
        if ($.cookie('CarrinhoCEP') != undefined) {
            $(".cep").val($.cookie('Carrinho.CEP'));
        }
    }
    //alert("oi");
    var cep = $(".cep").val().replace(".", "").replace("-", "");
    $.removeCookie("Carrinho.TipoFrete");

    if (cep.length == 8) {
        //alert(cep);

        // CRIAR UM COOKIE PARA ARMAZENAR O CEP - 04/10/2020        
        $.cookie('CarrinhoCEP', $(".cep").val());

        // LIMPAR REGISTROS LÁ DO INDEX - CARRINHO
        $(".container-frete").html("<br /><img src='\\img\\\Loading.gif' />");

        $(".frete").text("R$ 0,00");
        $(".total_frete").text("R$ 0,00");

        // FAZER REQUISIÇÃO A AJAX
        $.ajax({
            type: "GET",
            url: "/Carrinho/CalcularFrete?cepDestino=" + cep,
            error: function (data) {
                MostrarMensagemDeErro("Ops! Tivemos um erro ao obter o frete ... " + data.Message);
                console.info(data);
            },
            success: function (data) {
                html = " ";

                for (var i = 0; i < data.length; i++) {
                    var TipoFrete = data[i].tipoFrete;
                    var Valor = data[i].valor;
                    var Prazo = data[i].prazo;

                    // CRIAR MENSAGEN NO INDEX - CARRINHOCONTROLLER
                    html += "<dl class=\"dlist - align\"><dt><input type=\"radio\" name=\"frete\" value=\"" + TipoFrete + "\" /> <input type=\"hidden\" name=\"valor\" value=\"" + Valor + "\" /> </dt><dd>" + TipoFrete + " -  " + numberToReal(Valor) + " (" + Prazo + " dias úteis  )</dd></dl>";
                }
                $(".container-frete").html(html);
                $(".container-frete").find("input[type=radio]").change(function () {
                    var valorFrete = parseFloat($(this).parent().find("input[type=hidden]").val());

                    $.cookie("Carrinho.TipoFrete", $(this).val());

                    $(".frete").text(numberToReal(valorFrete));        

                    var subTotal = parseFloat($(".subtotal_sub").text().replace("R$", "").replace(".", "").replace(",", "."));
                   
                    var total_frete = valorFrete += subTotal;

                    $(".total_frete").text(numberToReal(total_frete));
                });
                //console.info(data);
            }
        });
    }
    else {
        if (callByButton == true) {
            // SERVE PARA QUANDO FOR ACESSAR A PÁGINA DE CARRINHO DE PRIMEIRA, NÃO APARECER ESSA MENSAGEM
            // SÓ APARECE ESSA MENSAGEM, QUANDO CONTINUAR A COMPRA E NÃO PASSAR O CEP CORRETAMENTE
            $(".container-frete").html("");
            MostrarMensagemDeErro("Digite o CEP, para calcular frete!");
        }        
    }

}

function OrquestradorDeAçõesProduto(operacao, botao) {
    //TODA VEZ QUE CLICAR, CHAMAR ESSA FUNÇÃO
    OcultarMensagemDeErro();

    // CARREGAMENTO DOS VALORES
    var pai = botao.parent().parent().parent();

    var produtoId = pai.find(".input_produto_id").val();
    var quantidadeEstoque = parseInt(pai.find(".input_quantidade_produto_estoque").val());
    var valorUnitario = parseFloat(pai.find(".input_valor_unitario").val().replace(",", "."));

    var campoQuantidadeProdutoCarrinho = pai.find(".inputQuantidadeProdutoCarrinho");
    var quantidadeProdutoCarrinho = parseInt(campoQuantidadeProdutoCarrinho.val());

    var campoValor = botao.parent().parent().parent().parent().parent().find(".price");

    var produto = new ProdutoQuantidadeValor(produtoId, quantidadeEstoque, valorUnitario, quantidadeProdutoCarrinho, 0, campoQuantidadeProdutoCarrinho, campoValor);

    // CHAMADA DE MÉTODO   
    AlteracaoVisuaisProdutoCarrinho(produto, operacao);

    //ATUALIZAR O SUBTOTAL

};

function AlteracaoVisuaisProdutoCarrinho(produto, operacao) {
    if (operacao == "aumentar") {

        /*if (produto.quantidadeProdutoCarrinhoAntiga >= produto.quantidadeEstoque) {
            //NÃO PODE AUMENTAR
            alert("Ops! Não temos estoque suficiente que você deseja comprar!");
        } else */{
            produto.quantidadeProdutoCarrinhoNova = produto.quantidadeProdutoCarrinhoAntiga + 1;

            AtualizarQuantidadeEValor(produto);

            AjaxAlterarQuantidadeProduto(produto);

        }

    } else if (operacao == "diminuir") {
       /* if (produto.quantidadeProdutoCarrinhoAntiga == 1) {
            alert("Ops! Caso não deseje esse produto, remover!!!");
       }
        else  */{

            produto.quantidadeProdutoCarrinhoNova = produto.quantidadeProdutoCarrinhoAntiga - 1;

            AtualizarQuantidadeEValor(produto);

            AjaxAlterarQuantidadeProduto(produto);

        }
    }
}

function AtualizarQuantidadeEValor(produto) {
    produto.campoQuantidadeProdutoCarrinho.val(produto.quantidadeProdutoCarrinhoNova);

    //valorUnitario = parseFloat(valorUnitario);
    //quantidadeProdutoCarrinho = parseFloat(quantidadeProdutoCarrinho);

    var resultado = produto.valorUnitario * produto.quantidadeProdutoCarrinhoNova;

    produto.campoValor.text(numberToReal(resultado));

    // CRIADO EM 17/09/2020 :: ATUALIZA O SUBTOTAL DO INDEX/Carrinho/View
    AtualizarSubTotal();
}

function AtualizarSubTotal() {
    var SubTotal = 0.0;

    var TagValorPrice_Sub = $(".price");

    //console.log(TagValorPrice_Sub.text());

    TagValorPrice_Sub.each(function () {

        var valorReais = parseFloat($(this).text().replace("R$", "").replace(".", "").replace(" ", "").replace(",", "."));
        // VERIFICAR SE OS VALORES PASSADOS É NUMBER MESMO HEHEHEHE
        if (!Number.isNaN(valorReais)) {
            SubTotal = SubTotal + valorReais;
            //console.log(SubTotal);
        }

    })
    //console.log(parseFloat(SubTotal));
    $(".subtotal_sub").text(numberToReal(SubTotal));

}

function numberToReal(numero) {
    var numero = numero.toFixed(2).split('.');
    numero[0] = "R$" + numero[0].split(/(?=(?:...)*$)/).join('.');
    return numero.join(',');
}

function AjaxAlterarQuantidadeProduto(produto) {
    $.ajax({
        type: "GET",
        url: "/Carrinho/AlterarQuantidade?id=" + produto.produtoId + "&quantidade=" + produto.quantidadeProdutoCarrinhoNova,
        error: function (data) {

            MostrarMensagemDeErro(data.responseJSON.mensagem);

            //ROLLBACK
            produto.quantidadeProdutoCarrinhoNova = produto.quantidadeProdutoCarrinhoAntiga;
            AtualizarQuantidadeEValor(produto);

        },
        success: function (data) {
            // CHAMAR PARA CALCULAR O FRETE
            AJAXCalcularFrete(false);
        }
    });
}

function MostrarMensagemDeErro(mensagem) {
    $(".alert-danger").css("display", "block");
    $(".alert-danger").text(mensagem);
}

function OcultarMensagemDeErro() {
    $(".alert-danger").css("display", "none");
}

function MascaraCEP() {
    $(".cep").mask("00.000-000");
}



/*
 * 
 *  --------------------- CLASSES ---------------
 */

class ProdutoQuantidadeValor {
    constructor(produtoId, quantidadeEstoque, valorUnitario, quantidadeProdutoCarrinhoAntiga, quantidadeProdutoCarrinhoNova, campoQuantidadeProdutoCarrinho, campoValor) {
        this.produtoId = produtoId;
        this.quantidadeEstoque = quantidadeEstoque;
        this.valorUnitario = valorUnitario;

        this.quantidadeProdutoCarrinhoAntiga = quantidadeProdutoCarrinhoAntiga;
        this.quantidadeProdutoCarrinhoNova = quantidadeProdutoCarrinhoNova;

        this.campoQuantidadeProdutoCarrinho = campoQuantidadeProdutoCarrinho;
        this.campoValor = campoValor;
    }
}

