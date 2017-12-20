'use strict';

angular.module('myApp')

.controller('mainCtrl', MainCtrl)
.controller('registerCtrl', RegisterCtrl)
.controller('appointmentsCtrl', AppointmentsCtrl)
.controller('getAppointmentCtrl', GetAppointmentCtrl)
.controller('sendAppointmentCtrl', SendAppointmentCtrl)
.controller('contactCtrl', ContactCtrl);

MainCtrl.$inject = ['$scope'];
RegisterCtrl.$inject = ['$scope'];
AppointmentsCtrl.$inject = ['$scope', '$http'];
GetAppointmentCtrl.$inject = ['$scope', '$http'];
SendAppointmentCtrl.$inject = ['$scope', '$http'];
ContactCtrl.$inject = ['$scope'];

function MainCtrl($scope) {
    $scope.message = 'This is main controller.';
}

function RegisterCtrl($scope) {
    $scope.message = 'This is register controller.';
}

function AppointmentsCtrl($scope, $http) {
    $scope.Title = "Randevu geçmişi";

    $http({
        url: 'http://localhost:56568/api/Appointment/GetList',
        method: 'get'
    })
        .then
        (function (response) {
            console.log("response : " + response);
            $scope.Appointments = response;
        },
        function (err) {
            console.log(err);
        });
}

function GetAppointmentCtrl($scope, $http) {

    $scope.Title = "Randevu alınız";
       
    $http({
        url: 'http://localhost:56568/api/Policlinic/GetList',
        method: 'get'
    })
    .then
        (function (response) {
        $scope.Policlinics = response;
    },
        function (err) {
        console.log(err);
    });
    
    $http({
        url: 'http://localhost:56568/api/Doctor/GetList',
        method: 'get'
    })
    .then
    (function (response) {
        $scope.Doctors = response;
    },
    function (err) {
        console.log(err);
    });
}

function SendAppointmentCtrl($scope, $http) {
    $scope.data = {
        Name: '',
        Date: 0,
        PatientId: 1,
        PoliclinicId: 0,
        StaffId: 0
    };

    $scope.send = function () {
        $http({
            url: 'http://localhost:56568/api/Appointment/add',
            method: 'post',
            data: $scope.data
        })
            .then
            (function (response) {
                console.log('success');
            },
            function (err) {
                console.log('error');
            });
    }
}

function ContactCtrl($scope) {
    $scope.message = 'This is contact controller.';
}

var data = [
    { Id: 1, Name: 'A', Point: 1.1 },
    { Id: 2, Name: 'B', Point: 2.1 },
    { Id: 3, Name: 'C', Point: 18.7 },
    { Id: 4, Name: 'D', Point: 0.1 },
    { Id: 5, Name: 'E', Point: 226.9 }
];