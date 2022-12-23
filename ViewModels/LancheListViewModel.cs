using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Models;

namespace Projeto.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable <Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}