using System;
namespace Abst_Polmorph_Interf_Sealed.Models
{
    class Square : Figure
    {
        private int side;
        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value > 0)
                {
                    side = value;

                }

            }
        }

        public Square(int side)
        {
            this.Side = side;
        }

        public override int CalcArea()
        {
            return side * side;
        }
    }
}
