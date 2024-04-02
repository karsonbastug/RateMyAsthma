# Karson Bastug APIs

## /api/CityReview/{City}

### Purpose
Retrieves ratings for a particular city

### Inputs
- {City}: The string that identifies your desired City

### Outputs
Returns a list of all reviews for your given City, including the following:
- int MaxTemp (the max of the temperature for the day reviewed)
- int AvgTemp (the avg of the temperature for the day reviewed)
- int MixTemp (the min of the temperature for the day reviewed)
- int Rating (the rating for that day in that city) 
- date DateTime (the date of the review for that city)

### Sample Code

This asynchronous method retrieves a list of cities from a database using Entity Framework Core by executing a stored procedure named "GetCity1" with a provided city parameter.

```js
        public async Task<List<City>> AGetLocation(string City)
        {
            var param = new SqlParameter("@City", City);
            var locations = await Task.Run(() => _dbContextClass.Location.FromSqlRaw("exec GetCity1 @City;", param).ToListAsync()); 
            return locations;
        }
```
## /api/MaxReview/{MaxTemp}

### Purpose
Retrieves ratings when the MaxTemp for a day was more than the inputted value

### Inputs
- {MaxTemp}: The int that identifies your desired range (all ratings when > @MaxTemp)

### Outputs
Returns the reviews, rating, and date of the review for when the MaxTemp for that day was more than the inputted value

- string Comment (the reviews for that temperature)
- int Rating (the rating for that day in that city) 
- date DateTime (the date of the review for that city)

### Sample Code

This asynchronous method retrieves a list of reviews from a database using Entity Framework Core by executing a stored procedure named "GerRatingsForHighTemp" with a provided MaxTemp parameter.

```js
        public async Task<List<MaxHealthReview>> AGetTemp(int MaxTemp)
        {
            var param = new SqlParameter("@MaxTemp", MaxTemp);
            var maxR = await Task.Run(() => _dbContextClass.HealthReview.FromSqlRaw("exec GetRatingsForHighTemp @MaxTemp;", param).ToListAsync());
            return maxR;
        }
```
## 

# Chase Baker's APIs

## /api/getLocDetails/{City}
!!Important!! 
This action only calls data for the current date. Even when working, if a new datapoint has not been added to the DB with the date of whenever you run this action, it will return a blank "[]" - that is intentional. 

!! Ensure SPs "spgetLocDetails" and "avgRatePerSeasonInCity" are in your version of the database
See: https://github.com/karsonbastug/Assignment3/blob/main/ChaseBakerSps.sql

### Purpose
Given a city, it will return weather details for that city for the current day.

### Inputs
- {City}: The string that identifies the desired City user would like to get data for.

### Outputs
Returns a list of basic weather data from the database for the given city:
- The maximum temperature (int)
- The average temperature (int)
- The mininimum temperature (int)
- The precipitation (int), in inches, expected that day

  ### Sample Code

  ```js
          public async Task<List<LocationWeatherE>> spgetLocDetails(string city)
        {
            var param = new SqlParameter("@City", city);
            var getLocWeather = await Task.Run(() => _dbContextClass.LocationWeatherE.FromSqlRaw("exec spgetLocDetails @City;", param).ToListAsync());
            return getLocWeather;
        }

## /api/AvgRatingPerSeasonByCity/{City}/{Season}

### Purpose 
Given a city and a season, returns the average ratings for that city during that season throughout all time.

### Inputs 
-{City}: The desired city the user would like data to be retrieved for.
-{Season}: The season user would like the data to be referring to.

### Outputs
- The season (string) the data is referring to (the same as the input)
- The Average (int) rating of reviews during that season in that city throughout all time.

### Sample Code
```js
public async Task<List<CitySeasonRating>> avgRatePerSeasonInCity(string city, string season)
        {
            var paramA = new SqlParameter("@City", city);
            var paramB = new SqlParameter("@Season", season);
            var getRatingPerSeason = await Task.Run(() => _dbContextClass.CitySeasonRating.FromSqlRaw("exec avgRatePerSeasonInCity @City, @Season;", paramA, paramB).ToListAsync());
            return getRatingPerSeason;
        }
```
# Noah Stalnaker's APIs

## /api/getTemRate/{City}
!!Important!! 
This action only calls data for the current date. Even when working, if a new datapoint has not been added to the DB with the date of whenever you run this action, it will return a blank "[]" - that is intentional. 

### Purpose
Given a city, it will allow you to access of the ratings and the tempurature. 

### Inputs
- {City}: The string that identifies the desired City user would like to get data for.

### Outputs
Returns a list of basic weather data from the database for the given city:
- The average temperature (int)
- The average rating (int)

  ### Sample Code

  ```js
          public async Task<ActionResult<List<RateByTemp>>> GetRateByTemperature(int temperature)
  {
     var rateByTemp = await _rateByTempRepository.GetRateByTemperature(temperature);

     if (rateByTemp == null)
     {
         return NotFound();
     }

     return rateByTemp;

## /api/GetLocRate/{City}

### Purpose 
Given a city, it will allow you to access the ratings and interact. 

### Inputs 
-{City}: The desired city the user would like data to be retrieved for.

### Outputs
- The average rating (int)
- The Location (int)

### Sample Code
```js
public async Task<ActionResult<List<LocationRating>>> GetLocationRatings(int locationId)
{
    var locationRatings = await _locationRatingRepository.GetLocationRatings(locationId);

    if (locationRatings == null)
    {
        return NotFound();
    }

    return locationRatings;
        }
```

# WeatherForecast

## /api/WeatherForecast/{Weather}
Currently, we have imported a WeatherForecast API. It retrieves the weather for the given day. We plan on using it to retrieve the weather for your desired location and date, and use that information as a paramter in certain stored procedures.

