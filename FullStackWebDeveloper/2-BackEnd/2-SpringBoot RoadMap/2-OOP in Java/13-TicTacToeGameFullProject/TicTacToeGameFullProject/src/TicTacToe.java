public class TicTacToe
{
    public char PlayerChoice;
    public char ComputerChoice;
    private boolean IsValidCharacter;
    private boolean IsValidSpace;
    public boolean IsFull = false;
    private int Counter = 0;


    TicTacToe(char PlayerChoice)
    {
        if((int)PlayerChoice != 79 && (int)PlayerChoice != 88)
        {
            IsValidCharacter = false;
            return;
        }
        this.PlayerChoice = PlayerChoice;
        if (PlayerChoice == 'X')
            ComputerChoice = 'O';
        else
            ComputerChoice = 'X';

        IsValidCharacter = true;
    }
    public void DrawGame (char [] GameShapeInputs)
    {
        System.out.println("-------");
        System.out.println("|" + GameShapeInputs[0] + "|" + GameShapeInputs[1] + "|" + GameShapeInputs[2] + "|");
        System.out.println("-------");
        System.out.println("|" + GameShapeInputs[3] + "|" + GameShapeInputs[4] + "|" + GameShapeInputs[5] + "|");
        System.out.println("-------");
        System.out.println("|" + GameShapeInputs[6] + "|" + GameShapeInputs[7] + "|" + GameShapeInputs[8] + "|");
        System.out.println("-------");
    }
    public boolean GetIsValidCharacter()
    {
        return IsValidCharacter;
    }
    public boolean GetIsFull()
    {
        Counter++;
        if(Counter == 9)
        {
            IsFull = true;
        }
        return IsFull;
    }
    public void PlayerRound(char [] GameShapeInputs, int ElementIndexArray)
    {
        GameShapeInputs[ElementIndexArray] = PlayerChoice;
    }
    public void ComputerRound(char [] GamesShapeInputs)
    {
        int ComputerIndex;
        do
        {
            ComputerIndex = (int)(Math.random()*9);
        }while(GamesShapeInputs[ComputerIndex]!='-');
        GamesShapeInputs[ComputerIndex] = ComputerChoice;
    }
    public char WhoIsWinner(char [] Games)
    {
        if(Games[0] == Games[1] && Games[1] == Games[2] && Games[1] == 'X')
            return 'X';
        else if(Games[3] == Games[4] && Games[4] == Games[5] && Games[3] == 'X')
            return 'X';
        else if(Games[6] == Games[7] && Games[7] == Games[8] && Games[8] == 'X')
            return 'X';
        else if(Games[0] == Games[3] && Games[3] == Games[6] && Games[6] == 'X')
            return 'X';
        else if(Games[1] == Games[4] && Games[4] == Games[7] && Games[7] == 'X')
            return 'X';
        else if(Games[2] == Games[5] && Games[5] == Games[8] && Games[8] == 'X')
            return 'X';
        else if(Games[2] == Games[4] && Games[4] == Games[6] && Games[6] == 'X')
            return 'X';
        else if(Games[0] == Games[4] && Games[4] == Games[8] && Games[8] == 'X')
            return 'X';
        if(Games[0] == Games[1] && Games[1] == Games[2] && Games[1] == 'O')
            return 'O';
        else if(Games[3] == Games[4] && Games[4] == Games[5] && Games[3] == 'O')
            return 'O';
        else if(Games[6] == Games[7] && Games[7] == Games[8] && Games[8] == 'O')
            return 'O';
        else if(Games[0] == Games[3] && Games[3] == Games[6] && Games[6] == 'O')
            return 'O';
        else if(Games[1] == Games[4] && Games[4] == Games[7] && Games[7] == 'O')
            return 'O';
        else if(Games[2] == Games[5] && Games[5] == Games[8] && Games[8] == 'O')
            return 'O';
        else if(Games[2] == Games[4] && Games[4] == Games[6] && Games[6] == 'O')
            return 'O';
        else if(Games[0] == Games[4] && Games[4] == Games[8] && Games[8] == 'O')
            return 'O';
        return 'Z';
    }
}
