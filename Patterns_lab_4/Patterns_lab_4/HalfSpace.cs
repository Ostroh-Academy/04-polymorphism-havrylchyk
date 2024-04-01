namespace Patterns_lab_4
{
    public class HalfSpace : HalfPlane
    {

        private double a3;

        public HalfSpace(double a1, double a2, double a3, double b) : base(a1, a2, b)
        {
            this.a3 = a3;
        }

        public override void SetCoefficients(double a1, double a2, double b)
        {
            base.SetCoefficients(a1, a2, b);
            this.a3 = a3;
        }

        public override void PrintCoefficients()
        {
            base.PrintCoefficients();
            Console.WriteLine($"a3 = {a3}");
        }


        public override bool IsPointInHalfPlane(double x1, double x2)
        {
            Console.WriteLine("Cannot check point in half space without specifying third coordinate.");
            return false;
        }

        public bool IsPointInHalfSpace(double x1, double x2, double x3)
        {
            return (a1 * x1 + a2 * x2 + a3 * x3 <= b);
        }

        //public void SetCoefficients(double a1, double a2, double b)
        //{
        //    base.SetCoefficients(a1, a2, b);
        //    this.a3 = a3;
        //}

        //public void PrintCoefficients()
        //{
        //    base.PrintCoefficients();
        //    Console.WriteLine($"a3 = {a3}");
        //}

        //public bool IsPointInHalfPlane(double x1, double x2)
        //{
        //    Console.WriteLine("Cannot check point in half space without specifying third coordinate.");
        //    return false;
        //}

        //public bool IsPointInHalfSpace(double x1, double x2, double x3)
        //{
        //    return (a1 * x1 + a2 * x2 + a3 * x3 <= b);
        //}
    }
}
