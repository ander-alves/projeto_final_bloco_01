using projeto_final_bloco_01.Model;
using projeto_final_bloco_01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace projeto_final_bloco_01.Controller
{
    public class ProductsController : IProductsRepository
    {
        private readonly List<Products> listProducts = new();
        private int id;
        public void Create(Products product)
        {
            listProducts.Add(product);
            Console.WriteLine($"O Produto {product.GetName()}, foi cadastrado com Sucesso.");
  
        }

        public void Delete(int id)
        {
            var product = FindOnCollection(id);
            if (product != null)
            {
                if (listProducts.Remove(product) == true)
                    Console.WriteLine($"O Produto Com ID : {id}, foi Removido com Sucesso.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto com ID numero {id}, nao foi encontrado ");
                Console.ResetColor();
            }
        }

        public void FindById(int id)
        {
            var product = FindOnCollection(id);
            if (product is not null)
                product.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto {id}, não Existe");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public void FindByName(string name)
        {
            var findByName = from product in listProducts
                                   where product.GetName().Contains(name)
                                   select product;
            findByName.ToList().ForEach(name => { name.Visualizar(); });
        }

        public void ListAll()
        {
            foreach(var item in listProducts)
            {
                item.Visualizar();
            }
        }

        public void Update(Products product)
        {
            var findProduct = FindOnCollection(product.GetID());

            if (findProduct is not null)
            {
                var index = listProducts.IndexOf(findProduct);

                listProducts[index] = product;

                Console.WriteLine($"O Produto {product.GetID()} foi atualizado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto Com numero {product.GetID()} não foi encontrado!");
                Console.ResetColor();
            }
        }

        internal int gerarId()
        {
            return ++id;
        }

        public Products? FindOnCollection(int id)
        {
            foreach (var product in listProducts)
            {
                if (product.GetID() == id)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
