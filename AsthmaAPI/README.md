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
Returns a list of all reviews for your given City, including the following:

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
