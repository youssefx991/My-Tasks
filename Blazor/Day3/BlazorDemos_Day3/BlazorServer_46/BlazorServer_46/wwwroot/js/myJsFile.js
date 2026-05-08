function GetName()
{
    alert("Hello from JavaScript ya SD 46...!");
}


function GiveMeRandomNumber() {

    DotNet.invokeMethodAsync("BlazorServer_46", "GenerateRandomInt")
        .then(result => {
            alert("Random number from C#: " + result);
        });
}