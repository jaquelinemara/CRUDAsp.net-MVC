// Jaqueline Mara Silva 

using System.Linq;
using Asp.netCoreExercicio01Manha.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreExercicio01Manha.Controllers
{
    public class PedidoController : Controller
    {
        public readonly OrderContext _context;


        public PedidoController(OrderContext context)
        {
            _context = context;
        }


        public IActionResult Index() // Listar os pedidos
        {
            var lista = _context.Pedidos.ToList();
            return View(lista);
        }


        [HttpGet] // carregar a página em branco
        public IActionResult Cadastrar() // Método "CadastrarPedido" do Enunciado 
        {
            var pedido = new Pedido();
            return View(pedido);
        }


        [HttpPost] // enviar dados digitados na tela ao banco
        public IActionResult Cadastrar(Pedido pedido) // Método "CadastrarPedido" do Enunciado 
        {
            if (ModelState.IsValid)
            {
                _context.Pedidos.Add(pedido);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedido);
        }


        [HttpGet]
        public IActionResult Editar(int PedidoId)
        {
            var pedido = _context.Pedidos.Find(PedidoId);
            if(pedido != null)
            {
                
            }
            return View(pedido);
        }


        [HttpPost]
        public IActionResult Editar(Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                _context.Pedidos.Update(pedido);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(pedido);
            }
        }


        [HttpGet]
        public IActionResult Deletar(int PedidoId)
        {
            var pedido = _context.Pedidos.Find(PedidoId);
            return View(pedido);
        }

        [HttpPost]
        public IActionResult Deletar(Pedido _pedido)
        {
            var pedido = _context.Pedidos.Find(_pedido.PedidoId);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pedido);
        }
    }
} 
