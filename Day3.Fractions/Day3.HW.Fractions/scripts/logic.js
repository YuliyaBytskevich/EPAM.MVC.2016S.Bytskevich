$(document).ready(function () {

    var $headerWithFraction = $("h1");
    var $fieldContainer = $(".container.body-content");
    var $menuContainer = $(".navbar");

    if ($headerWithFraction.text() == "Fraction: Light") {
        $fieldContainer.addClass("light-field");
    }

});