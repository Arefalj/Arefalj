using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using lastproject.Server.DB;
using lastproject.Shared.Models;

namespace lastproject.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClotheController : Controller
    {
        private readonly ClotheProvider _provider;

        public ClotheController(ClotheProvider provider)
        {
            this._provider = provider;
        }

        [HttpPost]
        [Route("addNewClothToDb")]
        public Clothe AddNewClotheToDb(Clothe clothe)
        {
            this._provider.AddClothe(clothe);
            return clothe;
        } 

        [HttpGet]
        [Route("getClothes")]
        public List<Clothe> GetAllClothesFromDb() =>
            this._provider.GetAllClothes();

        [HttpDelete]
        [Route("DeleteClothe")]
        public void RemoveClothe(int id) =>
            this._provider.RemoveClothe(id);

        [HttpPut]
        [Route("UpdateClothe")]
        public void UpdateClothe(Clothe clothe) =>
            this._provider.UpdateClothe(clothe);

        [HttpPut]
        [Route("updateDB")]
        public void updateDB(List<Clothe> clothes)
        {
            this._provider.UpdateDB(clothes);
        }
    }
}

