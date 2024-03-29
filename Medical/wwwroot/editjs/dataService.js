let DataService = function () {
    let upload = function (url, obj, success, fail) {
        fetch(url, {
            method: 'POST',
            body: obj
        })
            .then(response => response.json())
            .then(data => success(data))
            .catch(error => fail(error));
        //  demoMethods.jsInvokeCAsync(obj);
        // DotNet.invokeMethodAsync('Medical', 'Upload', obj);
    };
    return {
        upload: upload
    };
}();