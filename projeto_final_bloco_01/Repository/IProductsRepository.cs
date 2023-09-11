using projeto_final_bloco_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Repository
{
    public interface IProductsRepository
    {
        //Metodos Crud
        public void FindById(int id);
        public void ListAll();
        public void Create(Products product);
        public void Update(Products product);
        public void Delete(int id);
        public void FindByName(string name);
    }
}
