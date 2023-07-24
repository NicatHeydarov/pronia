using P330Pronia.Models;

namespace P330Pronia.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Slider> sliders { get; set; }
        public IEnumerable<Feature> features { get; set; }
    }
}
