namespace Teoria3.Core
{
    public abstract class Empleado
    {
        protected Empleado(string nombre, int salarioHora)
        {
            this.Nombre = nombre;
            this.SalarioHora = salarioHora;
        }
        
        public string Nombre { get; }
        public int SalarioHora { get; set; }

        public virtual int calculaNomina(int horas)
        {
            return this.SalarioHora * horas;
        }

        public override string ToString()
        {
            return "Empleado: " + this.Nombre +
                   " Salario hora: " + this.SalarioHora;
        }
    }
}