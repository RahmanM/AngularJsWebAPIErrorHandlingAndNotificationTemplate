
/**
 * Controller that returns all cities for a selected country
 * 
 * @param CitiesService : injected service that returns city from service
 * @param NotificationService : injected service that shows notifications to end user
 */
weatherApp.controller("CountriesController", ['CitiesService', 'NotificationService', function (citiesService, notificationService) {

    var ctrl = this;

    ctrl.cities = [];
    ctrl.country = "";
    ctrl.hideInfo = false;    // Weather information section
    ctrl.showLoading = false; // Loading indicator

    ctrl.populateCities = function () {

        if (ctrl.country) {
            ctrl.showLoading = true;

            var promise = citiesService.getCities(ctrl.country);
            promise.then(function (response) {
                ctrl.cities = response.data;
                ctrl.showLoading = false;
                if (ctrl.cities.length === 0 && ctrl.country !== undefined) {
                    notificationService.info("No cities are found for the selected country.");
                }
            }, function (error) {
                ctrl.showLoading = false;
                console.log(error); // Use a better logging strategy for production!
                notificationService.processError(error);
            });

        }
        else {
            ctrl.cities = null;
            ctrl.hideInfo = true;
        }
    }

}]);
