using Newtonsoft.Json;

namespace autoria_back.Models
{
    using System;
    using System.Collections.Generic;

    public class Root
    {
        public int Photo_id { get; set; }
        public int Auto_id { get; set; }
        public int Status { get; set; }
        public int Checked { get; set; }
        public int SortingIndex { get; set; }
        public DateTime Date_add { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<string> Formats { get; set; }
    }

    public class Photos
    {
        public Root Photo1 { get; set; }
        public Root Photo2 { get; set; }
        public Root Photo3 { get; set; }
        public Root Photo4 { get; set; }
        public Root Photo5 { get; set; }
        public Root Photo6 { get; set; }
        public Root Photo7 { get; set; }
        public Root Photo8 { get; set; }
    }

    public class PhotosData
    {
        public Photos Photos { get; set; }
    }

    public class PhotosModel
    {
        public int Status { get; set; }
        public PhotosData PhotosData { get; set; }
    }

}
