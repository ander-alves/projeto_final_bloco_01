using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Alcoholics : Products
    {
        private decimal alcoholContent;

        public Alcoholics(int id, string name, int quantity, int type, decimal price, decimal alcoholContent) : base(id, name, quantity, type, price)
        {
            this.alcoholContent = alcoholContent;
        }

        public decimal GetAlcoholContent() { return this.alcoholContent; }
        public void SetAlcoholContent(decimal alcoholContent) { this.alcoholContent = alcoholContent; }




        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Percentual de Alcool: " + alcoholContent + "%");
        }
    }
}
