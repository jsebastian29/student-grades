var app = angular.module('StundetGradeApp', []);

app.controller('StudentGradeController', function ($scope, $http) {
    $http.get('api/StudentGrade').then(function (d) {
        $scope.regData = d.data;
    }, function (err) {
        alert('Failed');
        });


    $scope.getByMark = function () {
        $http.get('api/StudentGrade/GetByMark?mark=' + $scope.markValue).then(function (d) {
            $scope.regData = d.data;
        }, function (err) {
            alert('Failed');
        });
    }

    $scope.getByStudentName = function () {
        $http.get('api/StudentGrade/GetByStudentName?studentName=' + $scope.studentName).then(function (d) {
            $scope.regData = d.data;
        }, function (err) {
            alert('Failed');
        });
    }

    $scope.getByCustomFilter = function () {
        var name = $scope.studentName == undefined ? "" : $scope.studentName;
        $http.get('api/StudentGrade/GetByFilters?mark=' + $scope.markValue + '&studentName=' + name).then(function (d) {
            $scope.regData = d.data;
        }, function (err) {
            alert('Failed');
        });
    }

});