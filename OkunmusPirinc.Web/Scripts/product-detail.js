let element = document.getElementById("preview");
let img = document.getElementById("zoomImage");

function zoomIn(event) {
    element.style.background = "url(" + img.src + ")";
    element.style.display = "block";
    let posX = event.offsetX ? (event.offsetX) : event.pageX - img.offsetLeft;
    let posY = event.offsetY ? (event.offsetY) : event.pageY - img.offsetTop;
    element.style.backgroundPosition = (-posX) + "px " + (-posY) + "px";

}
function zoomOut() {
    element.style.display = "none";
}