var x = document.cookie

if (getCookie("csb") != "ready") {
    function preloaded() {

        console.log('page is fully loaded');
        document.cookie = "csb=ready";
        alert("Client Side Blazor is now available refresh to use");
    }
}

function reset() {
    document.cookie = "csb=notready";
}

function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}