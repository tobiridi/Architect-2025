namespace ExoMVC.Models.ViewModels
{
    public class PropertyViewModel
    {
        public int ID { get; set; }
        public string Picture { get; set; }
        public string PropertyType { get; set; }
        public decimal Prix { get; set; }
        public string Adresse { get; set; }
        public int NbChambres { get; set; }
        public int NbSalleDeBain { get; set; }
        public double Surface { get; set; }
        public int Etage { get; set; }
        public int NbParking { get; set; }
        public string Description { get; set; }

        public PropertyViewModel(int iD, string picture, string propertyType, decimal prix, string adresse,
            int nbChambres, int nbSalleDeBain, double surface, int etage, int nbParking,
            string description)
        {
            ID = iD;
            Picture = picture;
            PropertyType = propertyType;
            Prix = prix;
            Adresse = adresse;
            NbChambres = nbChambres;
            NbSalleDeBain = nbSalleDeBain;
            Surface = surface;
            Etage = etage;
            NbParking = nbParking;
            Description = description;
        }

        public static List<PropertyViewModel> FakeProperties()
        {
            List<PropertyViewModel> list = new List<PropertyViewModel>()
            {
                new PropertyViewModel(1, "property-01.jpg", "Luxury Villa", 2264000M, "18 New Street Miami, OR 97219", 8, 8, 545, 3, 6, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
                new PropertyViewModel(2, "property-02.jpg", "Luxury Villa", 1180000M, "54 Mid Street Florida, OR 27001", 6, 5, 450, 3, 8, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
                new PropertyViewModel(3, "property-03.jpg", "Luxury Villa", 1460000M, "26 Old Street Miami, OR 38540", 5, 4, 225, 3, 10, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
                new PropertyViewModel(4, "property-04.jpg", "Apartment", 584500M, "12 New Street Miami, OR 12650", 4, 3, 125, 25, 2, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
                new PropertyViewModel(5, "property-05.jpg", "Penthouse", 925600M, "34 Beach Street Miami, OR 42680", 4, 4, 180, 38, 2, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
                new PropertyViewModel(6, "property-06.jpg", "Modern Condo", 450000M, "22 New Street Portland, OR 16540", 3, 2, 165, 26, 3, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
                new PropertyViewModel(7, "property-03.jpg", "Luxury Villa", 980000M, "14 Mid Street Miami, OR 36450", 8, 8, 550, 3, 12, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
                new PropertyViewModel(8, "property-02.jpg", "Luxury Villa", 1520000M, "26 Old Street Miami, OR 12870", 12, 15, 380, 3, 14, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
                new PropertyViewModel(9, "property-01.jpg", "Luxury Villa", 3145000M, "34 New Street Miami, OR 24650", 10, 12, 860, 3, 10, "When you look for free CSS templates, you can simply type TemplateMo in any search engine website. In addition, you can type TemplateMo Digital Marketing, TemplateMo Corporate Layouts, etc. Master cleanse +1 intelligentsia swag post-ironic, slow-carb chambray knausgaard PBR&B DSA poutine neutra cardigan hoodie pop-up"),
            };
            return list;
        }
    }
}
