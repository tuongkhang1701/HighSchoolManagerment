var subjectController = function () {
    this.initialize = function () {
        loadData();
    }

    function loadData() {
        $.ajax({
            type: 'GET',
            url: '/Admin/Subject/GetAll',
            dataType: 'json',
            success: function (response) {
                var template = $('#subject-template').html();
                var render = '';
                $.each(response, function (i, item) {
                    render += Mustache.render(template, {
                        Code: item.Code,
                        Name: item.Name
                    });
                });
                if (render !== undefined) {
                    $('#table-content').html(render);
                }
            },
            error: function (error) {
                console.log(error);
            }
        });
    }
}