﻿function LoadingOverlayShow(id) {
    $(id).LoadingOverlay("show", {
        color: "rgba(255, 255, 255, 0.5)",
        image: "/Content/loading.gif",
        imageResizeFactor: 0.6,
        //  imageAnimation: "1.5s fadein",
    });
}
function LoadingOverlayHide(id) {
    $(id).LoadingOverlay("hide");
}