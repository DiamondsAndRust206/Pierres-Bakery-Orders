using Microsoft.AspNetCore.Mvc;
using OrderOrganizer.Models;
using System;
using System.Collections.Generic;

namespace OrderOrganizer.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> Vendors = Vendor.GetAll();
      return View(Vendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }

}