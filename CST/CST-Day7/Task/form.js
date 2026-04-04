let name;
let title;
let address;
let email;
let mobile; 
let gender;
let custEvent;

window.onload = function(){
    

    setInterval(function() {
        name = document.getElementById("name").value;
        title = document.getElementById("title").value;
        address = document.getElementById("address").value;
        email = document.getElementById("email").value;
        mobile = document.getElementById("mobile").value;

        let genders = document.getElementsByName("gender");
        gender;
        for (let i=0; i<2; i++){
            if (genders[i].checked){
                gender = genders[i].value;
                break;
            }
        }

        if (
            name == '' &&
            title == '' &&
            address == '' &&
            email == '' &&
            mobile == '' &&
            gender == undefined
        ){
            console.log("custevent should fire");
            
            custEvent = new CustomEvent("custEvent")
            document.dispatchEvent(custEvent);
        }
        
    }, 30000);

    document.addEventListener("custEvent", function(){
        alert("30 seconds passed and you haven't entered any data");
    })
    document.getElementById("form_id").addEventListener("submit", function(event){
        let confirm_submit = confirm("Confirm Submit?");
        if (!confirm_submit)
            event.preventDefault();
    });

};