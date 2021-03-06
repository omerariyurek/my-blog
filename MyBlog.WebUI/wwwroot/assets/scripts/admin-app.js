﻿function deleteCategory(id) {
    var ans = confirm("Are you sure you want to delete this category?");
    if (ans) {
        $.ajax({
            url: "/administrator/category/delete/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                $("#row_category_" + id).remove();
                alert(result);
            },
            error: function (result) {
                alert(result);
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
            $('#CategoryMetaDescriptionModal').val(result.metaDescription);
            $('#CategoryMetaKeywordsModal').val(result.metaKeywords);
            $('#CategorySeoUrlModal').val(result.seoUrl);
            if (result.status===true) {
              $('#CategoryStatusModal').prop('checked', result.status);
            } else {
                $('#CategoryStatusModal').prop('checked',result.status);
            }
            $('#categoryUpdateModal').modal('show');
        },
        error: function (result) {
            alert(result);
        }
    });
    return false;
}

function deleteTag(id) {
    var ans = confirm("Are you sure you want to delete this tag?");
    if (ans) {
        $.ajax({
            url: "/administrator/tag/delete/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                $("#row_tag_" + id).remove();
                alert(result);

            },
            error: function (result) {
                alert(result);
            }
        });
    }
}

function getTagById(id) {
    $.ajax({
        url: "/administrator/tag/get/" + id,
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#TagIdModal').val(result.tagId);
            $('#TagNameModal').val(result.tagName);
            $('#TagMetaDescriptionModal').val(result.metaDescription);
            $('#TagMetaKeywordsModal').val(result.metaKeywords);
            $('#TagSeoUrlModal').val(result.seoUrl);
            if (result.status === true) {
                $('#TagStatusModal').prop('checked', result.status);
            } else {
                $('#TagStatusModal').prop('checked', result.status);
            }
            $('#tagUpdateModal').modal('show');
        },
        error: function (result) {
            alert(result);
        }
    });
    return false;
}

function deleteComment(id) {
    var ans = confirm("Are you sure you want to delete this comment?");
    if (ans) {
        $.ajax({
            url: "/administrator/comment/delete/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                $("#row_comment_" + id).remove();
                alert(result);

            },
            error: function (result) {
                alert(result);
            }
        });
    }
}

function getCommentById(id) {
    $.ajax({
        url: "/administrator/comment/get/" + id,
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            console.log(result);
            $('#CommentIdModal').val(result.commentId);
            $('#CommentPostIdModal').val(result.postId);
            $('#AuthorNameModal').val(result.authorName);
            $('#CommentContentModal').val(result.content);
            $('#AuthorEmailModal').val(result.authorEmail);
            $('#PostTitleModal').val(result.post.title);

            if (result.approved === true) {
                $('#CommentApprovedModal').prop('checked', result.approved);
            } else {
                $('#CommentApprovedModal').prop('checked', result.approved);
            }
            $('#commentUpdateModal').modal('show');
        },
        error: function (result) {
            alert(result);
        }
    });
    return false;
}

function deleteContact(id) {
    var ans = confirm("Are you sure you want to delete this contact?");
    if (ans) {
        $.ajax({
            url: "/administrator/contact/delete/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                $("#row_contact_" + id).remove();
                alert(result);
            },
            error: function (result) {
                alert(result);
            }
        });
    }
}

function getContactById(id) {
    $.ajax({
        url: "/administrator/contact/get/" + id,
        type: "POST",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#ContactIdModal').val(result.contactId);
            $('#ContactNameModal').val(result.contactName);
            $('#ContactMessageModal').val(result.message);
            $("#EmailContactModal").val(result.email);
            $('#contactShowModal').modal('show');
        },
        error: function (result) {
            alert(result);
        }
    });
    return false;
}


function deletePost(id) {
    var ans = confirm("Are you sure you want to delete this post?");
    if (ans) {
        $.ajax({
            url: "/administrator/post/delete/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                $("#row_post_" + id).remove();
                alert(result);
            },
            error: function (result) {
                alert(result);
            }
        });
    }
}