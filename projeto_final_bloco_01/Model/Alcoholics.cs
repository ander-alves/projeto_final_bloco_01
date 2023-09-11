using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class Alcoholics : Products
    {
        private int alcoholContent;

        public Alcoholics(int id, string name, int quantity, decimal price, int alcoholContent) : base(id, name, quantity, price)
        {
            this.alcoholContent = alcoholContent;
        }

        public int GetAlcoholContent() { return this.alcoholContent; }
        public void SetAlcoholContent(int alcoholContent) { this.alcoholContent = alcoholContent; }




        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Percentual de Alcool: " + alcoholContent + "%");
        }
    }
}
