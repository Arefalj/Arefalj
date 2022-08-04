using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using lastproject.Server.Controllers;
using lastproject.Shared.Models;

namespace lastproject.Server.DB
{
    public class ClotheProvider
    {
        private readonly ClotheDbContext _context;
        private readonly ILogger _logger;

        public ClotheProvider(ClotheDbContext context, ILoggerFactory loggerFactory)
        {
            this._context = context;
            this._logger = loggerFactory.CreateLogger("ClotheProvider");
        }

        public void AddClothe(Clothe clothe)
        {
            int newId;
            if (this._context.Clothes.Count() > 0)
            {
                newId = this._context.Clothes.Select(arg => arg.Id).Max() + 1;
            }
            else
                newId = 1;
            clothe.Id = newId;
            _context.Clothes.Add(clothe);
            _context.SaveChanges();
        }

        public List<Clothe> GetAllClothes()
            => this._context.Clothes.ToList();

        public void RemoveClothe(int id)
        {
            var clothe = this._context.Clothes.Where(arg => arg.Id == id).FirstOrDefault();
            if (clothe != null)
            {
                var obj = clothe as Clothe;
                this._context.Clothes.Remove(obj);
            }
            _context.SaveChanges();
        }

        public void UpdateClothe(Clothe clothe)
        {
            this._context.Clothes.Update(clothe);
            
            _context.SaveChanges();
        }

        public void UpdateDB(List<Clothe> clothes)
        {
            this._context.Clothes.UpdateRange(clothes);
            _context.SaveChanges();
        }
    }
}