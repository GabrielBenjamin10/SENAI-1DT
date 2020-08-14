using System.Collections.Generic;
using EPlayers.Models;

namespace EPlayers.Interfaces
{
    public interface IEquipes

    
    {
        
        // Métodos CRUD 
        void Create(Equipes e);

        List<Equipes> ReadAll();

        void Update(Equipes e);

        void Delete(int id);
    }
}