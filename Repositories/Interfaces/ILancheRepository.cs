using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Context;
using Projeto.Models;

namespace Projeto.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches {get;}
        IEnumerable<Lanche> LanchesPreferidos {get;}

        Lanche GetLancheById (int lancheId);

        IEnumerable<Lanche> GetLanchesPorCategoria(string categoria);

    }
}