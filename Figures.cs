namespace Figures
{
    public class Figure
    {
        private IFigures figure;
        public double Area => figure.Area;

        public Figure() { }
        public Figure(IFigures f)
        {
            figure = f;
        }
    }
}