using System;

namespace CSharp_Practice_App
{

    public class Point
    {
        public int A;
        public int B;

        public Point(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public void Move(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public void Move(Point newLocation)
        {
            //this.A = newLocation.A;
            //this.B = newLocation.B;
            if (newLocation == null)
            {
                throw new ArgumentNullException("New Location");
            }
            Move(newLocation.A,newLocation.B);
        }


    }
}
