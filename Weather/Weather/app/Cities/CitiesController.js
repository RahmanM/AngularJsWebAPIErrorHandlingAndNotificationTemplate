
/**
 * Controller that returns weather information about a city
 * 
 * @param CitiesService : injected service that returns city from service
 * @param NotificationService : injected service that shows notifications to end user
 */
weatherApp.controller("CitiesController", ['CitiesService', 'NotificationService', function (citiesService, notificationService) {

    var ctrl = this;

    ctrl.city = {};
    ctrl.showInfo = false;
    ctrl.showLoading = false;

    ctrl.getCityInfo = function (cityId) {
        ctrl.showInfo = false;

        if (cityId) {

            ctrl.showLoading = true;
            var promise = citiesService.getCityInfo(cityId);
            promise.then(function(response) {
                ctrl.city = response.data;
                ctrl.showLoading = false;
                ctrl.showInfo = true;
            }, function (error) {
                ctrl.showLoading = false;
                console.log(error); // Use a bettr logging strategy for production1!
                notificationService.error(error.data.ExceptionMessage);
            });
        }
        else {
            ctrl.city = null;
        }
    }

}]);