
// <polygon points="150,10 150,190 50,190" style="fill: red; stroke:black"/>        

document.body.onload = function () {
    // let c1 = { x: 150, y: 10 }
    // let c2 = { x: 150, y: 190 }
    // let c3 = { x: 50, y: 100 }

    let a = document.createElement('span');
    a.innerHTML = 'a';
    a.style.position = 'absolute';
    a.style.left = 100 + 'px';
    a.style.top = 280 + 'px';
    document.body.appendChild(a);

    
    let b = document.createElement('span');
    b.innerHTML = 'b';
    b.style.position = 'absolute';
    b.style.left = 175 + 'px';
    b.style.top = 190 + 'px';
    document.body.appendChild(b);

    let c = document.createElement('span');
    c.innerHTML = 'c';
    c.style.position = 'absolute';
    c.style.left = 70 + 'px';
    c.style.top = 190 + 'px';
    document.body.appendChild(c);






}