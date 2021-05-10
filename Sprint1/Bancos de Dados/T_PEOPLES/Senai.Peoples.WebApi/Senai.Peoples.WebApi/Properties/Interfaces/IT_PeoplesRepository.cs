using Senai.Peoples.WebApi.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Properties.Interfaces
{
    interface IT_PeoplesRepository
    {
        List<T_PeoplesDomain> ListarTodos();
        T_PeoplesDomain BuscarPorId(int id);
        void Cadastrar(T_PeoplesDomain novoNome);
        void AtualizarIdCorpo(T_PeoplesDomain Nome);
        void AtualizarIdUrl(int id, T_PeoplesDomain Nome);
        void Deletar(int id);
    }
}
