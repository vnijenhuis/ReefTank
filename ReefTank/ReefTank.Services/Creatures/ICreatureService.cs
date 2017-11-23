using System;
using System.Collections.Generic;
using ReefTank.Models.Base;

namespace ReefTank.Services.Creatures
{
    public interface ICreatureService
    {
        IEnumerable<Creature> GetCreatures();
        IEnumerable<Creature> GetCreaturesByCategory(Category category);
        IEnumerable<Creature> GetCreaturesBySubcategory(Subcategory subcategory);
        IEnumerable<Creature> GetCreaturesByGenus(Genus genus);
        Creature GetCreature(Guid id);

        IEnumerable<Category> GetCategories();
        Category GetCategory(Guid id);

        IEnumerable<Subcategory> GetSubcategories();
        Subcategory GetSubcategory(Guid id);

        IEnumerable<Genus> GetGeneraBySubcategory(Subcategory subcategory);
        Genus GetGenus(Guid id);
    }
}