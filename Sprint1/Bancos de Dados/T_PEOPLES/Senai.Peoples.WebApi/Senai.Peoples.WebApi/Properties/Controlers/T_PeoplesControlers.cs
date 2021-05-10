using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Properties.Domains;
using Senai.Peoples.WebApi.Properties.Interfaces;
using Senai.Peoples.WebApi.Properties.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Properties.Controlers
{
    public class T_PeoplesControlers
    {
        [Produces("application/json")]


        [Route("api/[controller]")]


        [ApiController]

        public class T_PeoplesControler : ControllerBase
        {

            private IT_PeoplesRepository _t_peoplesRepository { get; set; }


            public T_PeoplesControler()
            {
                _t_peoplesRepository = new T_PeoplesRepository();
            }


            [HttpGet]
            public IActionResult Get()
            {

                List<T_PeoplesDomain> listaNomes = _t_peoplesRepository.ListarTodos();


                return Ok(listaNomes);
            }


            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {

                T_PeoplesDomain nomeBuscado = _t_peoplesRepository.BuscarPorId(id);


                if (nomeBuscado == null)
                {

                    return NotFound("Nenhum nome encontrado!");
                }


                return Ok(nomeBuscado);
            }


            [HttpPost]
            public IActionResult Post(T_PeoplesDomain novoNome)
            {

                _t_peoplesRepository.Cadastrar(novoNome);


                return StatusCode(201);
            }


            [HttpPut("{id}")]
            public IActionResult PutIdUrl(int id, T_PeoplesDomain nomeAtualizado)
            {

                T_PeoplesDomain nomeBuscado = _t_peoplesRepository.BuscarPorId(id);


                if (nomeBuscado == null)
                {
                    return NotFound
                        (
                            new
                            {
                                mensagem = "Nome não encontrado!",
                                erro = true
                            }
                        );
                }


                try
                {

                    _t_peoplesRepository.AtualizarIdUrl(id, nomeAtualizado);


                    return NoContent();
                }

                catch (Exception codErro)
                {

                    return BadRequest(codErro);
                }
            }


            [HttpPut]
            public IActionResult PutIdBody(T_PeoplesDomain nomeAtualizado)
            {

                T_PeoplesDomain nomeBuscado = _t_peoplesRepository.BuscarPorId(nomeAtualizado.idnome);


                if (nomeBuscado != null)
                {

                    try
                    {

                        _t_peoplesRepository.AtualizarIdCorpo(nomeAtualizado);


                        return NoContent();
                    }

                    catch (Exception codErro)
                    {

                        return BadRequest(codErro);
                    }
                }


                return NotFound
                    (
                        new
                        {
                            mensagem = "Nome não encontrado!"
                        }
                    );
            }


            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {

                _t_peoplesRepository.Deletar(id);


                return StatusCode(204);
            }
        }
    }
}
