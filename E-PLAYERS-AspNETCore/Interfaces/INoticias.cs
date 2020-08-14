using System.Collections.Generic;
using EPlayers.Models;

namespace EPlayers.Interfaces
{
    public interface INoticias
    {
        void Create(Noticias news);

        List<Noticias> ReadAll();

        void Update(Noticias news);

        void Delete(int id);
    }
}