// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


async function displayCityReviews(City) {
    const response = await fetch(`https://localhost:7070/api/CityReview/${City}`)
    const data = await response.json();
    document.getElementById('City').innerHTML = data[0].City
    document.getElementById('City').style.visibility = "visible";
}
