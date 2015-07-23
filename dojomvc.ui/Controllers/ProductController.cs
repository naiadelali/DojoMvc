using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DojoMvc.Ui.Models;
using DojoMvc.Dao;
using DojoMvc.Business;
using AutoMapper;
using System.Net;

namespace DojoMvc.Ui.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        private IProductBusiness pBusiness;

        public ProductController(IProductBusiness pBusiness)
        {
            this.pBusiness = pBusiness;
        }

        public ActionResult Index()
        {
            ProductModel produto = new ProductModel();
            produto.ListOfFilters = new List<string> {"Id","Name","Price" };
            produto.ListaDeProduto = pBusiness.SelectAll();

            return View(produto);
        }

        [HttpPost]
        public ActionResult Index(ProductModel p)
        {

            p.ListOfFilters = new List<string> { "Id", "Name", "Price" };

            switch (p.Filter)
            {
                case "Id":
                    p.ListaDeProduto = pBusiness.SelectAll().OrderBy(obj => obj.id).ToList();
                    break;
                case "Name":
                    p.ListaDeProduto = pBusiness.SelectAll().OrderBy(obj => obj.name).ToList();
                    break;
                case "Price":
                    p.ListaDeProduto = pBusiness.SelectAll().OrderBy(obj => obj.price).ToList();
                    break;
                default:
                    p.ListaDeProduto = pBusiness.SelectAll();
                    break;
            }
            return View(p);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
           
            ProductDao produto = pBusiness.SelectById(id);
            Mapper.CreateMap<ProductDao, ProductCadastroModel>();
            var p = Mapper.Map<ProductCadastroModel>(produto);

            return View(p);
        }

        [HttpGet]
        public ActionResult DeleteProduct(int id)
        {
            ProductDao p = new ProductDao();
            p = pBusiness.SelectById(id);
            pBusiness.Delete(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Novo()
        {
            ProductCadastroModel p = new ProductCadastroModel();
            return View(p);
        }

        [HttpPost]
        public ActionResult Save(ProductCadastroModel p)
        {
            if (ModelState.IsValid)
            {

                Mapper.CreateMap<ProductCadastroModel, ProductDao>();
                var produto = Mapper.Map<ProductDao>(p);
                if (produto.id > 0)
                    pBusiness.Update(produto);
                else
                    pBusiness.Insert(produto);

                return RedirectToAction("Index");
            }
            if (p.id > 0)
                return View("Edit", p);
            else
            return View("Novo", p);

        }

       
        public ActionResult ViewProduct(int id)
        {
            if (ModelState.IsValid)
            {
                ProductCadastroModel p = new ProductCadastroModel();
                Mapper.CreateMap<ProductCadastroModel, ProductDao>();
                var produto = Mapper.Map<ProductDao>(p);
                produto = pBusiness.SelectById(id);
                return View(produto);
            }
            return RedirectToAction("Index");
        }
    }
}
