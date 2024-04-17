// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code. on click button, C#

function getRandomTemperature(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

document.getElementById('mondayTemp').textContent = getRandomTemperature(67, 77);
document.getElementById('tuesdayTemp').textContent = getRandomTemperature(67, 77);
document.getElementById('wednesdayTemp').textContent = getRandomTemperature(67, 77);
document.getElementById('thursdayTemp').textContent = getRandomTemperature(67, 77);
document.getElementById('fridayTemp').textContent = getRandomTemperature(67, 77);
document.getElementById('saturdayTemp').textContent = getRandomTemperature(67, 77);
document.getElementById('sundayTemp').textContent = getRandomTemperature(67, 77);
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
    const response = await fetch(`https://localhost:7070/api/CityOld/${City}
`);
    const data = await response.json();
    document.getElementById('cityNameO').textContent = data[0].city;
    document.getElementById('cityNameO').style.visibility = "visible";
    document.getElementById('cityRatingO').textContent = data[0].rating;
    document.getElementById('cityRatingO').style.visibility = "visible";
    document.getElementById('cityCommentO').textContent = data[0].comment;
    document.getElementById('cityCommentO').style.visibility = "visible";
    document.getElementById('cityDateO').textContent = data[0].date;
    document.getElementById('cityDate').style.visibility = "visible";
    document.getElementById('cityTemp').textContent = data[0].avgTemp;
    document.getElementById('cityTemp').style.visibility = "visible";

    const reviewDate = new Date(data[0].date);

    const formattedDate = reviewDate.toLocaleDateString();

    document.getElementById('cityDateO').textContent = formattedDate;
    document.getElementById('cityDateO').style.visibility = "visible";
}



async function maxTempSearch(MaxTemp) {
    const response = await fetch(`https://localhost:7070/api/MaxHealth/${MaxTemp}`);
    const data = await response.json();
    document.getElementById('cityM').textContent = data[0].city;
    document.getElementById('cityM').style.visibility = "visible";
    document.getElementById('cityTempM').textContent = data[0].maxTemp;
    document.getElementById('cityTempM').style.visibility = "visible";
    document.getElementById('cityRatingM').textContent = data[0].rating;
    document.getElementById('cityRatingM').style.visibility = "visible";
    document.getElementById('cityCommentM').textContent = data[0].comment;
    document.getElementById('cityCommentM').style.visibility = "visible";
    document.getElementById('cityDateM').textContent = data[0].date;
    document.getElementById('cityDateM').style.visibility = "visible";


    const reviewDate = new Date(data[0].date);

    const formattedDate = reviewDate.toLocaleDateString();

    document.getElementById('cityDateM').textContent = formattedDate;
    document.getElementById('cityDateM').style.visibility = "visible";
}
function submitHighTemp() {
    var highTempValue = document.getElementById('highTemp').value;
    maxTempSearch(highTempValue);
}
