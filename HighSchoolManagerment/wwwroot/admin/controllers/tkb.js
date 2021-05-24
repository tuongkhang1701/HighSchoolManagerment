tkbController = function () {
    this.init = function () {

    }

    function registerEvent() {
        $('#sltBuoi').on('change', function () {
            $.ajax({
                url: '/admin/tkb/GetByMaNH',
                method: 'post',
                data = { MaNH = $('#sltBuoi').val() },
                success: function (response) {

                },

                error: function (error) {

                }

            });
        });


    }


}