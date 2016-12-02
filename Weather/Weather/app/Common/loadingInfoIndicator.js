
weatherApp.directive("loadingInfoIndicator", function () {

    return {
        scope : {
            textToShow : "@",
            showIndicator : "="
        },
        templateUrl: "./app/Common/loading-Info-Indicator-Template.html",
        restrict: "EA"
    }

});