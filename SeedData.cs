namespace BlazingPizza.Data;

internal static class SeedData
{
    internal static Task InitializeAsync(PizzaStoreContext db)
    {
        PizzaSpecial[] specials =
        [
            new()
            {
                Name = "Basic Cheese Pizza",
                Description = "For the kids, or the kid in you",
                BasePrice = 9.99m,
                ImageUrl = "img/pizzas/cheese.jpg",
            },
            new()
            {
                Id = 2,
                Name = "The Baconatorizor",
                Description = "Everything is better with bacon",
                BasePrice = 11.99m,
                ImageUrl = "img/pizzas/bacon.jpg",
            },
            new()
            {
                Id = 3,
                Name = "Classic pepperoni",
                Description = "It's a classic for a reason",
                BasePrice = 10.50m,
                ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new()
            {
                Id = 4,
                Name = "Buffalo chicken",
                Description = "Chicken, hot sauce, and bleu cheese",
                BasePrice = 12.75m,
                ImageUrl = "img/pizzas/meaty.jpg",
            },
            new()
            {
                Id = 5,
                Name = "Mushroom Lovers",
                Description = "Shrooms on shrooms on shrooms",
                BasePrice = 11.00m,
                ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new()
            {
                Id = 7,
                Name = "Veggie Delight",
                Description = "The fittest pizza on the block",
                BasePrice = 11.50m,
                ImageUrl = "img/pizzas/salad.jpg",
            },
            new()
            {
                Id = 8,
                Name = "Margherita",
                Description = "Tomatoes, mozzarella, and basil bliss",
                BasePrice = 19.99m,
                ImageUrl = "img/pizzas/margherita.jpg",
                FixedSize = 24
            },
        ];
        db.Specials.AddRange(specials);
        return db.SaveChangesAsync();
    }
}