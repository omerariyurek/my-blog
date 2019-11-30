$(document).ready(function () {
    $.fn.select2.defaults.set("theme", "bootstrap");
    $('#categories-select2').select2({
        placeholder: "Select a categories",
        width: '100%',
        multiple: true
    });
    $('#tags-select2').select2({
        placeholder: "Select a tags",
        multiple: true,
        width: '100%'
    });
});


