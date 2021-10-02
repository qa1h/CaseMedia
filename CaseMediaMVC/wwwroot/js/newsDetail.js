var app = angular.module('app', ['ui.bootstrap']);
app.controller('Controller', function ($scope, $http) {

    $scope.datas = [];
    $scope.filteredDatas = [];
    $scope.currentPage = 1;
    $scope.numPerPage = 12;
    $scope.maxSize = 5;
    $scope.init = function (id) {
        $http({
            method: 'GET',
            url: '/CaseMedia/GetDetail',
            params: { guid: id }
        }).then(function (result) {
            $scope.datas = result.data;
        }, function (error) {
        });
    }
});