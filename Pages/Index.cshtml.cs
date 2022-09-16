using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public class Client
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public DateTime LastOrder { get; set; }

            public Client(string name, double balance, string city, string country, DateTime lastOrder)
            {
                Name = name;
                Balance = balance;
                City = city;
                Country = country;
                LastOrder = lastOrder;
            }
        }
        public Client[] Clients = new Client[]
        {
        new Client("Maria Anders",130.00,"Berlin", "Germany", DateTime.Now),
        new Client("Ana Trujillo",230,"Mxico D.F.", "Mexico", DateTime.Now),
        new Client("Antonio Moreno",-3500,"Mxico D.F.", "Mexico", DateTime.Now),
        new Client("Thomas Hardy",55,"London", "UK", DateTime.Now),
        new Client("Christina Berglund",132.86,"Lule", "Sweden", DateTime.Now),
        new Client("Hanna Moos",85,"Mannheim", "Germany", DateTime.Now),
        new Client("Frdrique Citeaux",35.424,"Strasbourg", "France", DateTime.Now),
        new Client("Martn Sommer",0,"Madrid", "Spain", DateTime.Now),
        new Client("Elizabeth Lincoln",-140,"Marseille", "France", DateTime.Now),
        new Client("Victoria Ashworth",200,"Tsawassen", "Canada", DateTime.Now),
        new Client("Patricio Simpson",59.55,"London", "UK", DateTime.Now),
        new Client("Francisco Chang",100,"Buenos Aires", "Argentina", DateTime.Now),
        new Client("Yang Wang",107.44,"Mxico D.F.", "Mexico", DateTime.Now),
        new Client("Pedro Afonso",-200,"Bern", "Switzerland", DateTime.Now),
        new Client("Elizabeth Brown",-390,"Sao Paulo", "Brazil", DateTime.Now),
        new Client("Sven Ottlieb",70,"Berlin", "Germany", DateTime.Now),
        new Client("Janine Labruneo",135.50,"Nantes", "France", DateTime.Now),
        new Client("Ann Devon",0,"London", "UK", DateTime.Now),
        new Client("Roland Mendel",50,"Graz", "Austria", DateTime.Now),
        new Client("Patrick Smith",30,"Liverpool", "UK", DateTime.Now),
        new Client("John Mayers",30,"Liverpool", "UK", DateTime.Now)
        };
    }
}