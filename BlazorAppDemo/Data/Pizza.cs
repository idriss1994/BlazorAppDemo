namespace BlazorAppDemo.Data
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;

        public decimal Price { get; set; }

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }
    }
}
