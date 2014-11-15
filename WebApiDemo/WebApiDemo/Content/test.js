
$(document).ready(function () {

	$("#TestController1").click(function () {
		$.ajax({
			type: "GET",
			url: "api/MyApi/Test",
			success: function (rawData)
			{
				var data = jQuery.parseJSON(rawData);
				alert(data.employees[0].lastName);
			},
			error: function (error) {
				alert(error.responseText);
			}
		});
	});


});