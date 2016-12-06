
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

    self.processError = function(errorObject) {

        // This will handle the exceptions that are thrown from api
        if (errorObject.data.ExceptionMessage) {
            toastr.error(errorObject.data.ExceptionMessage, "Error");
        }

        // this will handle the errors like NotFound or InternalServerError
        if (errorObject.data.Message) {
            toastr.error(errorObject.data.Message, "Error");
        }

    }

});