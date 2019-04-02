def isSolved(board):
    # 0 if a spot is empty, 
    # 1 if it is an "X", 
    # 2 if it is an "O", 


    # -1 if the board is not yet finished (there are empty spots),
    # 1 if "X" won,
    # 2 if "O" won,
    # 0 if it's a cat's game (i.e. a draw).
     
    for row in board: 
        print(row) 

    # check winning first 
    # check tie 
    # check for empty 
    print("#"*50) 
    r = 0 
    c = 0 

    # 1 - 3 winning moves  
    moves = list() 
    while r < len(board): 
        for col in range(0, len(board[0])): 
            moves.append(board[r][col]) 
        if len(set(moves)) == 1: 
            if list(set(moves))[0] != 0: 
                return list(set(moves))[0]
        moves = list() 
        r += 1 
        
    moves = list() 
    print("passed 1-3") 

    # 4 - 6 winning moves 
    r = 0 
    while r < len(board): 
        for col in range(0, len(board[0])): 
            moves.append(board[col][r]) 

        if len(set(moves)) == 1: 
            if list(set(moves))[0] != 0: 
                return list(set(moves))[0]
        moves = list() 
        r += 1 

    moves = list() 
    print("passed 4-6") 

    # 7 diagnol1 winning diagnol 
    for diagnol in range(0, len(board)): 
        moves.append(board[diagnol][diagnol]) 

    if len(set(moves)) == 1: 
        if 0 in list(set(moves)): 
            None  
        else: 
            return list(set(moves))[0]
    moves = list() 
    print("passed 7") 

    # 8 diagnol2 winning diagnol 
    d = len(board)  
    for diagnol in range(0, len(board)): 
        d -= 1 
        moves.append(board[diagnol][d]) 

    if len(set(moves)) == 1: 
        if 0 in list(set(moves)): 
            None  
        else: 
            return list(set(moves))[0]
    print("passed 8") 

    for row in board: 
        if 0 in row: 
            return -1 # board not finished 
    return 0 #draw 

arr = [
         [2, 1, 0],
         [2, 0, 1],
         [0, 2, 1]]
print(isSolved(arr)) 
''' 
Assume that the board comes in the form of a 3x3 array, where the value is 0 if a spot is empty, 1 if it is an "X", or 2 if it is an "O", like so:

[[0, 0, 1],
 [0, 1, 2],
 [2, 1, 0]]
We want our function to return:

-1 if the board is not yet finished (there are empty spots),
1 if "X" won,
2 if "O" won,
0 if it's a cat's game (i.e. a draw).
''' 
