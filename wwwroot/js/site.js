$(document).on('change', ':file', function () {
    var input = $(this),
        numFiles = input.get(0).files ? input.get(0).files.length : 1,
        label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
    input.parent().parent().next(':text').val(label);
});

function upload() {
    var file = $("#upfile");
    var formData = new FormData();

    formData.append("File", file[0].files[0]);
    formData.append("Value", "test");

    $.ajax({
        url: "api/upload/",
        dataType: "json",
        type: "POST",
        data: formData,
        contentType: false,
        processData: false,
        async: false,
        success: function (data) {
            alert("Upload Success!!" + " fileName:" + data.fileName + " fileSize:" + data.length);
        },
        error: function (data) {
            alert("Upload Error!!");
        }
    });
}