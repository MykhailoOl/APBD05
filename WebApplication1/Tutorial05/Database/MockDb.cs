using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class MockDb
    {
        public AnimalRepository animalRepository { get; set; } = new AnimalRepository();
        public VisitRepository visitRepository { get; set; } = new VisitRepository();   

        public MockDb()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            animalRepository.add(new Animal(1, "Jhon", "Dog", 9, "Black"));
            animalRepository.add(new Animal(2, "Kitty", "Cat", 6.3, "Orange"));
            visitRepository.add(new Visit(1, new DateTime(2024, 4, 11), 100, "Visit1", animalRepository.getAnimalById(1)));
            visitRepository.add(new Visit(2, new DateTime(2024, 4, 12), 200, "Visit2", animalRepository.getAnimalById(1)));
            visitRepository.add(new Visit(3, new DateTime(2024, 4, 13), 300, "Visit3", animalRepository.getAnimalById(2)));
        }
    }
}
