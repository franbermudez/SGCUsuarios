using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGC.Models;
using SGC.ViewModels;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SGC.Controllers
{
    public class UsuariosController : Controller
    {
        //objetos de solo lectura, instancias de las clases repositorios
        private readonly INiveles _nivelesRepositorio;
        private readonly IUsuariosRepositorios _usuariosRepositorio;

        //constructor de la clase controller

        public UsuariosController(IUsuariosRepositorios usuariosRepositorio, INiveles nivelesRepositorios)
        {
            _nivelesRepositorio = nivelesRepositorios;
            _usuariosRepositorio = usuariosRepositorio;
        }//fin constructor

        //metodo para devolver la vista ListaUsuarios
       /* public ViewResult ListaUsuarios(string buscar)
        {
            UsuariosViewModels listaUsuariosViewModel = new UsuariosViewModels();
            listaUsuariosViewModel.Usuarios = _usuariosRepositorio.Usuarios;
            

            return View(listaUsuariosViewModel);
        }//fin de la vista*/


        public ViewResult ListaUsuarios(string buscar)//CodigoUsuario
        {
            //objetos para mostrar  usuarios

            UsuariosViewModels listausuariosViewModel = new UsuariosViewModels();
            listausuariosViewModel.Usuarios = _usuariosRepositorio.Usuarios;

            //Pasando un valor a la variable de la clase

            /*ViewData["filtro1"] = CodigoUsuario;
            if (!string.IsNullOrEmpty(CodigoUsuario))
            {
                listausuariosViewModel.Usuarios = _usuariosRepositorio.UsuariosPorCodigo(Convert.ToInt32(CodigoUsuario));


            }*/
            return View(listausuariosViewModel);
        }//fin del metodo ListaUsuarios


        //metodo para devolver la vista Administradores
        public ViewResult ListaUsuariosPorNivel(string buscar)//CodigoUsuario
        {
            UsuariosViewModels listaUsuariosPorNivelViewModel = new UsuariosViewModels();
            listaUsuariosPorNivelViewModel.Usuarios = _usuariosRepositorio.UsuariosPorNivel;

           /* ViewData["filtro1"] = CodigoUsuario;
            if (!string.IsNullOrEmpty(CodigoUsuario))
            {
                listaUsuariosPorNivelViewModel.Usuarios = _usuariosRepositorio.UsuariosPorCodigo(Convert.ToInt32(CodigoUsuario));


            }*/

            return View(listaUsuariosPorNivelViewModel);
        }//fin de la vista



        //metodo para devolver la vista ListaNiveles
        public ViewResult ListaNiveles(string buscar)
        {
            UsuariosViewModels Niveles = new UsuariosViewModels();
            Niveles.Niveles = _nivelesRepositorio.ListaNiveles;


            return View(Niveles);
        }//fin de la vista



    }
}
