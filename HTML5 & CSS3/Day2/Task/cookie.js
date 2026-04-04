
document.body.onload = function () {


    let storageObj = {
        setItem: function (key, value) { return cookieLib.setItem(key, value); },
        getItem: function (key) { return cookieLib.getItem(key); },
        removeItem: function (key) { return cookieLib.removeItem(key); },
        clear: function () { return cookieLib.clear(); },
        get length() { return Object.keys(cookieLib._data).length; }
    }



    if (!Modernizr.localstorage) {
        alert("localStorage is not supported, using cookie-based storage instead.");
        window.localStorage = storageObj;
    }

    if (!Modernizr.sessionstorage) {
        alert("sessionStorage is not supported, using cookie-based storage instead.");
        window.sessionStorage = storageObj;
    }

    if (!Modernizr.webstorage) {
        alert("Web Storage is not supported, using cookie-based storage instead.");
        window.webstorage = storageObj;
    }


    document.getElementById("btn_save").onclick = function () {
        alert("Saving username using web storage...");
        var username = document.getElementById("username").value;
        var exists = window.webstorage.getItem(username);
        if (exists === null) {
            window.webstorage.setItem(username, true);
            alert("Username saved: " + window.webstorage.getItem(username));
        }
        else {
            alert("Username already exists: " + exists);
        }
    }
}