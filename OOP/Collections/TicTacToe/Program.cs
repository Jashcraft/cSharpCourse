using TicTacToe;

class Program
{

  static char[,] fieldData =
  {
      {'1', '2', '3' },
      {'4', '5', '6' },
      {'7', '8', '9' }
  };

  static void Main()
  {
    int player = 2; //Player 1 starts
    int input = 0;
    bool inputCorrect = true;
    int winner = 0;
    bool gameOver =  false;




    DrawField();


    //run code as long as program runs
    do
    {

      if (player == 2)
      {
        player = 1;
        GameMove(player, input);
      }
      else if (player == 1)
      {
        player = 2;
        GameMove(player, input);
      }
      DrawField();

      #region Check Winner
      //check winning condition
      if ((fieldData[0,0] == 'X') && (fieldData[1,0] == 'X') && (fieldData[2,0] == 'X'))
      {
        winner = 1; gameOver = true;
      }
      if ((fieldData[0, 2] == 'X') && (fieldData[1, 2] == 'X') && (fieldData[2, 2] == 'X'))
      {
        winner = 1; gameOver = true;
      }
      if ((fieldData[0, 0] == 'X') && (fieldData[0, 1] == 'X') && (fieldData[0, 2] == 'X'))
      {
        winner = 1; gameOver = true;
      }
      if ((fieldData[1, 0] == 'X') && (fieldData[1, 1] == 'X') && (fieldData[1, 2] == 'X'))
      {
        winner = 1; gameOver = true;
      }
      if ((fieldData[2, 0] == 'X') && (fieldData[2, 1] == 'X') && (fieldData[2, 2] == 'X'))
      {
        winner = 1; gameOver = true;
      }
      if ((fieldData[0, 0] == 'X') && (fieldData[1, 1] == 'X') && (fieldData[2, 2] == 'X'))
      {
        winner = 1; gameOver = true;
      }
      if ((fieldData[0, 2] == 'X') && (fieldData[1, 1] == 'X') && (fieldData[2, 0] == 'X'))
      {
        winner = 1; gameOver = true;
      }

      if ((fieldData[0, 0] == 'O') && (fieldData[1, 0] == 'O') && (fieldData[2, 0] == 'O'))
      {
        winner = 2; gameOver = true;
      }
      if ((fieldData[0, 2] == 'O') && (fieldData[1, 2] == 'O') && (fieldData[2, 2] == 'O'))
      {
        winner = 2; gameOver = true;
      }
      if ((fieldData[0, 0] == 'O') && (fieldData[0, 1] == 'O') && (fieldData[0, 2] == 'O'))
      {
        winner = 2; gameOver = true;
      }
      if ((fieldData[1, 0] == 'O') && (fieldData[1, 1] == 'O') && (fieldData[1, 2] == 'O'))
      {
        winner = 2; gameOver = true;
      }
      if ((fieldData[2, 0] == 'O') && (fieldData[2, 1] == 'O') && (fieldData[2, 2] == 'O'))
      {
        winner = 2; gameOver = true;
      }
      if ((fieldData[0, 0] == 'O') && (fieldData[1, 1] == 'O') && (fieldData[2, 2] == 'O'))
      {
        winner = 2; gameOver = true;
      }
      if ((fieldData[0, 2] == 'O') && (fieldData[1, 1] == 'O') && (fieldData[2, 0] == 'O'))
      {
        winner = 2; gameOver = true;
      }
      #endregion

      #region Test If Field Taken
      do
      {
        Console.WriteLine("\n Player {0}: Choose your move: ", player);

        try { input = Convert.ToInt32(Console.ReadLine()); }
        catch { Console.WriteLine("Please Enter A Number! Press Enter To Try Again:"); Console.Read(); }

        if ((input == 1) && (fieldData[0, 0] == '1'))
        {
          inputCorrect = true;
        }

        else if ((input == 2) && (fieldData[0, 1] == '2'))
        {
          inputCorrect = true;
        }

        else if ((input == 3) && (fieldData[0, 2] == '3'))
        {
          inputCorrect = true;
        }

        else if ((input == 4) && (fieldData[1, 0] == '4'))
        {
          inputCorrect = true;
        }

        else if ((input == 5) && (fieldData[1, 1] == '5'))
        {
          inputCorrect = true;
        }

        else if ((input == 6) && (fieldData[1, 2] == '6'))
        {
          inputCorrect = true;
        }

        else if ((input == 7) && (fieldData[2, 0] == '7'))
        {
          inputCorrect = true;
        }

        else if ((input == 8) && (fieldData[2, 1] == '8'))
        {
          inputCorrect = true;
        }

        else if ((input == 9) && (fieldData[2, 2] == '9'))
        {
          inputCorrect = true;
        }
        else
        {
          Console.WriteLine("Incorrect Input! Please user another field!");
          inputCorrect = false;
        }

      } while (!inputCorrect);
      #endregion

    } while (!gameOver);

    Console.WriteLine("We Have a winner!\nPlayer {0} wins!", winner);
    Console.WriteLine("Press 'q' to quit");
    Console.WriteLine("Press any other key to reset game:");
    string userReset = Console.ReadLine();
    if (userReset == "q")
    {
            Console.WriteLine("Goodbye");
        } else { Console.WriteLine("resetting"); gameOver = false; DrawField(); }

        Exit();
    }


  public static void DrawField()
  {

    Console.Clear();
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fieldData[0, 0], fieldData[0, 1], fieldData[0, 2]);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fieldData[1, 0], fieldData[1, 1], fieldData[1, 2]);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |     ");
    Console.WriteLine("  {0}  |  {1}  |  {2}  ", fieldData[2, 0], fieldData[2, 1], fieldData[2, 2]);
    Console.WriteLine("     |     |     ");

  }

  public static void GameMove(int player, int input)
  {

    char playerSign = ' ';

    if (player == 1)
    {
      playerSign = 'X';
    }
    else if (player == 2)
    {
      playerSign = 'O';
    }


    switch (input)
    {
      case 1:
        { fieldData[0, 0] = playerSign; }
        break;
      case 2:
        { fieldData[0, 1] = playerSign; }
        break;
      case 3:
        { fieldData[0, 2] = playerSign; }
        break;
      case 4:
        { fieldData[1, 0] = playerSign; }
        break;
      case 5:
        { fieldData[1, 1] = playerSign; }
        break;
      case 6:
        { fieldData[1, 2] = playerSign; }
        break;
      case 7:
        { fieldData[2, 0] = playerSign; }
        break;
      case 8:
        { fieldData[2, 1] = playerSign; }
        break;
      case 9:
        { fieldData[2, 2] = playerSign; }
        break;
    }
  }
  public static void Exit()
  {
    Console.WriteLine("\nProgram will eXit in 4 seconds...");
    System.Threading.Thread.Sleep(4000);
  }

}