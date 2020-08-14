using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EPlayers.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EPlayers.Controllers
{
    public class EquipesController : Controller
    {
        Equipes equipeModel = new Equipes();
        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

         public IActionResult Cadastrar(IFormCollection form)
          {
            Equipes novaEquipe   = new Equipes();
            novaEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novaEquipe.Nome     = form["Nome"];
            // Upload Imagem
            
            // Upload Início
            var file    = form.Files[0];
            var folder  = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

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
                novaEquipe.Imagem   = file.FileName;
            }
            else
            {
                novaEquipe.Imagem   = "padrao.png";
            }
            // Fim upload imagem
            equipeModel.Create(novaEquipe);            
            return LocalRedirect("~/Equipes");
          }
        
        [Route ("Equipe/{id}")]
          public IActionResult Excluir(int id)
          {
              equipeModel.Delete(id);
              return LocalRedirect("~/Equipes");
          }


    }
}