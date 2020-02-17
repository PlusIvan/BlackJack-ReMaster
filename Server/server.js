const app = require('express')();
const http = require('http').createServer(app);
const io = require('socket.io')(http);
const wait = require('wait-for-stuff');

const room = {
    players: [
    ]
}
const table = {
    dealer_pts: 0,
    dealer:[]
};
const top_player = {
    username: "",
    strikes: 0
};
const top_exp = {
    username: "",
    exp: 0
};
io.on('connection', function(socket){
    console.log('[+] Client Connected');

    socket.on('disconnect', (reason) => {
        console.log('[+] Client Disconnected');
            room.players.forEach(function(item, index, object) {
                if (item.socket === socket.id){
                    object.splice(index, 1);
                    io.emit('chat',`[${item.username}] Left the game.`);   
                    console.log(`[${item.username}] disconnected`);                 
                }
            });
        let to_send = ``;
        room.players.forEach(element => {
            to_send += `${element.username}/`
        });
        io.emit('online_players', to_send);
      });

    socket.on('ping', function(msg){
        console.log(`[#] User: ${msg} requested ping`);
        io.emit('ping', 'pong');
    });

    socket.on('player_pts', function(points,command){
        room.players.forEach(element => {
            if(element.socket == socket.id){
                element.move = command;
                element.card_points = points;
            }
        });
    });
    socket.on('username!', function(player){
        console.log(`[+] Register user: ${player} Socket: ${socket.id}`);
        room.players.push({
            username: player,
            socket:socket.id,
            card_points:0,
            move:"",
            exp: 0,
            strikes: 0
        });
    io.emit('chat',`[SERVER] Player ${player} joined the game`);
    });
    socket.on('message!', function(player,msg){
        io.emit('chat',`[${player}] ${msg}`);
    });
    socket.on('online_players', function(msg){
        let to_send = ``;
        room.players.forEach(element => {
            to_send += `${element.username}/`
        });
        io.emit('online_players', to_send);
    });
    socket.on('my_command', function(cmd){
        room.players.forEach(element => {
            element.move = cmd;
        });
    });
});

setInterval(() => {
        let to_send = ``;
        room.players.forEach(element => {
            to_send += `${element.username}/`
        });
        io.emit('online_players', to_send);
}, 1100);

setInterval(() => {
    io.emit('username?', room.players);
}, 1100);

setInterval(() => {
    io.emit('message?');
}, 1000);

setInterval(() => {
    io.emit('top_player', `${top_player.username} - ${top_player.strikes}`);
}, 5000);

setInterval(() => {
    io.emit('top_exp', `${top_exp.username} - ${top_exp.exp}`);
}, 5000);

setInterval(() => {
    newFunction();
}, 60000);

http.listen(3000, function(){
  console.log('listening on *:3000');
});
function newFunction() {
    let players = room.players;
        if(players.length < 1){
            // io.emit('dealer', 'Not enough players');
             return;
         }
         console.log(`Starting game`);
         table.dealer = [];
         table.dealer_pts = 0;
         let deck = {
             type:["A","K","Q","J","10","9","8","7","6","5","4","3","2"],
             suit:["s","d","c","h"],
             list:[],
             shuffle:function sh() {
                 this.type.forEach(card => {
                     this.suit.forEach(suit => {
                         let value = 0;
                         if(["K","Q","J"].includes(card) == true)
                             value = 10;
                         else if (["A"].includes(card) == true)
                             value = 11;
                         else
                             value = Number(card);
                         this.list.push({card:`${card}${suit}`,value:value});    
                     });
                 });
                 this.mirror(1);
             },
             mirror:function mi(amount) {
                 for (let index = 0; index < amount; index++) 
                     this.list.push(this.list);
               this.sort();
             },
             sort:function so() {
                 for (let i = this.list.length - 1; i > 0; i--) {
                     const j = Math.floor(Math.random() * (i + 1));
                     [this.list[i], this.list[j]] = [this.list[j], this.list[i]];
                 }
             }
         }
         deck.shuffle();
         table.dealer.push({
             card:deck.list[0].card, 
             value:deck.list[0].value
         },{
             card:deck.list[1].card, 
             value:deck.list[1].value
         });
         table.dealer_pts = deck.list[0].value+deck.list[1].value
         for(x = 0; x < 15; x++){
             io.emit('intro', `${(14-x).toString()}s`);
             wait.for.time(1);
         }
         players.forEach(function(item, index, object) {
             io.emit('dealer_dist_cards', `${item.username}`);
             wait.for.time(1);
         });
     
         for(x = 0; x < 10; x++){
             io.emit('dealer_wait_for_commands', `${(9-x).toString()}s`);
             wait.for.time(1);
         }
     
     
         io.emit('dealer_say',`Showing my first card`);
         wait.for.time(1);
         io.emit('dealer_show_first_card',`${table.dealer[0].card}/${table.dealer[0].value}`);
         for(x = 0; x < 10; x++){
             io.emit('dealer_wait_for_commands', `${(9-x).toString()}s`);
             wait.for.time(1);
         }
         //io.emit('dealer_close_commands');
         io.emit('dealer_say',`Showing my second card`);
         wait.for.time(1);
         io.emit('dealer_show_second_card',`${table.dealer[1].card}/${table.dealer[1].value}`);
         io.emit('dealer_close_commands');
         io.emit('dealer_get_player_pts');
         wait.for.time(5);
                 console.log('Dealer pts: '+table.dealer_pts);
         players.forEach(function(item, index, object) {
             io.emit('dealer_say',`Looking at ${item.username}`);
             if(item.card_points == 0)
                return;
             
             if(item.move == "under"){
                 if(item.card_points < table.dealer_pts){
                     item.strikes++;
                     item.exp += item.card_points;
                     item.wins++;
                     io.emit('chat',`[${item.username}] Win ${item.card_points} exp`);
                 }else if(item.card_points == 22){
                     io.emit('chat',`[${item.username}] DOUBLE ACE WIN, 1000 EXP`);
                     item.exp += 1000;
                     item.strikes++;
                     item.wins++;
                 }else{
                     item.losses++;
                     item.strikes = 0;
                 }
                 if(item.strikes > top_player.strikes){
                     top_player.username = item.username;
                     top_player.strikes = item.strikes;
                 }
             }
             if(item.move == "over"){
                 if(item.card_points > table.dealer_pts){
                    item.strikes++;
                    item.exp += item.card_points;
                     io.emit('chat',`[${item.username}] Win ${item.card_points} exp`);
                 }else if(item.card_points == 22){
                     io.emit('chat',`[${item.username}] DOUBLE ACE WIN, 1000 EXP`);
                     item.exp += 1000;
                     item.strikes++;
                 }else{
                     item.strikes = 0;
                 }
             }
             if(item.strikes > top_player.strikes){
                top_player.username = item.username;
                top_player.strikes = item.strikes;
            }
            if(item.exp > top_exp.exp){
                top_exp.username = item.username;
                top_exp.exp = item.exp;
            }
             io.to(`${item.socket}`).emit('my_stats', `${item.exp}/${item.strikes}`);
             wait.for.time(1);
         });
     
             io.emit('dealer_say',`Next hand starting soon...`);
             wait.for.time(3);
}
