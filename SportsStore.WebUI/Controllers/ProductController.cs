using SportsStore.Domain.Abstract;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;
        public ProductController(IProductsRepository ProductRepository)
        {
            this.repository = ProductRepository;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}