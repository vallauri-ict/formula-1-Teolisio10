"use strict"

$(document).ready(function () {
    var app = new Vue({
        el: '#panel',
        data: function () {
            return {
                teams: [],
                teamDetails: []
            }
        },
        methods: {
            ShowTeams: function () {
                var uri = '../../api/Teams';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.teams = data;
                    });
            },
            ShowTeamDetails: function (teamId) {
                var uri = '../../api/Teams/' + teamId + '/details';
                $.getJSON(uri)
                    .done((data) => {
                        console.log(data);
                        this.teamDetails = data;
                    });
            }
        },
        filters: {
            SubStr: function (str) {
                return str.substring(0, 10);
            }
        },
        beforeMount() {
            this.ShowTeams();
        }
    });
});