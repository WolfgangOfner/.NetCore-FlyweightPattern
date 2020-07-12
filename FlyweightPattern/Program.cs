namespace FlyweightPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mealFactory = new MealFactory();
            mealFactory.PrintMeals();

            var mediumBurgerMeal = mealFactory.GetMeal("Burger Meal");
            mediumBurgerMeal.Serve("medium");
            var mediumPizzaMeal = mealFactory.GetMeal("Pizza Meal");
            mediumPizzaMeal.Serve("medium");

            var largeBurgerMeal = mealFactory.GetMeal("Burger Meal");
            largeBurgerMeal.Serve("large");
            var largePizzaMeal = mealFactory.GetMeal("Pizza Meal");
            largePizzaMeal.Serve("large");

            mealFactory.PrintMeals();
        }
    }
}