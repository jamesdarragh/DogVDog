darragh.services.breed = {};

darragh.services.breed.createBreed = function(formData, onSuccess, onError)
{
	var url = "/api/breed"
	var settings = {
		cache: false,
		contentType: "application/x-www-form-urlencoded; charset=UTF-8",
		data: formData,
		dataType: "json",
		success: onSuccess,
		error: onError,
		type: "POST"
	};
	$.ajax(url, settings);
}