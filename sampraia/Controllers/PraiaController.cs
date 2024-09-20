using Microsoft.AspNetCore.Mvc;
using sampraia.Models;
using System.Diagnostics;

namespace sampraia.Controllers
{
    public class PraiaController : Controller
    {
        public IActionResult PraiaGrande()
        {
            var praiaGrande = new Praias {
                Nome = "Praia Grande",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/Praia_Grande.jpg",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "Algumas de suas praias estão contaminadas",
                localizacao = "SP"

    };


            return View(praiaGrande);
        } 
        public IActionResult Bertioga()
        {
            var Bertioga = new Praias {
                Nome = "Bertioga",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/Bertioga.jpg",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(Bertioga);
        }
        public IActionResult Itanhaem()
        {
            var Itanhaem = new Praias {
                Nome = "Itanhaém",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/Itanahém.jpg",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(Itanhaem);
        }
        public IActionResult Peruibe()
        {
            var Peruibe = new Praias {
                Nome = "Peruíbe",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/peruíbe.webp",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(Peruibe);
        } 
        public IActionResult Mongagua()
        {
            var Mongagua = new Praias {
                Nome = "Mongaguá",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/Monguagá.webp",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(Mongagua);
        } 
        public IActionResult Saovicente()
        {
            var Saovicente = new Praias {
                Nome = "São vicente",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/SV.jpg",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(Saovicente);
        }   
        public IActionResult Guaruja()
        {
            var Guaruja = new Praias {
                Nome = "Guarujá",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/Guaruja.jpg",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(Guaruja);
        }  
        public IActionResult Ubatuba()
        {
            var Ubatuba = new Praias {
                Nome = "Ubatuba",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/Ubatuba.jpg",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(Ubatuba);
        }   
        public IActionResult Santos()
        {
            var Santos = new Praias {
                Nome = "Santos",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/Santos.jpg",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(Santos);
        } 
        public IActionResult IlhaComprida()
        {
            var IlhaComprida = new Praias {
                Nome = "Ilha Comprida",
                avaliacao = "Recomendada pelos turistas",
                imagem = "~/img/IC.png",
                qualidadeagua = "Ondas Calmas e fáceis de pegar",
                descricao = "Praia Grande é uma das cidades mais populares do litoral sul do  " +
                "estado de São Paulo, Brasil. Com uma extensão de aproximadamente 23 km de litoral, " +
                "é conhecida por suas praias amplas e urbanizadas, que atraem turistas durante todo o ano.",
                contaminacao = "mal",
                localizacao = "SP"

    };


            return View(IlhaComprida);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
