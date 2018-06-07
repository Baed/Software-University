namespace E09.Rectangle_Intersection
{
    using System;

    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double x;
        private double y;

        public Rectangle(string id, double width, double height, double topLeftHoriz, double topLeftVert)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = topLeftHoriz;
            this.y = topLeftVert;
        }

        public double Height
        {
            get { return this.height; }
        }

        public double Width
        {
            get { return this.width; }
        }

        public double X
        {
            get { return this.x; }
        }

        public double Y
        {
            get { return this.y; }
        }

        public bool InteresectsWith(Rectangle rectangle)
        {
            if (
                this.x <= rectangle.x + rectangle.width 
                && rectangle.x <= this.x + this.width  
                && this.y <= rectangle.y + rectangle.height 
                && rectangle.y <= this.y + this.height
                )
            {
                return true;
            }

            return false;
        }
    }
}
