using Microsoft.AspNetCore.Mvc;
using UniversoGeek.API.Models;
using UniversoGeek.Application.Interfaces;
using UniversoGeek.Application.ViewModel;
using UniversoGeek.Domain.Entities;

namespace UniversoGeek.API.Controllers.V1
{
    [ApiController]
    [Route("api/v1/Client")]
    public class ClientController : Controller
    {
        private readonly IClientAppService _ClientAppService;

        public ClientController(IClientAppService ClientAppService)
        {
            _ClientAppService = ClientAppService;
        }

        [HttpGet]
        // Traz todos os Clients cadastrados no sistema
        public async Task<ActionResult> Get()
        {
            var result = await _ClientAppService.SearchAsync(a => true);

            return Ok(result);
        }

        [HttpGet("{id}")]
        // Traz um Client de acordo com o seu ID
        public async Task<ActionResult<ClientViewModel>> Get(Guid id)
        {
            var result = await _ClientAppService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        //Insere um Client no banco de dados
        public async Task<ActionResult> PostAsync([FromBody] ClientViewModel model)
        {
            var result = await _ClientAppService.AddAsync(model);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] ClientViewModel model)
        {
            return Ok(_ClientAppService.Update(model));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _ClientAppService.Remove(id);
            return Ok();
        }

        [HttpPost("redefinir-senha")]
        public async Task<ActionResult<ClientViewModel>> ResetPassword([FromBody] ResetPasswordRequest request)
        {
            //Verificar se o usuario e senha atual são válidos
            var clients = await _ClientAppService.SearchAsync(c => c.Email == request.Email && c.Password == request.SenhaAtual);
            if (clients.Any())
            {
                var client = clients.FirstOrDefault();

                var clientViewModel = _ClientAppService.UpdatePassword(client.Id, request.NovaSenha);

                return Ok(clientViewModel);
            }
            else
            {
                throw new Exception("Email ou Senha atual Incorretos");
            }
        }
    }
}

