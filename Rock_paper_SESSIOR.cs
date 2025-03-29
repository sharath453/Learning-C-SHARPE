using System;
class game{
    static void Main()
    {
        String player_symbol;
        String bot_symbol;
        bool playgame=true;
        
        while(playgame)
        {
            player_symbol="";
            bot_symbol="";
            
            while(player_symbol!="ROCK" && player_symbol!="PAPER" && player_symbol!="SESSIOR")
            {
                Console.WriteLine("SElect the symbol: ROCK, PAPER, SESSIOR");
                player_symbol=Console.ReadLine();
                player_symbol=player_symbol.ToUpper();
            }
            
            Random Computer=new Random();
            switch(Computer.Next(1,4))
            {
                case 1 :
                bot_symbol="ROCK";
                break;
                
                case 2: 
                bot_symbol="PAPER";
                break;
                
                case 3: 
                bot_symbol="SESSIOR";
                break;
            }
            
            Console.WriteLine("player Symbol : "+player_symbol);
            Console.WriteLine("bot_symbol: "+bot_symbol);
            
            switch(player_symbol)
            {
                case "ROCK": 
                    if(bot_symbol=="ROCK")
                    {
                        Console.WriteLine("it is draw");
                    }
                    else if(bot_symbol=="PAPER")
                    {
                        Console.WriteLine("Bot win the match");
                    }
                    else{
                        Console.WriteLine("Player won the match");
                    }
                    break;
                    
                case "PAPER":
                    if(bot_symbol=="PAPER")
                    {
                        Console.WriteLine("it is a Draw");
                    }
                    else if(bot_symbol=="ROCK")
                    {
                        Console.WriteLine("Player won the match");
                    }
                    else{
                        Console.WriteLine("Bot won the match");
                    }
                break;
                
                case "SESSIOR":
                    if(bot_symbol=="SESSIOR")
                    {
                        Console.WriteLine("it is a Draw");
                    }
                    else if(bot_symbol=="ROCK")
                    {
                        Console.WriteLine("bot won the match");
                    }
                    else{
                        Console.WriteLine("player won the match");
                    }
                break;
            }
            Console.WriteLine();
            Console.WriteLine("DO u want to play again(Y/N)");
            char respond=char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if(respond!='Y')
            {
                Console.WriteLine("Thank You for Playing!");
                Console.WriteLine("----------------------------------------------------------------");
                playgame=false;
            }
        }
    }
}