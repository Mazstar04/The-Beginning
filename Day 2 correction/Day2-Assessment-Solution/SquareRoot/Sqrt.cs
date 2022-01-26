namespace SquareRoot
{
    public class Sqrt
    {
        public double Squareroot(double n)
        {
            double lastGuess; // a variable for holding previous guess
            
            double nextGuess = 1; //initializing the next guess to be 1 as a startoff 
            do
            {
                lastGuess = nextGuess; 
                // passing our previous guess to the lastguess variable since its not the one (1 cant be the coreect value too. we handled that already)
                
                nextGuess = (lastGuess + (n / lastGuess)) / 2; // computing for the next guess
            } 
            while (lastGuess - nextGuess >= 0.0001 || nextGuess - lastGuess >= 0.0001);
            //checking if the diffrence between the guesses is between of exactly our 0.0001 precision
            
            return nextGuess; // returning the nearest square root found
        }
    }
}