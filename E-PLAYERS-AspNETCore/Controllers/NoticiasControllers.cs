
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using EPlayers.Models;
using System.IO;

namespace Eplayers_mvc.Controllers
{
    public class NoticiasController : Controller
    {
      Noticias noticiasModel = new Noticias();

        public IActionResult Index()
        {
            ViewBag.Noticias = noticiasModel.ReadAll();
            return View();
        }

        public IActionResult Publicar(IFormCollection form)
        {
            Noticias novanoticia = new Noticias();
            novanoticia.IdNoticia = Int32.Parse(form["IdNoticia"]);
             // Upload Imagem
            
            // Upload Início
            var file    = form.Files[0];
            var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Noticias");

            if(file != null)
            {
                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))  
                {  
                    file.CopyTo(stream);  
                }
                novanoticia.Imagem   = file.FileName;
            }
            else
            {
                novanoticia.Imagem   = "padrao.png";
            }
            // Fim upload imagem
            novanoticia.Titulo = form["Titulo"];
            novanoticia.Texto = form["Texto"];

            noticiasModel.Create(novanoticia);
            ViewBag.Noticias = noticiasModel.ReadAll();
            return LocalRedirect("~/Noticias");
        }

         [Route ("Noticia/{id}")]
          public IActionResult Excluir(int id)
          {
              noticiasModel.Delete(id);
              return LocalRedirect("~/Noticias");
          }

      
    }
}