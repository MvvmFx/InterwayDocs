var confirmationMessage = "Do you want to leave this page?";

function enableUnloadConfirmation(message) {
    confirmationMessage = message;
    window.addEventListener("beforeunload", askUnloadConfirmation);
}

function disableUnloadConfirmation() {
    window.removeEventListener("beforeunload", askUnloadConfirmation);
}

function askUnloadConfirmation(e) {
    // https://developer.mozilla.org/en-US/docs/Web/API/WindowEventHandlers/onbeforeunload
    /*
    When this event returns (or sets the returnValue property to) a value other than null or undefined, 
    the user is prompted to confirm the page unload.
    In some browsers, the return value of the event is displayed in this dialog.
    Starting with Firefox 4, Chrome 51, Opera 38 and Safari 9.1, a generic string 
    not under the control of the webpage will be shown instead of the returned string. 
    */
    // NOTE - IE 11 shows this string

    e.returnValue = confirmationMessage; // Gecko, Trident, Chrome 34+
    return confirmationMessage; // Gecko, WebKit, Chrome <34
}
