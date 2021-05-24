var userController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
    }

    registerEvents = function () {
        document.getElementById("btnSearch").onclick = function () {
            search();
        }
        
    }

    /*search = function () {
        var keyword = document.getElementById("searchUser").value;
        fetch("/Admin/User/Search", {
            method: 'POST', // or 'PUT'
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ keyword: keyword }),
        })
            .then(response => response.json())
            .then(data => {
                console.log('Success:', data);
            })
            .catch((error) => {
                console.error('Error:', error);
            });
    }*/

    loadData() = function(){

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
                admin.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }



}