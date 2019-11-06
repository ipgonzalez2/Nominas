﻿namespace Teoria3.Core
{
    public class Obrero : Empleado
    {
        public const int SalarioPorHoraPrefijado = 50;

        public Obrero(string nombre) : base(nombre, SalarioPorHoraPrefijado)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + " (OBRERO) ";
        }
    }
}