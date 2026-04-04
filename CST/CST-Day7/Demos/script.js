// elem.onclick="fun()"
// elem.onevent=function(){}

onload = function () {
  //
  this.document.getElementsByTagName('a')[0].onclick = function () {
    alert('click event on anchor tag')
    // return false
    location.href(undefined)
  }
  ////////
  txtElement = document.getElementById('txt1')
  divElement = document.getElementById('div1Elem')

  document.getElementById('disp').onclick = function () {
    console.log(this.value)

    var sel = document.getElementById('menu')
    // var idx = sel.selectedIndex;
    // console.log(sel.options[idx].text);

    let str = ''

    for (let i = 0; i < sel.options.length; i++) {
      if (sel.options[i].selected) {
        str += sel.options[i].text + ' '
      }
    }

    divElement.innerText = str
  }
}
var displayNum = function (elem) {
  txtElement.value += elem.value.trim()
}

var txtElement

var divElement

function displayContent (txtElem) {
  // var val = document.getElementById("txt1").value;
  divElement.innerHTML = txtElem.value
}
