$(document).ready(function () {
    $("#qtde").on("keyup change", function () {
        CalculoValorTotal();
    });
    (function ($) {
        $(function () {
            $('#numeroCartao').mask("0000 0000 0000 0000");
            $('#dtValidadeCartao').mask("00/00");
            $('#codSeguranca').mask("000");
            $('#cpf').mask("000.000.000-00");
            $('#qtde').mask("000");
        });
    })(jQuery);
});

function CalculoValorTotal() {
    var qtde = $('#qtde').val();
    var price = parseFloat($('#price').val());

    if (qtde == "" && price == "") {
        $("#total").val("");
        return;
    }
    else {
        let resultado = qtde * price;
        $("#total").val(resultado.toFixed(2));
    }
}