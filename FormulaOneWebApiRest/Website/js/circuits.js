"use strict"

$(document).ready(function () {
    var app = new Vue({
        el: '#panel',
        data: function () {
            return {
                circuits: [],
                circuitDetails: []
            }
        },
        methods: {
            ShowCircuits: function () {
                var uri = '../../api/Circuits';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.circuits = data;
                    });
            },
            ShowCircuitDetails: function (circuitId) {
                var uri = '../../api/Circuits/' + circuitId + '/details';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        data.RaceGrandPrixDate = data.RaceGrandPrixDate.substring(0, 10);
                        this.circuitDetails = data;
                    });
            }
        },
        filters: {
            SubStr: function (str) {
                return str.substring(0, 10);
            }
        },
        beforeMount() {
            this.ShowCircuits();
        }
    });
});