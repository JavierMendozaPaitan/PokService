// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function ftest(name) {
    document.getElementById(name).innerHTML = "changed!";
}
function ftest(name, txt) {
    document.getElementById(name).innerHTML = txt;
}
function fdate(obj) {
    obj.innerHTML = Date();
}
function farrs() {
    var fruits = ["Bama", "ORamge", "Lemon", "Cherry"];
    var text = "<ul>";
    for (var i = 0; i < fruits.length; i++) {
        text += "<li>" + fruits[i] + "</li>";
    }
    text += "</ul>";

    return text;
}
function ftarr(name) {
    var txt = farrs();
    ftest(name, txt);
}
function fchk(iname, oname) {
    var iobj = document.getElementById(iname);
    if (!iobj.checkValidity()) {
        ftest(oname, iobj.validationMessage);
    }
    else {
        ftest(oname, "Input Ok!");
    }
}