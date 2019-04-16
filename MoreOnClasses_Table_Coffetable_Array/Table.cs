using System;

namespace MoreOnClasses_Table_Coffetable_Array
{
    internal class Table
    {
        protected float width, height;

        public Table()
        {
        }
        public Table(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float Width
        {
            set { width = value; }
            get { return width; }
        }
        public float Height
        {
            set { height = value; }
            get { return height; }
        }

        virtual public void ShowData()
        {
            Console.WriteLine("Width: {0}, Heigth: {1}", width, height);
        }
    }
}