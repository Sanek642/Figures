namespace Figures
{
    public class Figure:IFigures
    {
        private IFigures figure;
        public double Area => figure.Area;
        public Figure(IFigures f)
        {
            figure = f;
        }
    }
}