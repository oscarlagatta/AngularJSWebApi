(function () {
    "use strict";
    angular
        .module("productManagement")
        .controller("ProductListCtrl",
                     ["productResource",ProductListCtrl]);

    function ProductListCtrl(productResource) {
        var vm = this;

        // expect to receive a JSON array from web api.
        productResource.query(function(data) {
            vm.products = data;
        });

    }
}());