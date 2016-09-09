$(document).ready(function () {

    var $headerWithFaction = $("h1");
    var $body = $("body");
    var $menu = $(".navbar");

    if ($headerWithFaction.text() == "Faction: Light") {
        removeClasses("neutral", "dark");
        $body.addClass("light-field");    
        $menu.addClass("light-menu");
    }
    else if ($headerWithFaction.text() == "Faction: Dark") {
        removeClasses("neutral", "light");
        $body.addClass("dark-field");
        $menu.addClass("dark-menu");
    }
    else {
        removeClasses("light", "dark");
        $body.addClass("neutral-field");
        $menu.addClass("neutral-menu");
    }
    

    function removeClasses(first, second) {
        $body.removeClass(first + "-field");
        $menu.removeClass(first + "-menu");
        $body.removeClass(second + "-field");
        $menu.removeClass(second + "-menu");
    }
});