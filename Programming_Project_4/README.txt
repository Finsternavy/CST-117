Christopher Finster
CST-117
Programming_Project_4  Tic-Tac-Toe
Obtainable at: https://github.com/Finsternavy/CST-117/tree/main/Programming_Project_4

Explanation of deviation from instructions:
Original instructions did not take many of the rules of tic-tac-toe into consideration.  
If I had followed to instructions, the game would not function correctly.

The instruction for problem 8 at the end of chapter 7 in Starting Out With Visual C# 4th 
addition did not take into account player turns and would allow an uneven number of X’s or O’s.

For example, if the first three indexes all randomized to the same value the game would be won 
with only x’s or only o’s displayed.  This logical pattern does not consider player turns.

To correct these issues, instead of randomizing each board space, I randomized what board space
the current player would select and alternate between player turns.  This ensures a back-and-forth 
flow and a balance between board spaces that reflect “X” and “O”. 
 
I also added a delay to allow the user to follow the game.

I also added a method to convert an (x, y) coordinate to a linear coordinate.  This allowed me to update labels that are not contained in a 2D array by index, correctly. 

