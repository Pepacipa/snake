using snake;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // отрисовка линий
            HorisontalLine upline = new HorisontalLine(0, 78, 0, '+');
            HorisontalLine downline = new HorisontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '*');        
            VerticalLine rightline = new VerticalLine(0, 24, 78, '*');
            

            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            p.Draw();
        }        
    }
}