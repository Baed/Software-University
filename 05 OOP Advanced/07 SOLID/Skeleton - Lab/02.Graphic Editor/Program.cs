namespace _02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {
            IShape rectange = new Rectangle();

            GraphicEditor graphicEditor = new GraphicEditor();

            graphicEditor.DrawShape(rectange);
        }
    }
}
