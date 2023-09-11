using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Products
    {
        private int id;
        private string name;
        private int quantity;
        private decimal price;

        protected Products(int id, string name, int quantity, decimal price)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public int  GetID() { return id; }
        public void SetID(int id) { this.id = id;}
        public string GetName() { return name; }
        public void SetName(string name) {  this.name = name;}
        public int GetQuantity() { return quantity; }
        public void SetQuantity(int quantity) {  this.quantity = quantity;}
        public decimal GetPrice() { return price; }
        public void SetPrice(decimal price) {  this.price = price;}


        public virtual void Visualizar()
        {

            Console.WriteLine("\n\n*********************************************************************");
            Console.WriteLine("Dados do Produto:");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Numero do Produto: " + this.id);
            Console.WriteLine("Nome do Produto: " + this.name);
            Console.WriteLine("Quantidade Disponivel : " + quantity);
            Console.WriteLine("Preço: " + this.price);
        }
    }
}
