// login box
$("body").on("click", ".modal-signup-box .signup-email", function (e) {
    e.preventDefault();
    $(this).closest(".modal-signup-box").find(".simple-signup").hide();
    $(this).closest(".modal-signup-box").find(".email-signup").show();
    $(this).closest(".modal-signup-box").find(".email-signup").find(".input-text").eq(0).focus();
});

$("body").on("click", ".my-popupbox", function (e) {
    e.preventDefault();
    var sourceId = $(this).attr("href");
    if (typeof sourceId == "undefined") {
        sourceId = $(this).data("target");
    }
    if (typeof sourceId == "undefined") {
        return;
    }
    if ($(sourceId).length < 1) {
        return;
    }
    $(this).fPopup({
        wrapId: "my-popupbox",
    });
});