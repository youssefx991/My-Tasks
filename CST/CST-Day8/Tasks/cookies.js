function setCookie(name, value, expiry) {
    if (arguments.length < 2 || typeof name != 'string')
        throw new Error("Cannot Set Cookie - invalid parameters");
    if (expiry) {
        document.cookie = name + "=" + value + ";expires=" + expiry;
    }
    else
        document.cookie = name + "=" + value;
}

function getCookie(name) {
    if (!name || typeof name != 'string')
        throw new Error("Cannot Get Cookie - invalid parameters");
    let cookies = document.cookie.split("; ");
    for (let i = 0; i < cookies.length; i++) {
        let currName = cookies[i].split("=")[0];
        let currValue = cookies[i].split("=")[1];
        if (name == currName)
            return currValue;
    }

    return null;
}

function deleteCookie(name) {
    setCookie(name, "", new Date());
}

function allCookieList() {
    if (!document.cookie)
        return [];
    else
        return document.cookie.split("; ");
}

function hasCookie(name){
    return getCookie(name) != null;
}