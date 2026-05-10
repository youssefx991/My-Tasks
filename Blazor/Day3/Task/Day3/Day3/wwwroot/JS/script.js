//alert("Hello from JavaScript!");

window.ShowJSAlert = function () {
    alert("Alert from JavaScript!");
}

window.InvokeDotNetMethod = function () {

    DotNet.invokeMethodAsync(
        'Day3',
        'GetRandomNumberBetween',
        1,
        100
    ).then(result => {

        alert(`Random number between 1 and 100: ${result}`);
    });
}