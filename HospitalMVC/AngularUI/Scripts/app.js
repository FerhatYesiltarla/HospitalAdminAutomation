/// <reference path="angular.js" />
angular.module('Authentication', [])
angular.module('myApp', ['ngRoute'])

angular.module('BasicHttpAuthExample', [
    'Authentication',
    'myApp',
    'ngRoute',
    'ngCookies'
])
    .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/login', {
                controller: 'LoginController',
                templateUrl: 'Authentication/Views/login.html',
                hideMenus: true
            })
            .when('/', {
                controller: 'mainCtrl',
                templateUrl: 'Views/main.html'
            })
            .when('/register', {
                controller: 'registerCtrl',
                templateUrl: 'Views/register.html'
            })
            .when('/appointments', {
                controller: 'appointmentsCtrl',
                templateUrl: 'Views/appointments.html'
            })
            .when('/getAppointment', {
                controller: 'getAppointmentCtrl',
                templateUrl: 'Views/getAppointment.html'
            })
            .when('/contact', {
                controller: 'contactCtrl',
                templateUrl: 'Views/contact.html'
            })
            .otherwise({ redirectTo: '/login' });

        $locationProvider.html5Mode(true);
    }]);

//.run(['$rootScope', '$location', '$cookieStore', '$http',
//    function ($rootScope, $location, $cookieStore, $http) {
//        // keep user logged in after page refresh
//        $rootScope.globals = $cookieStore.get('globals') || {};
//        if ($rootScope.globals.currentUser) {
//            $http.defaults.headers.common['Authorization'] = 'Basic ' + $rootScope.globals.currentUser.authdata; // jshint ignore:line
//        }

//        $rootScope.$on('$locationChangeStart', function (event, next, current) {
//            // redirect to login page if not logged in
//            if ($location.path() !== '/login' && !$rootScope.globals.currentUser) {
//                $location.path('/login');
//            }
//        });
//    }]);