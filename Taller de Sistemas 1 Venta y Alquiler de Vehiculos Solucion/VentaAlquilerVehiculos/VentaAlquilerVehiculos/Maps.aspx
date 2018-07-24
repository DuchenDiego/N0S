<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Maps.aspx.cs" Inherits="VentaAlquilerVehiculos.Maps" %>

<!DOCTYPE html>
<html lang = "en">
<head>
    <style type="text/css">
        html{height: 100%}
        body{height: 100%; margin: 0; padding: 0}
        #map-canvas{height: 100%}
    </style>
    <title>Oficinas N2O</title>
    <script src = "https://maps.googleapis.com/maps/api/js?key=AIzaSyB6umA4vQE6zY_G6gZzl_GKAFUmd1vwoqY">
    </script>
    <script>
        function initialize() {
            var mapOptions = {
                center: new google.maps.LatLng(-16.5053954, -68.1180668),
                zoom: 15,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(
                      document.getElementById("map-canvas"),
                      mapOptions);
            var myLatLng = new google.maps.LatLng(-16.5053954, -68.1180668)
            var marker = new google.maps.Marker({
                position: myLatLng,
                map: map,
                title: 'Venta y Alquiler N2O'
            });
        }

        google.maps.event.addDomListener(window, 'load', initialize);
        </script>
</head>
<body>
    <div id = "map-canvas">
    </div>
</body>
</html>