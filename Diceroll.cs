using System ;

namespace SnakeLadder{

    public class DiceRoll{
        public static int rolldice(){
            Random random = new Random();
            
            int dicenumber = random.Next(1,7);
            return dicenumber ;
            }
        }

    }

