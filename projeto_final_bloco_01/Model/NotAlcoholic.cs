using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public class NotAlcoholic : Products
    {
        private string description;
        public NotAlcoholic(int id, string name, int quantity, decimal price, string description) : base(id, name, quantity, price)
        {
            this.description = description;
        }

        public string GetDescritpion() { return description; }
        public void SetDescription(string description) { this.description = description;}

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("Descrção do Produto: " + description);

        }
    }
}
