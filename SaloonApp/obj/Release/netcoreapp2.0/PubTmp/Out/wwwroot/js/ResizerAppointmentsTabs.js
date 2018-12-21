var prevPageHeight = 0;
var prevPageWidth = 0;
function setHeight() {
    $('#resize').height(window.innerHeight * 0.7);
    prevPageHeight = window.innerHeight;
}
function setWidth() {
    $('#resize').width($('#targetWidth').width);
    prevPageWidth = window.innerWidth;
}

setInterval(function () {

    if (window.innerHeight != prevPageHeight) {
        setHeight();
    }
    if (window.innerWidth != prevPageWidth) {
        setWidth();
    }
}, 500);

setHeight();
setWidth();


function myfunction() {
    var date = $('#party').val().split('-');
    var year = date[0];
    var month = date[1];
    var day = date[2];
    var a = month + "/" + day + "/" + year;
    var b = 'http://app1-74.apphb.com/Appointment/AllAppointments?date=' + a;
    window.location.href = b;
}