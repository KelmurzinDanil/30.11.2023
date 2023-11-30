namespace Tumakov_12
{
    internal class ComplexNumber
    {
        readonly double realPart;
        readonly double imaginaryPart;

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }

        public double RealPart { get { return realPart; } }
        public double ImaginaryPart { get { return imaginaryPart; } }

        public static ComplexNumber operator +(ComplexNumber n1, ComplexNumber n2)
        {
            return new ComplexNumber(n1.RealPart + n2.RealPart, n1.ImaginaryPart + n2.ImaginaryPart);
        }
        public static ComplexNumber operator -(ComplexNumber n1, ComplexNumber n2)
        {
            return new ComplexNumber(n1.RealPart - n2.RealPart, n1.ImaginaryPart - n2.ImaginaryPart);
        }
        public static ComplexNumber operator *(ComplexNumber n1, ComplexNumber n2)
        {
            return new ComplexNumber(n1.RealPart * n2.RealPart - n1.ImaginaryPart * n2.ImaginaryPart, n1.RealPart * n2.ImaginaryPart - n1.ImaginaryPart * n2.RealPart);
        }
        public static bool operator ==(ComplexNumber n1, ComplexNumber n2)
        {
            return n1.RealPart == n2.RealPart && n1.ImaginaryPart == n2.ImaginaryPart;
        }
        public static bool operator !=(ComplexNumber n1, ComplexNumber n2)
        {
            return n1.RealPart != n2.RealPart || n1.ImaginaryPart != n2.ImaginaryPart;
        }
        public override string ToString()
        {
            return (imaginaryPart > 0 ? $"({realPart} + {imaginaryPart}i)" : $"({realPart} - {-imaginaryPart}i)");
        }
        public override bool Equals(object obj) //  Equals 
        {
            if (obj is ComplexNumber n)
            {
                return RealPart == n.RealPart && ImaginaryPart == n.ImaginaryPart;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode() => base.GetHashCode();
    }
}
