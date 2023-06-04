// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


(function () {
    $('.validate').each(function () {

        var empty = true;
        $(this).keyup(function () {
            
            if ($(this).val() != '') {
                empty = false;
            }
            validateInput(empty)
        });
        validateInput(empty)
        
    });
})()

function validateInput(value) {
    if (value) {
        $('#SaveButtonCreate').attr('disabled', 'disabled'); // updated according to http://stackoverflow.com/questions/7637790/how-to-remove-disabled-attribute-with-jquery-ie
    } else {
        $('#SaveButtonCreate').removeAttr('disabled'); // updated according to http://stackoverflow.com/questions/7637790/how-to-remove-disabled-attribute-with-jquery-ie
    }
}