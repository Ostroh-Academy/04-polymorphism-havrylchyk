
namespace Patterns_lab_4
{
    public class HalfFactory
    {
        public static HalfPlane CreateHalf(bool isHalfSpace, double a1, double a2, double a3, double b)
        {
            if (isHalfSpace)
            {
                return new HalfSpace(a1, a2, a3, b);
            }
            else
            {
                return new HalfPlane(a1, a2, b);
            }
        }
    }
}
