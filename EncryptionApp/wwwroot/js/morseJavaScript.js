var r = document.querySelector(':root');

function Validate() {
    let string = document.getElementById('inp').value;
    let isValid;

    if (string[0] == '.' || string[0] == '-') {

        let regex = /^\s*(?:\s*(?:\.-|-\.\.\.|-\.-\.|-\.\.|\.|\.\.-\.|--\.|\.\.\.\.|\.\.|\.---|-\.-|\.-\.\.|--|-\.|---|\.--\.|--\.-|\.-\.|\.\.\.|-|\.\.-|\.\.\.-|\.--|-\.\.-|-\.--|--\.\.|-----|\.----|\.\.---|\.\.\.--|\.\.\.\.-|\.\.\.\.\.|-\.\.\.\.|--\.\.\.|---\.\.|----\.|\.-\.-\.-|--\.\.--|\.\.--\.\.|-\.-\.--|\.--\.-\.|\/)(?=\s|\s*$))+\s*$/gm
        isValid = regex.test(string);
    }
    else {
        let regex = /^[a-zA-Z0-9.,?!][a-zA-Z0-9\s.,?!]*$/gm
        isValid = regex.test(string)
    }
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