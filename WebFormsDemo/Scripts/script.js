$("document").ready(() => {
    setInterval(() => {
        //ajax call every 30 second
        $.ajax({
            url: "getmessage.aspx",
            dataType: "text",
            success: (result) => { $("#userMessageCorner").text(result) }
        });
    }, 30_000);
});