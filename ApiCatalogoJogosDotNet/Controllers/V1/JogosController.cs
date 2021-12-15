using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogosDotNet.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        // Por padrão é utilizado Task nos métodos de controller por ser assincrono e por ser melhor de gerir
        // por parte dos servidores que estão gerenciado-os
        // Se colocar só task, ele espera um retorno de task, se colocar o async ele espera um actionResult de lista de objetos
        //ActionResult indica qual o retorno da requisição (o status 400,200,500, etc)
        
        [HttpGet]
        public async Task<ActionResult<List<object>>> Obter() 
        {

            return Ok();
        
        }

        [HttpGet("{idJogo:guid}")]
        public async Task<ActionResult<List<object>>> Obter(Guid idJogo)
        {

            return Ok();

        }
        
        [HttpPost]
        public async Task<ActionResult<object>> InserirJogo(object jogo)
        {
            return Ok();
        }

        [HttpPut("{idJogo:guid}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, object jogo)
        {
            return Ok();
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")]
        public async Task<ActionResult> AtualizarJogo(Guid idJogo, , double preco)
        {
            return Ok();
        }

        [HttpDelete("{idJogo:guid}")]
        public async Task<ActionResult> ApagarJogo(Guid idJogo)
        {
            return Ok();
        }

    }
}
