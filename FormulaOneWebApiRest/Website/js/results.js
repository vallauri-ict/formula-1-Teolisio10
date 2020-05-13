"use strict"

$(document).ready(function () {
    var app = new Vue({
        el: '#panel',
        data: function () {
            return {
                racesresults: []
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
            }
        },
        filters: {
            SubStr: function (str) {
                return str.substring(0, 10);
            }
        },
        beforeMount() {
            this.ShowRacesresults();
        }
    });
});