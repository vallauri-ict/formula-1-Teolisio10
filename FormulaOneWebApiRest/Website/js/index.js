"use strict"

$(document).ready(function () {
    var app = new Vue({
        el: '#panel',
        data: function () {
            return {
                drivers: [],
                teams: [],
                circuits: [],
                races: []
            }
        },
        methods: {
            ShowDrivers: function () {
                var uri = 'api/Drivers';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.drivers = data;
                    });
            },
            ShowTeams: function () {
                var uri = 'api/Teams';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.teams = data;
                    });
            },
            ShowCircuits: function () {
                var uri = 'api/Circuits';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.circuits = data;
                    });
            },
            ShowRaces: function () {
                var uri = 'api/Races';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.races = data;
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
            this.ShowTeams();
            this.ShowCircuits();
            this.ShowRaces();
        }
    });

});