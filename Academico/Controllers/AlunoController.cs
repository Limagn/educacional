using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
	public class AlunoController : Controller
	{
		private static List<Aluno> alunos = new List<Aluno>();
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(Aluno aluno)
		{
			alunos.Add(aluno);
			return View();
		}

		public IActionResult Index()
		{
			return View(alunos);
		}
	}
}
