$(function () {

    $(document).on("click", "show-more button", function () {
        let skip = parseInt($(".blogs-area").children().length);
        conosole.log(skip)
        $.ajax({
            url: `blog/showmore?skip=${skip}`,
            type: "GET",
            success: function (response) {
                conosole.log(skip)

            },
        });
    })


})