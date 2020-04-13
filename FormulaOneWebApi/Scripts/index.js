"use strict";

var uriCountry = 'api/CountriesAPI';
var uriDriver = 'api/DriversAPI';
var uriTeam = 'api/TeamsAPI';
var uriCircuits = 'api/CircuitsAPI';

$(document).ready(function () {
    $.getJSON(uriCountry).done(function (data) {
        $.each(data, function (key, item) {
            $('<li>', { text: item.CountryCode + ': ' + item.CountryName }).appendTo($('#countries'));
        });
    });
    $.getJSON(uriDriver).done(function (data) {
        $.each(data, function (key, item) {
            $('<li>', { text: item.Id + ": " + item.Lastname + " " + item.Firstname + ", " + item.Country.CountryCode }).appendTo($('#drivers'));
        });
    });
    $.getJSON(uriTeam).done(function (data) {
        $.each(data, function (key, item) {
            $('<li>', { text: item.Id + ": " + item.Name  + ", " + item.Country.CountryCode }).appendTo($('#teams'));
        });
    });
    $.getJSON(uriCircuits).done(function (data) {
        $.each(data, function (key, item) {
            $('<li>', { text: item.Id + ": " + item.Name }).appendTo($('#circuits'));
        });
    });
});

function find(params) {
    if (params == "Country") {
        $.getJSON(uriCountry + '/' + $('#countryCode').val().toString()).done(function (item) {
            $('#country').text(item.CountryCode + ': ' + item.CountryName);
        }).fail(function (jqXHR, textStatus, err) {
            $('#country').text('Error: ' + err);
        });
    } else if (params == "Driver") {
        $.getJSON(uriDriver + '/' + $("#drId").val()).done(function (item) {
            $('#driver').text(item.Id + ": " + item.Lastname + " " + item.Firstname + ", " + item.Country.CountryCode);
        }).fail(function (jqXHR, textStatus, err) {
            $('#driver').text('Error: ' + err);
        });
    } else if (params == "Team") {
        $.getJSON(uriTeam + '/' + $("#tId").val()).done(function (item) {
            $('#team').text(item.Id + ": " + item.Name + ", " + item.Country.CountryCode + "  - " + item.ExtFirstDriver + " " + item.ExtFirstDriver);
        }).fail(function (jqXHR, textStatus, err) {
            $('#team').text('Error: ' + err);
        });
    } else if (params == "Circuit") {
        $.getJSON(uriCircuits + '/' + $("#cId").val()).done(function (item) {
            $('#circuit').text(item.Id + ": " + item.Name);
        }).fail(function (jqXHR, textStatus, err) {
            $('#circuit').text('Error: ' + err);
        });
    }
}