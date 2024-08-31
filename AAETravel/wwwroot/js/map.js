function initMap() {
    var latitude = parseFloat(document.getElementById('latitude').innerText);
    var longitude = parseFloat(document.getElementById('longitude').innerText);
    var location = { lat: latitude, lng: longitude };

    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 4,
        center: location
    });

    var marker = new google.maps.Marker({
        position: location,
        map: map
    });
}

window.onload = initMap;
