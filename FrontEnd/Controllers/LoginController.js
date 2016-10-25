angular


    .module("MyFirstApp", [])
    .controller("FirstController",

function($scope,$http){
    
        $scope.usuario = {};
        $http.get('http://blueskytec.azurewebsites.net/api/Login?carnet=2000445560&contrasenha=RDK455')
        
    .success(function(data){
      console.log(data);
      $scope.usuario = JSON.stringify(data);
    })
        
    .error(function(err) {
      console.log(err);
      $scope.usuario = JSON.stringify({"Error":"coño tío"});
    });
    

});
