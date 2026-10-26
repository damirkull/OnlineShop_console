using OnlineShop;

namespace WinFormOnlineShop_2026
{
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
        public FormCatalog()
        {
            InitializeComponent();
            catalog.Add(new Product("Вертолет", 100, "игрушка"));
            catalog.Add(new Product("Майка", 1005, "с принтом"));
            catalog.Add(new Product("Тапки", 250, "пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "в клетку"));
            ShowCatalog();
        }

        void ShowCatalog()
        {
            int i = 0;
            foreach (Product product in catalog.getAll())
                listBoxCatalog.Items.Add($"{++i} {product}");
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product choosenProduct = null;
            if (listBoxCatalog.SelectedItem != choosenProduct)
            {
                string text = listBoxCatalog.SelectedItem.ToString();
                int index = int.Parse(text.Split(' ')[0]);

                choosenProduct = catalog[index];
                labelProductName.Text = $"{choosenProduct.Name} - {choosenProduct.Price}";
                labelDescription.Text = choosenProduct.Description;
            }
        }
    }
}
