document.getElementById('btn1').addEventListener('click', function () {
  var val = document.getElementById('txt1').value
  var today = new Date()
  today.setMonth(today.getMonth() + 1)
  //create
  //session
  setCookie('userName', val)
  //persistent
  // document.cookie = "userAge=10;expires=" + today;
  setCookie('userAge', 10, today)

  //read
  // console.log(document.cookie);

  // document.cookie = "userAge=;";
})
