$(function () {

    $("save").on("click", function () {

        console.log("entro");
        var results = new Array();

        var emp1 = {
            "firstName": "Fernando",
            "lastName": "Manas",
            "address": "Jutiapa",
            "email": "fsdkjsld",
            "phoneNumber": "6864321",
            "course": "sdzcxczx",
            "dateOfBirth": "xcvxcvxcv"
        };
        results.push(emp1);


        var postData = { empList: results };

        $.ajax({
            url: 'Form/Create',
            data: JSON.stringify(emp1),
            type: 'POST',
            contentType: 'application/json',
            dataType: 'json',
            beforeSend: function () {
                Show(); // Show loader icon
            },
            success: function (result) {
                alert(result);
            },
            complete: function () {
                Hide(); // Hide loader icon
            },
            failure: function (jqXHR, textStatus, errorThrown) {
                alert("Status: " + jqXHR.status + "; Error: " + jqXHR.responseText); // Display error message
            }
        });
    });

});