//$(document).ready(function() {
  
//});
function deleteCategory(id) {
    var ans = confirm("Are you sure you want to delete this category?");
    if (ans) {
        $.ajax({
            url: "/administrator/category/delete/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                $("#row_category_" + id).remove();
            },
            error: function (message) {
                alert(message.responseText);
            }
        });
    }
}
function getCategoryById(id) {
    $.ajax({
        url: "/administrator/category/get/" + id,
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#CategoryStatusModal').prop("");
            $('#CategoryIdModal').val(result.categoryId);
            $('#CategoryNameModal').val(result.categoryName);
            $('#CategoryDescriptionModal').val(result.categoryDescription);
            $('#CategorySeoUrlModal').val(result.seoUrl);
            if (result.status===true) {
              $('#CategoryStatusModal').prop('checked', result.status);
            } else {
                $('#CategoryStatusModal').prop('checked',result.status);
            }
            $('#categoryUpdateModal').modal('show');
        },
        error: function () {
            alert("Error, try again!");
        }
    });
    return false;
}

