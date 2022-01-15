/* Валидация данных */
window.onload = function () {
    if (document.querySelector("input")) {
        let inputs = document.querySelectorAll("input");
        inputs.forEach(element => replaceToCorrectValue(element));
    }
};

function replaceToCorrectValue(input) {
    let inputButton = document.getElementById("submitButton");
    input.oninput = function () {
        //this.value = this.value.replace(/[^0-9\.,]/g, '');
        var x = this.value.length - 1;
        if (this.value[x] == ",") {
            inputButton.disabled = true;
            input.parentElement.classList.add("same-error");
            inputButton.classList.add("lock"); // ref ПЛОХО БЛОКИРУЕТСЯ КНОПКА, ИСПРАВИТЬ
        } else {
            inputButton.disabled = false;
            input.parentElement.classList.remove("same-error");
            inputButton.classList.remove("lock"); // ref
        }
        //console.log(input);
        if (this.value == "") {
            inputButton.disabled = true;
            inputButton.classList.add("lock"); // ref
            input.parentElement.classList.add("error");
        } else if (this.value[x] != ",") {
            inputButton.disabled = false;
            inputButton.classList.remove("lock"); // ref
            input.parentElement.classList.remove("error");
        }
    };
}

$("input, select, textarea").attr("autocomplete", "off");
$("input").numeric({ decimal: ",", negative: false, scale: 3 });