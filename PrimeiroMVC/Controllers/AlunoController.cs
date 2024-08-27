using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "João Rodolfo", "joao.r.costa7@aluno.senai.br", 123456);
            Aluno a2 = new Aluno(2, "Maria Eduarda", "maria@teste.com.br", 223344);
            Aluno a3 = new Aluno(3, "Arnaldo", "arnaldo@teste.com.br", 334455);
            Aluno a4 = new Aluno(4, "Eduardo", "eduardo@teste.com.br", 445566);
            Aluno a5 = new Aluno(5, "Pedro Alberto", "pedro@teste.com.br", 556677);

            List<Aluno> listaAlunos = new List<Aluno>();
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);

            return View(listaAlunos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
