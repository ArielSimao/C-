using System;

namespace ProjetoSalario
{
    class Funcionario
    {
        private static readonly int Comissao = 1;
        private static readonly int Imposto = 3;
        private static readonly int AjudaCusto = 200;
        private static readonly int ValeTranspote = 50;

        public string nome { get; set; }
        public double salBruto { get; set; }
        public double adicionais { get; private set; }
        public double descontos { get; private set; }

        private Boolean imposto;

        public Boolean impostoProp
        {
            get { return imposto; }
            set
            {
                this.imposto = value;
                calcularDescontos();
            }
        }

        private Boolean valeTransporte;

        public Boolean valeTransporteProp
        {
            get { return this.valeTransporte; }
            set
            {
                this.valeTransporte = value;
                calcularDescontos();
            }
        }

        private Boolean comissao;

        public Boolean comissaoProp
        {
            get { return this.comissao; }
            set
            {
                this.comissao = value;
                calcularAdicionais();
            }
        }

        private Boolean ajudaCusto;

        public Boolean ajudaCustoProp
        {
            get { return ajudaCusto; }
            set
            {
                this.ajudaCusto = value;
                calcularAdicionais();
            }
        }

        private double salarioLiquido;

        public double salarioLiquidoProp
        {
            get { return this.salBruto + this.adicionais - this.descontos; }
            set { salarioLiquido = value; }
        }

        private void calcularDescontos()
        {
            this.descontos = 0;

            if (this.valeTransporte)
            {
                this.descontos += ValeTranspote;
            }

            if (this.imposto)
            {
                this.descontos += (this.salBruto / 100 * Imposto);
            }
        }

        private void calcularAdicionais()
        {
            this.adicionais = 0;

            if (this.ajudaCusto)
            {
                this.adicionais += AjudaCusto;
            }

            if (this.comissao)
            {
                this.adicionais += (this.salBruto / 100 * Comissao);
            }
        }
    }
}