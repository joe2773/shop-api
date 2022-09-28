using shopApi.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace shopApi.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController: ControllerBase{

    // private readonly productService;
    // public ProductController(IProductService productService){
    //     this.productService = productService;
    // }
    
    [Route("cakes")]
    [HttpGet]
    public string GetAllCakes()
    {
        //Return productService.GetAllCakes();
        return "cakes";
    }

    [Route("cupcakes")]
    [HttpGet]
    public string GetAllCupcakes()
    {
        //Return productService.GetAllCupcakes();
        return "Cupcakes";
    }

    [Route("cakes/{id}")]
    [HttpGet]
    public string GetCake(int id){
        //Return productService.GetCake(id);
        return "cake";
    }

    [Route("cupcakes/{id}")]
    [HttpGet]
    public string GetCupcake(int id){
        //Return productService.getCupcake(id);
        return "cupcake";
    }

}