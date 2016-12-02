
/**
 * A wrapper service that is used to show notifications using the toastr javascript module
 */
weatherApp.service('NotificationService', function () {

    var self = this;

    self.success = function (text) {
        toastr.success(text, "Success");
    };

    self.error = function (text) {
        toastr.error(text, "Error");
    }

    self.info = function (text) {
        toastr.info(text);
    }

});