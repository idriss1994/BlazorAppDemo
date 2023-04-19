using BlazorAppDemo.Models.Topping;
using Microsoft.AspNetCore.Components;

namespace BlazorAppDemo.Components
{
    public partial class DisplayPizza
    {
        [Parameter]
        public string PizzaName { get; set; } = string.Empty;

        [Parameter]
        public string PizzaDescription { get; set; } = "The best pizza you've ever teested";

        [Parameter]
        public PizzaTopping Topping { get; set; }
    }
}
