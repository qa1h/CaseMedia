var app = angular.module('app', ['ui.bootstrap']);
app.controller('Controller', function ($scope, $http) {

    $scope.datas = [];
    $scope.filteredDatas = [];
    $scope.currentPage = 1;
    $scope.numPerPage = 4;
    $scope.maxSize = 5;

    init();

    function init() {
        $http({
            method: 'GET',
            url: '/CaseMedia/Get'
        }).then(function (result) {
            $scope.datas = result.data;
            $scope.filteredDatas = $scope.datas.slice(0, $scope.numPerPage);

        }, function (error) {
        });
    }

    $scope.$watch('currentPage + numPerPage', updateFilteredItems);

    function updateFilteredItems() {
        var begin = (($scope.currentPage - 1) * $scope.numPerPage),
            end = begin + $scope.numPerPage;

        $scope.filteredDatas = $scope.datas.slice(begin, end);
        console.log("olurasd");
    }

});

app.filter('slugify', function () {
    return function (input) {
        var trMap = {
            'çÇ': 'c',
            'ğĞ': 'g',
            'şŞ': 's',
            'üÜ': 'u',
            'ıİ': 'i',
            'öÖ': 'o'
        };
        for (var key in trMap) {
            input = input.replace(new RegExp('[' + key + ']', 'g'), trMap[key]);
        }
        return input.replace(/[^-a-zA-Z0-9\s]+/ig, '')
            .replace(/\s/gi, "-")
            .replace(/[-]+/gi, "-")
            .toLowerCase();
    };
});
