function buttonClick() {

    var currentWindow = window,
        currentWindow = currentWindow.navigator.appCodeName,
        isMozilla = currentWindow === "Mozilla";

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}