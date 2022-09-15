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
    public Cake[] GetAllCakes()
    {
        //Return productService.GetAllCakes();
        return Cakes;
    }

    [Route("cupcakes")]
    [HttpGet]
    public Cupcake[] GetAllCupcakes()
    {
        //Return productService.GetAllCupcakes();
        return Cupcakes;
    }

    [Route("cakes/{id}")]
    [HttpGet]
    public Cake GetCake(int id){
        //Return productService.GetCake(id);
        return Cakes[id];
    }

    [Route("cupcakes/{id}")]
    [HttpGet]
    public Cupcake GetCupcake(int id){
        //Return productService.getCupcake(id);
        return Cupcakes[id];
    }
    private static readonly Cake[] Cakes = 
    {
        new Cake()
        {
            Id = 1,
            Name = "Chocolate"
        },
        new Cake(){
            Id = 2,
            Name = "Vanilla"
        },
        new Cake(){
            Id = 3,
            Name = "Strawberry"
        }
    };

    private static readonly Cupcake[] Cupcakes = 
    {
        new Cupcake()
        {
            Id = 1,
            Name = "Chocolate"
        },
        new Cupcake(){
            Id = 2,
            Name = "Vanilla"
        },
        new Cupcake(){
            Id = 3,
            Name = "Strawberry"
        }
    };

}