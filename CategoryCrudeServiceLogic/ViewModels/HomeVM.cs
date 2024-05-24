﻿using CategoryCrudeServiceLogic.Models;

namespace CategoryCrudeServiceLogic.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public List<Category> Categories { get; set; }
        public List< Product>  Products{ get; set; }
        public List< Blog>  Blogs{ get; set; }
    }
}
