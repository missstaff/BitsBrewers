using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BitsBrewers.Models;

namespace BitsRESTfulAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly BitsContext _context;

        public RecipesController(BitsContext context)
        {
            _context = context;
        }

        // GET: api/Recipe
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipe()
        {
            // converting to a list
            return await _context.Recipe.ToListAsync();
        }

        // GET BY ID: api/Recipe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recipe>> GetRecipe(int id)
        {
            var recipe = await _context.Recipe.FindAsync(id);

            if (recipe == null)
            {
                return NotFound();
            }

            return recipe;
        }

        //search by name
        [HttpGet("name/{name}")]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipeByName(string name)
        {
            var recipe = await _context.Recipe.Include("Style")
                                              .Include("Batch")
                                              .Include("Equipment").Where(r => r.Name == name).ToListAsync();

            if (recipe.Count == 0)
            {
                return NotFound();
            }

            return recipe;
        }

        // api/recipe/equipment/name
        [HttpGet("equipment/{name}")]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetEquipmentByRecipeEquipmentName(string name)
        {
            var recipe = await _context.Recipe.Include("Equipment").Where(recipe => recipe.Name == name).ToListAsync();
            if (recipe == null)
            {
                return NotFound();
            }

            return recipe;
        }

        //search by style
        [HttpGet("type/{name}")]
        public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipeByStyle(string name)
        {
            var recipe = await _context.Recipe.Include("Style").Where(r => r.Style.Name == name).ToListAsync();

            if (recipe.Count == 0)
            {
                return NotFound();
            }

            return recipe;
        }

        [HttpPut("{name}")]
        public async Task<IActionResult> PutRecipe(string name, Recipe recipe)
        {
            if (name != recipe.Name)
            {
                return BadRequest();
            }

            _context.Entry(recipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(name))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool RecipeExists(string name)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Recipe/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipe(int id, Recipe recipe)
        {
            if (id != recipe.RecipeId)
            {
                return BadRequest();
            }

            _context.Entry(recipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Recipe>> PostRecipe(Recipe recipe)
        {
            _context.Recipe.Add(recipe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecipe", new { id = recipe.RecipeId }, recipe);
        }

        // DELETE: api/Recipe/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Recipe>> DeleteRecipe(int id)
        {
            var recipe = await _context.Recipe.FindAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }

            _context.Recipe.Remove(recipe);
            await _context.SaveChangesAsync();

            return recipe;
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipe.Any(e => e.RecipeId == id);
        }
    }
}
