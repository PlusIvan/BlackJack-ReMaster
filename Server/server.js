var app = require('express')();
var http = require('http').createServer(app);
var io = require('socket.io')(http);


const room = {
    players: [
        {
            username: "",
            secret: "",
            socket:""
        }
    ]
}


io.on('connection', function(socket){
    console.log('[+] Client Connected');



    socket.on('ping', function(msg){
        console.log(`[#] User: ${msg} requested ping`);
        io.emit('ping', 'pong');
    });


    socket.on('room_users', function(msg){
        let to_send = ``;
        room.players.forEach(element => {
            to_send += `${element.username}/`
        });
        io.emit('room_users', to_send);
    });



});

http.listen(3000, function(){
  console.log('listening on *:3000');
});