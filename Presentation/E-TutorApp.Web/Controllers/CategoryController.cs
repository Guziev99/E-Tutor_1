using E_TutorApp.Domain.Entities.Concretes;
using E_TutorApp.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_TutorApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        
        public CategoryController() { }



        public async Task< IActionResult> AddCategory(GetCategoryVM categoryVM)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newcategory = new Category()
            {
                Name = categoryVM.Name,
                Description = categoryVM.Description,
            };

            await _writeCategoryRepository.AddAsync(newcategory);
            await _writeCategoryRepository.SaveChangeAsync();
            return StatusCode(201);
            return View();
        }


        public async Task <IActionResult> GetAllCategories()
        {
            return View();
        }







    }
}
