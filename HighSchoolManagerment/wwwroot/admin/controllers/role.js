var roleController = function () {
    this.initialize = function () {
        loadData();
    }

    function loadData(isPageChanged) {
        $.ajax({
            type: 'GET',
            url: '/Admin/Role/GetAllPaging',
            data: {
                keyword: $('#txtKeyword').val(),
                pageIndex: admin.config.pageIndex,
                pageSize: admin.config.pageSize

            },
            dataType: 'json',
            success: function (response) {
                var template = $('#role-template').html();
                var render = "";
                if (response.RowCount > 0) {
                    $.each(response.TotalRow, function (i, item) {
                        render += Mustache.render(template, {
                            Name: item.Name,
                            Description: item.Description
                        });
                    });
                }
                if (render !== undefined) {
                    $('#table-content').html(render);
                }

                wrapPaging(response.RowCount, function () {
                    loadData();
                }, isPageChanged);

            },
            error: function (error) {
                console.log(error)
            }


        });
    }

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / admin.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                tedu.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
}