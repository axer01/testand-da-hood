local prefixe = "/"

    local Message = (prefixe.. "clean".." "):rep(100000)

    for i = 1, 750 do
        game.Players:Chat(Message)
    end 
