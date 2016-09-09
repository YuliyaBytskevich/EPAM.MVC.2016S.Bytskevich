$(document).ready(function() {
    PopUpHide("#declinePopup");
    PopUpHide("#acceptPopup");
});

function PopUpShow(popupSelector) {
    $(popupSelector).show();
}

function PopUpHide(popupSelector) {
    $(popupSelector).hide();
}