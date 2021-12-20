var r = document.querySelector(':root');

function Validate() {
    let regex = /^[a-z][a-z ]*$/ig
    let string = document.getElementById('inp').value;
    let isValid = regex.test(string);

    if (isValid) {
        $('#inp').popover('hide');
        $('#subButton').prop('disabled', false); 
        r.style.setProperty('--color', 'green');
    }
    else {
        $('#inp').popover('show');  //shows popover with invalid input message
        $('#subButton').prop('disabled', true); //disables button
        r.style.setProperty('--color', 'red');  //changes border color
    }
}

function GetValue() {
    let rangeValue = document.getElementById("customRange1").value;
    console.log(rangeValue);
    document.getElementById("slider").innerHTML = rangeValue;
}