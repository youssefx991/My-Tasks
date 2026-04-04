function wait5sec(cb){
    setTimeout(cb, 5000);
}


wait5sec(function(){
    click_register();
})

function click_register(){
    let name = document.getElementById("name").value;
    let title = document.getElementById("title").value;
    let address = document.getElementById("address").value;
    let email = document.getElementById("email").value;
    let mobile = document.getElementById("mobile").value;

    let genders = document.getElementsByName("gender");
    let gender;
    for (let i=0; i<2; i++){
        if (genders[i].checked){
            gender = genders[i].value;
            break;
        }
    }
    
    window.location.assign(`welcome.html?name=${encodeURIComponent(name)}&title=${encodeURIComponent(title)}&address=${encodeURIComponent(address)}&gender=${gender}&email=${encodeURIComponent(email)}&mobile=${mobile}`);

}

