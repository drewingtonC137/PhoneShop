namespace PhoneShop.Models
{
    public class PhonesModel
    {
        public string ImageTitle { get; set; }
        public string PhoneName { get; set; }

        public float BasePrice { get; set; } = 700;
        public bool ProModel { get; set; }
        public bool MemoryUpgrade { get; set; }
        public bool BatteryUpgrade { get; set; }
        public bool HighRefresh { get; set; }
        public bool OledPanel { get; set; }

        public float FinalPrice { get; set; }

    }
}
