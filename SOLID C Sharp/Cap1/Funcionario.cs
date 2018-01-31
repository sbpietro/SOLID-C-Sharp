﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_C_Sharp.Cap1
{
    public class Funcionario
    {
        public double SalarioBase { get; private set; }
        public Cargo Cargo { get; private set; }
        public Funcionario(Cargo cargo, double salarioBase)
        {
            this.Cargo = cargo;
            this.SalarioBase = salarioBase;
        }

        public double CalculaSalario()
        {
            return this.Cargo.Regra.Calcula(this);
        }
    }
}