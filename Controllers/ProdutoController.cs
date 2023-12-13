using Microsoft.AspNetCore.Mvc;
using Produto.Contracts.Repository;


namespace Produto.Controllers
{

    [ApiController]
    [Route("produto")]
    public class ProdutoController: ControllerBase
    {
      private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _produtoRepository.Get());
        }


    }
}
