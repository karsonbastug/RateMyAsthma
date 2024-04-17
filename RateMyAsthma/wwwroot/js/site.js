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
    document.getElementById('cityCommentM').textContent = data[0].comment;
    document.getElementById('cityRatingM').textContent = data[0].rating;
    document.getElementById('cityTempM').textContent = data[0].maxTemp;
    document.getElementById('cityDateM').textContent = data[0].date;
    document.getElementById('HighTempDisplayBox').style.display = 'inline-block';

    document.getElementById('cityM1').textContent = data[1].city;
    document.getElementById('cityCommentM1').textContent = data[1].comment;
    document.getElementById('cityRatingM1').textContent = data[1].rating;
    document.getElementById('cityTempM1').textContent = data[1].maxTemp;
    document.getElementById('cityDateM1').textContent = data[1].date;

    document.getElementById('HighTempDisplayBox1').style.display = 'inline-block';

    document.getElementById('cityM2').textContent = data[1].city;
    document.getElementById('cityCommentM2').textContent = data[1].comment;
    document.getElementById('cityRatingM2').textContent = data[1].rating;
    document.getElementById('cityTempM2').textContent = data[1].maxTemp;
    document.getElementById('cityDateM2').textContent = data[1].date;

    document.getElementById('HighTempDisplayBox2').style.display = 'inline-block';

    document.getElementById('cityM3').textContent = data[2].city;
    document.getElementById('cityCommentM3').textContent = data[2].comment;
    document.getElementById('cityRatingM3').textContent = data[2].rating;
    document.getElementById('cityTempM3').textContent = data[2].maxTemp;
    document.getElementById('cityDateM3').textContent = data[2].date;

    document.getElementById('HighTempDisplayBox3').style.display = 'inline-block';

    document.getElementById('cityM4').textContent = data[3].city;
    document.getElementById('cityCommentM4').textContent = data[3].comment;
    document.getElementById('cityRatingM4').textContent = data[3].rating;
    document.getElementById('cityTempM4').textContent = data[3].maxTemp;
    document.getElementById('cityDateM4').textContent = data[3].date;

    document.getElementById('HighTempDisplayBox4').style.display = 'inline-block';




}
function submitHighTemp() {
    var highTempValue = document.getElementById('highTemp').value;
    maxTempSearch(highTempValue);
}
