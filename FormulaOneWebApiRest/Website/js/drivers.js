"use strict"

var pos;

$(document).ready(function () {
    var app = new Vue({
        el: '#panel',
        data: function () {
            return {
                drivers: [],
                driverDetails: []
            }
        },
        methods: {
            ShowDrivers: function () {
                var uri = '../../api/Drivers';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.drivers = data;
                    });
            },
            ShowDriverDetails: function (driverId) {
                var uri = '../../api/Drivers/' + driverId + '/details';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        data.Dob = data.Dob.substring(0, 10);
                        this.driverDetails = data;
                    });
            }
        },
        filters: {
            SubStr: function (str) {
                return str.substring(0, 10);
            }
        },
        beforeMount() {
            this.ShowDrivers();
        }
    });
});