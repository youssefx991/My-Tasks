function task1(){
    while (true)
    {
        let input = prompt("enter string");
        let char = prompt("enter character to count");
        let choice = confirm("do you want to be case sensisitve?");
        let count=0;

        if (char.length == 1){
            if (!choice)
            {
                input = input.toLowerCase();
                char = char.toLowerCase();
            }

            for (let i=0; i<input.length; i++){
                if (input[i] == char)
                    count++;
            }

            console.log(`number of occurances of ${char} = ${count}`);
            break;
            
        }
        else 
        {
            console.log("ERROR - enter allowed inputs only");
            continue;
        }
   }
}

function task2(){
    while (true){
        let input = prompt("enter string to check for palindrome");
        let choice = confirm("do you want to be case sensisitve?");
        let pal = true;
        if (!choice)
            input = input.toLowerCase();

        input = input.split(" ").join("");

        let i=0, j=input.length - 1;
        while (i<=j)// radar -- rad dar
        {
            if (input[i] != input[j]){
                pal = false;
                break;
            }

            i++;
            j--;
        }

        if (pal)
            console.log("String is palindrom");
        else
            console.log("String is not palindrom");
    }
}

function task3(){
    let input = prompt("enter string to find largest word in");
    let words = input.split(" ");
    let maxWord="";

    for (let i=0; i<words.length; i++){
        if (words[i].length >= maxWord.length)
            maxWord = words[i];
    }

    console.log(`largest word = ${maxWord}`);
    
}

function task4(){
    while (true){
        let name = prompt("Enter your name");
        let phone = prompt("Enter your phone number");
        let mobile = prompt("Enter your mobile number");
        let email = prompt("Enter your email");

        let re_name=name.match(/^[a-zA-Z]+$/igm);
        if (re_name == null)
            console.log("re name null");
            
        let re_phone=phone.match(/^[0-9]{8}$/igm);
        if (re_phone == null)
            console.log("re_phone null");
        let re_mobile=mobile.match(/^(010|011|012)[0-9]{8}$/igm);
        if (re_mobile == null)
            console.log("re_mobile null");
        let re_email = email.match(/^[a-zA-Z]+[a-zA-Z0-9.]*@[a-zA-Z0-9.]+.com$/igm);
        if (re_email == null)
            console.log("re_email null");
        
        if (re_name != null && re_phone != null && re_mobile != null && re_email != null){
            let color = prompt("Enter color (red / green / blue)");
            color = color.toLowerCase();
            if (color == 'red' || color == 'green' || color == 'blue'){
                console.log('%cUser Choice: ' + color, `color: ${color};`)
            }else {
                console.log("ERROR - data not foramtted correctly");
                continue;       
            }
        }
        else {
            console.log("ERROR - data not foramtted correctly");
            continue;
        }
    }
}
