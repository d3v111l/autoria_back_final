namespace autoria_back.Models
{
    public class GetAdvByIdModel
    {
        public string LocationCityName { get; set; }
        public decimal USD { get; set; }
        public AutoData autoData { get; set; }
        public string MarkName { get; set; }
        public int MarkId { get; set; }
        public string ModelName { get; set; }
        public int ModelId { get; set; }
        public PhotoData photoData { get; set; }
        public string LinkToView { get; set; }
        public string Title { get; set; }
        public StateData stateData { get; set; }
    }

    public class AutoData
    {
        public string Description { get; set; }
        public string Version { get; set; }
        public int Year { get; set; }
        public int AutoId { get; set; }
        public int StatusId { get; set; }
        public string Race { get; set; }
        public string FuelName { get; set; }
        public string GearboxName { get; set; }
        public bool IsSold { get; set; }
    }

    public class PhotoData
    {
        public int Count { get; set; }
        public string SeoLinkM { get; set; }
        public string SeoLinkSX { get; set; }
        public string SeoLinkB { get; set; }
        public string SeoLinkF { get; set; }
    }

    public class StateData
    {
        public string Name { get; set; }
        public string RegionName { get; set; }
        public string LinkToCatalog { get; set; }
        public string Title { get; set; }
        public int StateId { get; set; }
    }

}
