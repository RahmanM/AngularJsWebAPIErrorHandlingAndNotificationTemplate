/**
 * A service that communicates with backend web api and returns information about cities
 * 
 * @param $http: dependency on angular $http module
 */
weatherApp.service("CitiesService", ['$http', function ($http) {

    /// Get cities from database based on counry name and returns promise
    this.getCities = function (countryName) {
         var promise = $http.get("api/Cities/GetCitiesByCountryName/" + countryName);
         return promise;
    };

    /// Get city weather information for a specific city based on Id and returns promise
    this.getCityInfo = function (cityId) {
        var promise = $http.get("api/Cities/" + cityId);
        return promise;
    };

}]);