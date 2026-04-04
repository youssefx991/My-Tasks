let name, age, gender, favColor, visits;

window.onload = function () {
    
    function saveCookies(){
        setCookie("name", name, new Date());
        setCookie("age", age, new Date());
        setCookie("gender", gender, new Date());
        setCookie("favColor", favColor, new Date());
        visits  = getCookie("visits");
        if (visits == null)
            setCookie("visits", 0, new Date());
    }
    function readData() {
        name = document.getElementById("name").value
        age = document.getElementById("age").value
        gender = document.getElementById("male_rb").checked ? "male" : "female";
        favColor = document.getElementById("fav_color_sb").value;

        if (name && age && gender && favColor)
            return true;
        else 
            return false;
    }
    document.getElementById("submit_btn").onclick = function () {
        if (!readData())
            alert("Please fill all fields first");
        else{
            saveCookies();
            document.location.href = "welcome.html";
        }
    }

    
}




