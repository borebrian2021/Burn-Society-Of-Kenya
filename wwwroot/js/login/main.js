//(function($) {

//	"use strict";


//})(jQuery);

$(document).ready(function () {
    $("#signup").fadeOut();
});
function signup() {
    $("#signup").show();
    $("#login").fadeOut();
}
function login() {
    $("#login").show();
    $("#signup").fadeOut();
}

$("#signupbutton").on("click", function () {

    fetch("/echo/json/",
        {
            method: "POST",
            body: data
        })
        .then(function (res) { return res.json(); })
        .then(function (data) { alert(JSON.stringify(data)) })
});