using System;
using System.Collections.Generic;
using NHibernate.Criterion;
using ReefTank.Core.Domain;
using ReefTank.Models.Base;

namespace ReefTank.Services.Creatures
{
    public class CreatureService : ICreatureService
    {
        private readonly IRepository<Creature> _creatureRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Subcategory> _subcategoryRepository;
        private readonly IRepository<Genus> _genusRepository;

        public CreatureService(IRepository<Creature> creatureRepository, IRepository<Subcategory> subcategoryRepository, IRepository<Genus> genusRepository, IRepository<Category> categoryRepository)
        {
            _creatureRepository = creatureRepository;
            _subcategoryRepository = subcategoryRepository;
            _genusRepository = genusRepository;
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Creature> GetCreatures()
        {
            return _creatureRepository.FindAll();
        }

        public IEnumerable<Creature> GetCreaturesByCategory(Category category)
        {
            var query = QueryOver.Of<Creature>()
                .Where(x => x.Genus.Subcategory.Category.Id == category.Id);

            //var q = QueryOver.Of<Creature>()
            //    .JoinQueryOver(x => x.Genus)
            //    .JoinQueryOver(x => x.Subcategory)
            //    .JoinQueryOver(x => x.Category)
            //    .Where(x => x.Id == category.Id);
            return _creatureRepository.FindBy(query.DetachedCriteria);
        }

        public IEnumerable<Creature> GetCreaturesBySubcategory(Subcategory subcategory)
        {
            var query = QueryOver.Of<Creature>()
                .Where(x => x.Genus.Subcategory.Category.Id == subcategory.Id);

            //var q = QueryOver.Of<Creature>()
            //    .JoinQueryOver(x => x.Genus)
            //    .JoinQueryOver(x => x.Subcategory)
            //    .Where(x => x.Id == subcategory.Id);
            return _creatureRepository.FindBy(query.DetachedCriteria);
        }

        public IEnumerable<Creature> GetCreaturesByGenus(Genus genus)
        {
            var query = QueryOver.Of<Creature>()
                .Where(x => x.Genus.Id == genus.Id);

            //var q = QueryOver.Of<Creature>()
            //    .JoinQueryOver(x => x.Genus)
            //    .Where(x => x.Id == Genus.Id);
            return _creatureRepository.FindBy(query.DetachedCriteria);
        }

        public Creature GetCreature(Guid id)
        {
            return _creatureRepository.FindBy(id);
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.FindAll();
        }

        public Category GetCategory(Guid id)
        {
            return _categoryRepository.FindBy(id);
        }

        public IEnumerable<Subcategory> GetSubcategories()
        {
            return _subcategoryRepository.FindAll();
        }

        public Subcategory GetSubcategory(Guid id)
        {
            return _subcategoryRepository.FindBy(id);
        }

        public IEnumerable<Genus> GetGeneraBySubcategory(Subcategory subcategory)
        {
            var query = QueryOver.Of<Genus>()
                .Where(x => x.Subcategory.Id == subcategory.Id);
            return _genusRepository.FindBy(query.DetachedCriteria);
        }

        public Genus GetGenus(Guid id)
        {
            return _genusRepository.FindBy(id);
        }
    }
}
