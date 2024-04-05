# Bank Template

Vi vill skapa en Razor Pages app med en Data Access Layer i ett bibliotek.
Denna Data Access Layer hanterar allt med databasen.

Vi vill också ha Identity funktionalitet som hanterar inloggningar.

Till slut skapar vi ett bibliotek som kan innehålla våra Services

Denna fil beskriver i detalj hur man skapar detta.

===============================================================================
===============================================================================

1a. Skapa en ny Razor App med Identity (Individual Accounts)
1b. Scaffolda samtliga Indentity sidor på en gång!
	Högerklicka projektet
	Add -> New Scaffolded Item
	Välj Identity -> Add
	Override all Files...
	Välj DbContexten som skapades av .net
	Add

===============================================================================
2. Skapa en klass library och döp den till "DataAccessLayer" 
	Efter den har skapats kan man radera "Class1.cs"
        VIKTIGT! Lägg en projekt reference från ditt projekt till din library!

===============================================================================
3. Se till att samtliga nuget paket är uppdaterade till den senaste versionen
	(både i ditt projekt och ditt bibliotek)
	Dessa paket finns att uppdatera
	a. Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter
	b. Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
	c. Microsoft.AspNetCore.Identity.EntityFrameworkCore
	d. Microsoft.AspNetCore.Identity.UI
	e. Microsoft.EntityFrameworkCore.Sqllite
	f. Microsoft.EntityFrameworkCore.SqlServer
	g. Microsoft.EntityFrameworkCore.Tools
	h. Microsoft.VisualStudio.Web.CodeGeneration.Design

===============================================================================
4. a. Öppna en Package Manager Console - 
   b. Se till att välja ditt bibliotek i dropdown
   c. Kör denna syntax i konsolen
   (Denna syntax skapar alla data models och en dbcontext till Bank databasen i din library!)

   OBS - VIKTIGT: Se till att din Bank databas är default och INTE inkluderar några aspnet Identity tabeller!

Scaffold-DbContext "Server=localhost;Database=BankAppData;Trusted_Connection=True;TrustServerCertificate=true;” Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

===============================================================================
5. I BankAppDataContext.cs filen ska vi göra ett par ändringar...
   a. Se till att klassen ärver från basklassen "IdentityDbContext"
	public partial class BankAppDataContext : IdentityDbContext
	{
		....
	}
   b. Kommentera bort DbSet Users...
      Vi behöver inte den eftersom vi ska använda ,net Identity Users istället
	//public virtual DbSet<User> Users { get; set; }

   c. Lägg till denna kod som nedan - base.OnModelCreating(modelBuilder);

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		...
	}
   d. INFO - Låt musen vilar på "IdentityDbContext" och klicka på F12 för att komma till definitionen
      Scrolla längre ner....
      Här ser man alla Identity tabeller definierade... dessa kommer att skapas i din databas
      Här hålls infon om dina users som vi kommer att skapa i DataInitializer senare

===============================================================================
6. Uppdatera appsettings.json i projektet som nedan
	{
	  "ConnectionStrings": {
	    "DefaultConnection": "Server=localhost;Database=BankAppData;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true"

	  },
	  "Logging": {
	    "LogLevel": {
	      "Default": "Information",
	      "Microsoft.AspNetCore": "Warning"
	    }
	  },
	  "AllowedHosts": "*"
	}

===============================================================================
7. Uppdatera Program.cs i din app för att inkludera <IdentityRole> och din nya DbContext (BankAppDataContext)....

	 // Add services to the container.
	 var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
	 builder.Services.AddDbContext<BankAppDataContext>(options =>
	     options.UseSqlServer(connectionString));
	 builder.Services.AddDatabaseDeveloperPageExceptionFilter();

	 builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
	     .AddRoles<IdentityRole>()
	     .AddEntityFrameworkStores<BankAppDataContext>();
	 builder.Services.AddRazorPages();

	 var app = builder.Build();

===============================================================================
8. I Models mappen i din library ska man skapa en ny klass osm heter "DataInitializer.cs"
   Kopiera in denna kod...

    public class DataInitializer
    {
        private readonly BankAppDataContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public DataInitializer(BankAppDataContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }
        public void SeedData()
        {
            _dbContext.Database.Migrate();
            SeedRoles();
            SeedUsers();
        }

        // Här finns möjlighet att uppdatera dina användares loginuppgifter
        private void SeedUsers()
        {
            AddUserIfNotExists("richard.chalk@systementor.se", "Hejsan123#", new string[] { "Admin" });
            AddUserIfNotExists("richard.chalk@customer.systementor.se", "Hejsan123#", new string[] { "Cashier" });
        }

        // Här finns möjlighet att uppdatera dina användares roller
        private void SeedRoles()
        {
            AddRoleIfNotExisting("Admin");
            AddRoleIfNotExisting("Cashier");
        }

        private void AddRoleIfNotExisting(string roleName)
        {
            var role = _dbContext.Roles.FirstOrDefault(r => r.Name == roleName);
            if (role == null)
            {
                _dbContext.Roles.Add(new IdentityRole { Name = roleName, NormalizedName = roleName });
                _dbContext.SaveChanges();
            }
        }

        private void AddUserIfNotExists(string userName, string password, string[] roles)
        {
            if (_userManager.FindByEmailAsync(userName).Result != null) return;

            var user = new IdentityUser
            {
                UserName = userName,
                Email = userName,
                EmailConfirmed = true
            };
            _userManager.CreateAsync(user, password).Wait();
            _userManager.AddToRolesAsync(user, roles).Wait();
        }
    }

===============================================================================
9a. Radera mappen som heter "Data" från ditt projekt.
    Denna mapp innehåller Migrations och den gamla dbContext som skapades av .net
    Vi behöver inget i denna mapp! RADERA!

9b. Gör en Build på ditt projekt!
    Förmodligen kommer du att få ett par errors. 
    Om du får några errors pga att din app inte längre hitta data mappen som vi raderade nyss...
    Ta bort alla instanser av denna

	@using Bank.Data
===============================================================================
10. Nu har vi raderat vår initial migration i steg 9....
   Så vi måste köra en ny initial migration från vårt bibliotek...

   a. Öppna en Package Manager Console och kör denna kod 
   b. VIKTIGT - välj "DataAccessLibrary" i dropdown

	add-migration "Initial Migration"

===============================================================================
11a. I Migrations mappen (som skapas av koden i steg 9b.) får vi en ny fil som heter xxxxxxxxxxx_Initial Migration.cs

Rensa (radera eller kommentera) all kod i Up() metoden (kommentera bort eller radera) som INTE har med Identity att göra!
EXPERIMNET!: Låt Countries koden i Up() ligger kvar först...
             Detta för att visa felmeddelandet till eleverna.
             Sedan kommentera man bort den för att kunna komma vidare.
	Låt 
	Radera:
	Accounts
	Countries
	Customers
	Frequencies
	Genders
	User
	Loans
	PermenentOrder
	Transactions
	Dispositions
	Cards

===============================================================================
11b. I Mjigrations mappen får vi en ny fil som heter xxxxxxxxxxx_Initial Migration.cs

Rensa (radera eller kommentera) all kod i Down() metoden (kommentera bort eller radera) som INTE har med Identity att göra!
	Radera:
	Accounts
	Countries
	Customers
	Frequencies
	Genders
	User
	Loans
	PermenentOrder
	Transactions
	Dispositions
	Cards

===============================================================================
12. I Program.cs i din app uppdatera som nedan...

	builder.Services.AddTransient<DataInitializer>();
	var app = builder.Build();

	using (var scope = app.Services.CreateScope())
	{
	    scope.ServiceProvider.GetService<DataInitializer>().SeedData();
	}

===============================================================================
13. Nu kan vi skapa en ny library som hanterar våra Services!
    a. Kalla den för "Services"
    b. Lägg en project reference från din app till din nya library!


===============================================================================
SUCCESS!
