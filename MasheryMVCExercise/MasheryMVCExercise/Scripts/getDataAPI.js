//Create Angular APP and module
var TopicsApp = angular.module('myApp', []);
TopicsApp.controller('topicsCtrl', function ($scope, TopicsService) {

    getTopics();
    function getTopics() {
        //Execute getTopics Services
        TopicsService.getTopics()
            //On sucess create scope with the json
            .success(function (topicsJSON)
            {
                $scope.topics = JSON.parse(topicsJSON);
                console.log($scope.topics);
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
TopicsApp.factory('TopicsService', ['$http', function ($http) {

    var TopicsService = {};

    TopicsService.getTopics = function ()
    {
        //Call action for get JSON from API
        return $http.get('/Topics/GetTopics');
    };
    //Return result
    return TopicsService;

}]);