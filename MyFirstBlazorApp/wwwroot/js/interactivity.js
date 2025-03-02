function initializeMap(mapElement) {
    let isDragging = false;
    let startX, startY;

    mapElement.addEventListener('mousedown', (e) => {
        isDragging = true;
        startX = e.clientX - mapElement.offsetLeft;
        startY = e.clientY - mapElement.offsetTop;
    });

    document.addEventListener('mousemove', (e) => {
        if (isDragging) {
            mapElement.style.left = `${e.clientX - startX}px`;
            mapElement.style.top = `${e.clientY - startY}px`;
        }
    });

    document.addEventListener('mouseup', () => {
        isDragging = false;
    });
}
