
function loadPlayground() {
    const server = new XMLHttpRequest();
    server.onload = function () {
        refreshPlayground(server.responseText);
    }
    server.open("GET", "reload");
    server.send();
}
function startGame() {
    const server = new XMLHttpRequest();
    server.onload = function () {
        refreshPlayground(server.responseText);
    }
    server.open("GET", "restart");
    server.send();
}

function onKeydown(event) {
    switch (event.code) {
        case 'ArrowUp':
            move('up')
            break;
        case 'ArrowDown':
            move('down')
            break;
        case 'ArrowLeft':
            move('left')
            break;
        case 'ArrowRight':
            move('right')
            break;
    }
}

function move(direction) {
    const server = new XMLHttpRequest();
    server.onload = function () {
        refreshPlayground(server.responseText);
    }
    server.open("GET", direction);
    server.send();
}

function stopServer() {
    const server = new XMLHttpRequest();
    server.onload = function () {
        refreshPlayground(server.responseText);
    }
    server.open("GET", "stop");
    server.send();
}

function refreshPlayground(html) {
    console.log(html);
    document.getElementById("playground").innerHTML = html;
}
