onload = function(){

    // if(!this.window.localStorage){
        var script = this.document.createElement('script')
        script.src = 'localStorageLib.js'
        this.document.getElementsByTagName('head')[0].appendChild(script)
    // }

    this.document.getElementById('btn').onclick=function(){
        var usrnm = document.getElementById('usrnm').value
        localStorage.setItem('usrnm',usrnm)
        sessionStorage.setItem('age',20)
    }
}