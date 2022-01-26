$(document).ready(function () {

    $("#hide_content").click(() => {
        $(".contain").hide();
    });

    $("#show_content").click(() => {
        $(".contain").show();
    })

    const operationMap = {
        "+": (x, y) => x + y,
        "-": (x, y) => x - y,
        "*": (x, y) => x * y,
        "/": (x, y) => x / y,
        "%": (x, y) => x % y,
      };
    
      $(".btn-calc").on("click", () => {
        const op = $(this).data("op");
        const x = parseFloat($("#number1").val());
        const y = parseFloat($("#number2").val());
        const result = operationMap[op](x, y);
        $("#result").val(result);
      });

});