let male_img = "Task Resources/cookies/1.jpg";
let female_img = "Task Resources/cookies/2.jpg";
window.onload = function () {
    let visits = getCookie("visits");
    if (visits == null)
        setCookie("visits", 1, new Date());
    else
        setCookie("visits", Number(visits)+1, new Date());
    document.getElementById("name").innerText = getCookie("name");
    document.getElementById("name").style.color = getCookie("favColor");

    document.getElementById("visits").innerText = getCookie("visits");
    document.getElementById("visits").style.color = "red";

    document.getElementById("gender_image").src = getCookie("gender") == "male" ?  male_img : female_img;
}