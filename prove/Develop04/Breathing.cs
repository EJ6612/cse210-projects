namespace Develop04 
{
    public class Breathing : Activities
    {
        private int breatheIn, breatheOut;
        public Breathing(int userSeconds)
        {
            SplitTime(userSeconds);
            LoadSpinner(userSeconds);
        }

        private void SplitTime(int seconds)
        {
            int timeDivided = seconds / 8;
            breatheIn = timeDivided;
            breatheOut = timeDivided;
        }
    }
    
}