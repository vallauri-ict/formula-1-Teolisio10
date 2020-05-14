"use strict"

$(document).ready(function () {
    var app = new Vue({
        el: '#panel',
        data: function () {
            return {
                racesresults: [],
                raceresultdetails: [],
                driversresults: []
            }
        },
        methods: {
            ShowRacesresults: function () {
                var uri = '../../api/races-results';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.racesresults = data;
                    });
            },
            ShowRacesresultDetails: function (raceId) {
                var uri = '../../api/races-results/' + raceId + '/details';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.raceresultdetails = data;
                    });
            },
            ShowDriversresults: function () {
                var uri = '../../api/ranking';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        console.log(_.groupBy(data, function (obj) {
                                return JSON.stringify([obj.DriverLastname, obj.Points]);
                            })
                        );
                        this.driversresults = data;
                    });
            }
        },
        filters: {
            SubStr: function (str) {
                return str.substring(0, 10);
            }
        },
        beforeMount() {
            this.ShowRacesresults();
            this.ShowDriversresults();
        }
    });
});