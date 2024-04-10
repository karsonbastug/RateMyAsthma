// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code. on click button, C#


async function displayCityReviews(City) {
    const response = await fetch(`https://localhost:7070/api/CityReview/${City}`)
    const data = await response.json();
    document.getElementById('cityName').innerHTML = data[0].city;   
    document.getElementById('cityName').style.visbility = "visbile";
    document.getElementById('cityRating').innerHTML = data[0].rating;
    document.getElementById('cityRating').style.visbility = "visible";
    document.getElementById('cityComment').innerHTML = data[0].comment;
    document.getElementById('cityComment').style.visbility = "visible";
}
