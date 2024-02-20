namespace ClassLibrary1.Entidades
{
    public class Triangulo
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }

        private TipoDeBorde tipoDeBorde;

        public TipoDeBorde TipoDeBorde
        {
            get { return tipoDeBorde; }
            set { tipoDeBorde = value; }
        }
        private ColorRelleno colorRelleno;

        public ColorRelleno ColorRelleno
        {
            get { return colorRelleno; }
            set { colorRelleno = value; }
        }
        public Triangulo()
        {
        }
        public Triangulo(int ladoA, int ladoB, int ladoC, TipoDeBorde borde, ColorRelleno color)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
            TipoDeBorde = borde;
            ColorRelleno = color;
        }
        public double GetLadoA() => LadoA;
        public void SetLadoA(int medida1)
        {
            if (medida1 > 0)
            {
                LadoA = medida1;
            }
        }
        public double GetLadoB() => LadoB;
        public void SetLadoB(int medida2)
        {
            if (medida2 > 0)
            {
                LadoB = medida2;
            }
        }
        public double GetLadoC() => LadoC;
        public void SetLadoC(int medida3)
        {
            if (medida3 > 0)
            {
                LadoC = medida3;
            }
        }
        public double GetPerimetro() => (LadoA) + (LadoB) + (LadoC);
        public double GetSuperficie() => Math.Sqrt(GetPerimetro() * (GetPerimetro() - GetLadoA()) * (GetPerimetro() - GetLadoB()) * (GetPerimetro() - GetLadoC()));

        public object clone()
        {
            return this.MemberwiseClone();
        }
    }
}
