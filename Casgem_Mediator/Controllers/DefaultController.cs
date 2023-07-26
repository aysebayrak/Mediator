using Casgem_Mediator.MediatorPattern.Commands;
using Casgem_Mediator.MediatorPattern.Queires;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Casgem_Mediator.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetProductQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UodateProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
