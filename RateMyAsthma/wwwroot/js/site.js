// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code. on click button, C#



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
    if (document.getElementById('HighTempDisplayBox').style.display = ' none') {
        document.getElementById('nullmContent').textContent = "Sorry, there are no results that match your search criteria."
        document.getElementById('nullMessage').style.display = 'inline-block';

    }

    const reviewDate = new Date(data[0].date);
    const formattedDate = reviewDate.toLocaleDateString();
    document.getElementById('cityM').textContent = data[0].city;
    document.getElementById('cityCommentM').textContent = data[0].comment;
    document.getElementById('cityRatingM').textContent = data[0].rating;
    document.getElementById('cityTempM').textContent = data[0].maxTemp;
    document.getElementById('cityDateM').textContent = formattedDate;
    document.getElementById('HighTempDisplayBox').style.display = 'inline-block';
    document.getElementById('nullMessage').style.display = 'none';



    const reviewDate1 = new Date(data[1].date);
    const formattedDate1 = reviewDate1.toLocaleDateString();
    document.getElementById('cityM1').textContent = data[1].city;
    document.getElementById('cityCommentM1').textContent = data[1].comment;
    document.getElementById('cityRatingM1').textContent = data[1].rating;
    document.getElementById('cityTempM1').textContent = data[1].maxTemp;
    document.getElementById('cityDateM1').textContent = formattedDate1;

    document.getElementById('HighTempDisplayBox1').style.display = 'inline-block';


    const reviewDate2 = new Date(data[2].date);
    const formattedDate2 = reviewDate2.toLocaleDateString();
    document.getElementById('cityM2').textContent = data[2].city;
    document.getElementById('cityCommentM2').textContent = data[2].comment;
    document.getElementById('cityRatingM2').textContent = data[2].rating;
    document.getElementById('cityTempM2').textContent = data[2].maxTemp;
    document.getElementById('cityDateM2').textContent = formattedDate2;

    document.getElementById('HighTempDisplayBox2').style.display = 'inline-block';


    const reviewDate3 = new Date(data[3].date);
    const formattedDate3 = reviewDate3.toLocaleDateString();
    document.getElementById('cityM3').textContent = data[3].city;
    document.getElementById('cityCommentM3').textContent = data[3].comment;
    document.getElementById('cityRatingM3').textContent = data[3].rating;
    document.getElementById('cityTempM3').textContent = data[3].maxTemp;
    document.getElementById('cityDateM3').textContent = formattedDate3;

    document.getElementById('HighTempDisplayBox3').style.display = 'inline-block';


    const reviewDate4 = new Date(data[4].date);
    const formattedDate4 = reviewDate4.toLocaleDateString();
    document.getElementById('cityM4').textContent = data[4].city;
    document.getElementById('cityCommentM4').textContent = data[4].comment;
    document.getElementById('cityRatingM4').textContent = data[4].rating;
    document.getElementById('cityTempM4').textContent = data[4].maxTemp;
    document.getElementById('cityDateM4').textContent = formattedDate4;

    document.getElementById('HighTempDisplayBox4').style.display = 'inline-block';




}

async function avgRPSSearch(City, Season) {
    const response = await fetch(`https://localhost:7070/api/CitySeasonRating/${City}/${Season}`);
    const data = await response.json();
    if (document.getElementById('HighTempDisplayBox').style.display = ' none') {
        document.getElementById('nullmContent').textContent = "Sorry, there are no results that match your search criteria."
        document.getElementById('nullMessage').style.display = 'inline-block';

    }

    document.getElementById('avgSeason').textContent = data[0].season;
    document.getElementById('avgRate').textContent = data[0].averageRating;
    document.getElementById('SeasonCityDisplayBox').style.display = 'inline-block';
    document.getElementById('nullMessage').style.display = 'none';

}

async function tempRangeSearch(MinTemp, MaxTemp) {
    const response = await fetch(`https://localhost:7070/api/Temp/${MinTemp}/${MaxTemp}`);
    const data = await response.json();
    if (document.getElementById('HighTempDisplayBox').style.display = ' none') {
        document.getElementById('nullmContent').textContent = "Sorry, there are no results that match your search criteria."
        document.getElementById('nullMessage').style.display = 'inline-block';

    }
    const reviewDate = new Date(data[0].date);
    const formattedDate = reviewDate.toLocaleDateString();







    document.getElementById('trRating').textContent = data[0].rating;
    document.getElementById('trDate').textContent = formattedDate;
    document.getElementById('trCity').textContent = data[0].city;
    document.getElementById('trState').textContent = data[0].state;
    document.getElementById('TempRangeDisplayBox').style.display = 'inline-block';
    document.getElementById('nullMessage').style.display = 'none';

    const reviewDate1 = new Date(data[1].date);
    const formattedDate1 = reviewDate1.toLocaleDateString();

    document.getElementById('trRating1').textContent = data[1].rating;
    document.getElementById('trDate1').textContent = formattedDate1;
    document.getElementById('trCity1').textContent = data[1].city;
    document.getElementById('trState1').textContent = data[1].state;
    document.getElementById('TempRangeDisplayBox1').style.display = 'inline-block';

    const reviewDate2 = new Date(data[2].date);
    const formattedDate2 = reviewDate2.toLocaleDateString();

    document.getElementById('trRating2').textContent = data[2].rating;
    document.getElementById('trDate2').textContent = formattedDate2;
    document.getElementById('trCity2').textContent = data[2].city;
    document.getElementById('trState2').textContent = data[2].state;
    document.getElementById('TempRangeDisplayBox2').style.display = 'inline-block';

    const reviewDate3 = new Date(data[3].date);
    const formattedDate3 = reviewDate3.toLocaleDateString();

    document.getElementById('trRating3').textContent = data[3].rating;
    document.getElementById('trDate3').textContent = formattedDate3;
    document.getElementById('trCity3').textContent = data[3].city;
    document.getElementById('trState3').textContent = data[3].state;
    document.getElementById('TempRangeDisplayBox3').style.display = 'inline-block';

    const reviewDate4 = new Date(data[4].date);
    const formattedDate4 = reviewDate4.toLocaleDateString();

    document.getElementById('trRating4').textContent = data[4].rating;
    document.getElementById('trDate4').textContent = formattedDate4;
    document.getElementById('trCity4').textContent = data[4].city;
    document.getElementById('trState4').textContent = data[4].state;
    document.getElementById('TempRangeDisplayBox4').style.display = 'inline-block';
}


function submitHighTemp() {
    var highTempValue = document.getElementById('highTemp').value;
    maxTempSearch(highTempValue);
}
