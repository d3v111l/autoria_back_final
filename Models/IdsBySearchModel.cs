namespace autoria_back.Models
{
    public class Result
    {
        public Search_result search_Result { get; set; }
        public Search_Result_Common search_result_common = new Search_Result_Common();
    }

    public class Search_result
    {
        public List<string> Ids { get; set; }
        public int Count { get; set; }
        public int LastId { get; set; }
    }
    public class Search_Result_Common
    {
        public int Count { get; set; }
        public int Last_Id { get; set; }
        public List<Data> data { get; set; }
        public string Active_Marka { get; set; }
        public string Active_Model { get; set; }
        public string Active_State{ get; set; }
        public string Active_City { get; set; }
        public string Revies { get; set; }
        public bool isCommonSearch { get; set; }


    }

    public class Data
    {
        public string Id { get; set; }
        public string Type { get; set; }
    }
    public class Additional
    {
        public List <string> User_Auto_Positions { get; set; }  //= new List<string>();
        public Search_Params search_Params = new Search_Params();
    }
    public class Search_Params
    {
        public All all = new All();
        public Cleaned cleaned = new Cleaned();
        public string Query_String { get; set; }
    }
    public class All
    {
        public int Category_Id { get; set; }
        public int SearchType { get; set; }
        public string Target { get; set; }
        public string Event { get; set; }
        public int Lang_Id { get; set; }
        public int Page { get; set; }
        public int Limit_Page { get; set; }
        public int Countpage { get; set; }
        public int Last_Id { get; set; }
        public int SaledParam { get; set; }
        public List<string> Marka_Id { get; set; }
        public List<string> Model_Id { get; set; }
        public List<string> Mm_Marka_Filtr { get; set; }
        public List<string> Mm_Model_Filtr { get; set; }
        public bool UseOrigAutoTable { get; set; }
        public bool WithoutStatus { get; set; }
        public bool With_Photo { get; set; }
        public bool With_Video { get; set; }
        public int Under_Credit { get; set; }
        public int Confiscated_Car { get; set; }
        public List<string> Exchange_Filter { get; set; }
        public bool Old_Only { get; set; }
        public List<string> Auto_Options { get; set; }
        public List<string> User_Id { get; set; }
        public int Person_Id { get; set; }
        public bool With_Discount { get; set; }
        public int Auto_Id_str { get; set; }
        public int Black_User_Id { get; set; }
        public int OrderBy { get; set; }
        public bool IsOnline { get; set; }
        public bool WithoutCache { get; set; }
        public bool WithLastId { get; set; }
        public int Top { get; set; }
        public int Currency { get; set; }
        public int CurrencyId { get; set; }
        public List<object> CurrenciesArr { get; set; }
        public int PowerName { get; set; }
        public int PowerFrom { get; set; }
        public int PowerTo { get; set; }
        public List<object> HideBlackList { get; set; }
        public int Custom { get; set; }
        public bool Abroad { get; set; }
        public int Damage { get; set; }
        public int StarAuto { get; set; }
        public int PriceOt { get; set; }
        public int PriceDo { get; set; }
        public List<object> SYers { get; set; }
        public List<object> PoYers { get; set; }
        public int Year { get; set; }
        public int AutoIdsSearchPosition { get; set; }
        public int PrintQs { get; set; }
        public int IsHot { get; set; }
        public int DeletedAutoSearch { get; set; }
        public int CanBeChecked { get; set; }
        public List<object> ExcludeMM { get; set; }
        public List<object> GenerationId { get; set; }
        public List<object> ModificationId { get; set; }

    }
    public class Cleaned
    {
        public int CategoryId { get; set; }
        public int SearchType { get; set; }
        public string Target { get; set; }
        public string Event { get; set; }
        public int LangId { get; set; }
        public int CountPage { get; set; }
        public List<object> MarkaId { get; set; }
        public List<object> ModelId { get; set; }
        public List<object> MmMarkaFiltr { get; set; }
        public List<object> MmModelFiltr { get; set; }
        public List<object> ExchangeFilter { get; set; }
        public List<object> AutoOptions { get; set; }
        public List<object> UserId { get; set; }
        public int Currency { get; set; }
        public List<object> CurrenciesArr { get; set; }
        public List<object> HideBlackList { get; set; }
        public List<object> SYers { get; set; }
        public List<object> PoYers { get; set; }
        public List<object> ExcludeMM { get; set; }
        public List<object> GenerationId { get; set; }
        public List<object> ModificationId { get; set; }
    }
}


// исправить модель под то что ДЕЙСТВИТЕЛЬНО возвращает запрос