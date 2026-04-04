let params = new URLSearchParams(window.location.search)

console.log(params);
let name = params.get("name");
let title = params.get("title");
let address = params.get("address");
let email = params.get("email");
let mobile = params.get("mobile");
let gender = params.get("gender");

document.body.innerHTML += (`<h1>Welcome ${title}. ${name}</h1>`);
document.body.innerHTML += (`<p>Address: ${address}</p>`);
document.body.innerHTML += (`<p>Gender: ${gender}</p>`);
document.body.innerHTML += (`<p>Email: ${email}</p>`);
document.body.innerHTML += (`<p>Mobile: ${mobile}</p>`);

let browser = navigator.userAgentData.brands[0].brand.toLowerCase();
if (!browser.includes("google chrome")){
    document.body.innerHTML += (`<h2>We recommend using Chrome</h2>`);
}