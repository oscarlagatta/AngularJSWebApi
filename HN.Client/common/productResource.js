(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("productResource",
            [
                "$resource",
                "appSettings",
                productResource
            ]
        );

    function productResource($resource, appSettings) {
        // returning a resource object which enables communication with the webapi service
        return $resource(appSettings.serverPath + "/api/products/:id");
    }
}());