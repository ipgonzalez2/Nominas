namespace Teoria3.Core
{
    public class Directivo : Empleado
    {
        public const int SalarioPorHoraPrefijado = 100;
        public const int SalarioBase = 1000;

        public Directivo(string nombre) : base(nombre, SalarioPorHoraPrefijado)
        {
            
        }

        public override int calculaNomina(int horas)
        {
            return base.calculaNomina(horas) + SalarioBase;
        }

        public override string ToString()
        {
            return base.ToString() + " (DIRECTIVO) ";
        }
    }
}