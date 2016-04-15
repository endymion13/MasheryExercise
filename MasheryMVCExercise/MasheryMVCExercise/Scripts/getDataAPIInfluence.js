//Create Angular APP and module
var InfluenceApp = angular.module('myApp', []);
InfluenceApp.controller('influencesCtrl', function ($scope, InfluenceService) {

    getTopics();
    function getTopics() {
        //Execute getTopics Services
        InfluenceService.getInfluences()
            //On sucess create scope with the json
            .success(function (influenceJSON)
            {
                $scope.influences = JSON.parse(influenceJSON);
                console.log($scope.influences);
            })
            //In case of error write the error on console
            .error(function (error)
            {
                $scope.status = 'Unable to load customer data: ' + error.message;
                console.log($scope.status);
            });
    }
});

//Create services to get JSON from API 
InfluenceApp.factory('InfluenceService', ['$http', function ($http) {

    var InfluenceService = {};

    InfluenceService.getInfluences = function ()
    {
        //Call action for get JSON from API
        return $http.get('/Influence/GetInfluence');
    };
    //Return result
    return InfluenceService;

}]);