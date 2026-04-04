function setCookie (cookieName, cookieValue, expireVal) {
  if (expireVal)
    document.cookie = cookieName + '=' + cookieValue + ';expires=' + expireVal
  else document.cookie = cookieName + '=' + cookieValue
}

function adding () {
  var sum = 0
  ///////////arguments
  for (let i = 0; i < arguments.length; i++) {
    if (typeof arguments[i] == 'number') sum += arguments[i]
    else throw new Error('invalid param')
  }

  return sum //a+b
}
