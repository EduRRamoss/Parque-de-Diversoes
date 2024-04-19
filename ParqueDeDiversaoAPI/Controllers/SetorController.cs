using Microsoft.AspNetCore.Mvc;
using ParqueDeDiversaoAPI.ApplicationDbContext;
using ParqueDeDiversaoAPI.Entities;
using ParqueDeDiversaoAPI.Repositories;

namespace ParqueDeDiversaoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SetorController : ControllerBase
{
    private readonly Context _context;
    private readonly GenericRepository<Setor> _genericRepo;



    public SetorController(GenericRepository<Setor> genericRepo, Context context)
    {
        _context = context;
        _genericRepo = genericRepo;
    }

    [HttpPost("adicionar-novo-setor")]
    public async Task<ActionResult<Setor>> CriarNovoSetor([FromBody] Setor entradaSetor){
        try
        {
            if(entradaSetor == null)
                return BadRequest("Há infos invalidas no setor, tente novamente!");

            var setorModel = new Setor {
                codigo = entradaSetor.codigo,
                nome = entradaSetor.nome,
                descricaoSetor = entradaSetor.descricaoSetor,
                valorLiquidoArrecadado = entradaSetor.valorLiquidoArrecadado,
            };

            return Ok(await _genericRepo.Add(setorModel));
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    [HttpGet("obter-todos-os-setores")]
    public async Task<ActionResult<IEnumerable<Setor>>> ObterTodosSetores(){
        try
        {
            return Ok(await _genericRepo.GetAll());
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    
}
