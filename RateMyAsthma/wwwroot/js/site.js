// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code. on click button, C#


async function displayCityReviews(City) {
    const response = await fetch(`https://localhost:7070/api/CityReview/${City}`);
    const data = await response.json();
    document.getElementById('cityName').textContent = data[0].city;
    document.getElementById('cityName').style.visibility = "visible";
    document.getElementById('cityRating').textContent = data[0].rating;
    document.getElementById('cityRating').style.visibility = "visible";
    document.getElementById('cityComment').textContent = data[0].comment;
    document.getElementById('cityComment').style.visibility = "visible";
    document.getElementById('cityDate').textContent = data[0].date;
    document.getElementById('cityDate').style.visibility = "visible";

    const reviewDate = new Date(data[0].date);

    const formattedDate = reviewDate.toLocaleDateString();

    document.getElementById('cityDate').textContent = formattedDate;
    document.getElementById('cityDate').style.visibility = "visible";
}
async function displayOldCityReviews(City) {
    const response = await fetch(`https://localhost:7070/api/CityOld/Chicago
`);
    const data = await response.json();
    document.getElementById('cityName').textContent = data[0].city;
    document.getElementById('cityName').style.visibility = "visible";
    document.getElementById('cityRating').textContent = data[0].rating;
    document.getElementById('cityRating').style.visibility = "visible";
    document.getElementById('cityComment').textContent = data[0].comment;
    document.getElementById('cityComment').style.visibility = "visible";
    document.getElementById('cityDate').textContent = data[0].date;
    document.getElementById('cityDate').style.visibility = "visible";
    document.getElementById('cityTemp').textContent = data[0].avgTemp;
    document.getElementById('cityTemp').style.visibility = "visible";

    const reviewDate = new Date(data[0].date);

    const formattedDate = reviewDate.toLocaleDateString();

    document.getElementById('cityDate').textContent = formattedDate;
    document.getElementById('cityDate').style.visibility = "visible";
}


