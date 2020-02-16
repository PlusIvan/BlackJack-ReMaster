{

let test = {
    list:[{a:1,b:2},{a:4}]

};
delete test.list[1];

test.list = test.list.filter(function (el) {
    return el != null;
});

console.log(test);
console.log(test.list.length);
    /*
    const room = {
        players: [
            {
                username: "Bot",
                socket:"XXX",
                cards:[{card:"As",value:11},{card:"7s",value:7}],
                move:"",
                pot: 0
            }
        ]
    }
    
    room.players.forEach(function(item, index, object) {
        item.username = "Not";
        

    });

    console.log( room.players);
*/

    }