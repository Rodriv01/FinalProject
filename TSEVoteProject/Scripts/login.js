
function Login() {
    var ci = document.getElementById("Ci").value;

    $.getJSON("/api/voter")
        .done(function (data) {
            
        });
}