function prepareWord() {
    $.get("/api/urbanword", function (data) {
        localStorage.setItem('word', data.Word);
        localStorage.setItem('desc', data.Definition);
    })
}

function displayWord() {
    let word = localStorage.getItem('word');
    let desc = localStorage.getItem('desc');
    document.getElementById("word").innerHTML = word;
    document.getElementById("desc").innerHTML = desc;
    prepareWord();
}

function getWord(word) {
    $.post("/api/urbanword/" + word, function (data) {
        document.getElementById("word").innerHTML = data.Word;
        document.getElementById("desc").innerHTML = data.Definition;
        document.getElementById("urbanSearch").value = "";
        document.getElementById("urbanSearch").classList.remove("is-invalid");
        document.getElementById("urbanSearchFeedback").innerHTML = "";
    })

        .fail(function () {
            document.getElementById("urbanSearch").classList.add("is-invalid");
            document.getElementById("urbanSearch").value = "";
            document.getElementById("urbanSearchFeedback").innerHTML = "Word Not Found";
        })
}
