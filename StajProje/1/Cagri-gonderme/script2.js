$("#yaz").load("/1/Cagri-gonderme/servis-notlari.html");

var cagri = document.getElementById('cagri')
cagri.addEventListener("click", () => {
    location.href = "/Default/Cagrilar";
});

var but = document.getElementById('but')
but.addEventListener("click", () => {
    $("#yaz").load("/1/Cagri-gonderme/servis-notlari.html");
});

var but4 = document.getElementById('but4')
but4.addEventListener("click", () => {
    $("#yaz").load("/1/Cagri-gonderme/ekler.html");
});