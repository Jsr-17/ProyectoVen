using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using ProyectoVentasElectronicas.Migrations;
using ProyectoVentasElectronicas.Models;
using System.CodeDom.Compiler;

namespace ProyectoVentasElectronicas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Supliers> Supliers { get; set; }
        public DbSet<Orders> Orders { get; set; }
         public DbSet<DetailsOrders> DetailsOrder { get; set; }


       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>().HasData(
                new Clients
                {
                    Client_id = 1,
                    Name = "Juan",
                    Surname = "Pérez",
                    Email = "juan.perez@example.com",
                    Telephone = "+5491145678901",
                    Direction = "Calle Falsa 123",
                    City = "Buenos Aires",
                    Country = "Argentina",
                    Username="test",
                    Password="1234"
                },
                new Clients
                {
                     Client_id=2,
                     Name="Maria",
                     Surname="Gonzalez",
                     Email="Juan.perez@example.com",
                     Telephone= "+5491145678901",
                     Direction= "Calle Falsa 123",
                     City= "Buenos Aires",
                     Country="Argentina",
                    Username = "test",
                    Password = "1234"
                },
                new Clients
                {
                    Client_id=3,
                    Name= "Pedro",
                    Surname= "Martínez",
                    Email= "pedro.martinez@example.com",
                    Telephone="+5491145678903",
                    Direction="Calle Larga 789",
                    City="Lima",
                    Country="Perú",
                    Username = "test",
                    Password = "1234"
                },
                new Clients
                {
                    Client_id = 4,
                    Name = "Minabo",
                    Surname = "Tieso",
                    Email = "Minabo.Tieso@example.com",
                    Telephone = "+YoLaConociEnunTaxi",
                    Direction = "Calle Tiesa 789",
                    City = "Alhendin",
                    Country = "El barrio no tan bajo",
                    Username = "test",
                    Password = "1234"

                },
                new Clients
                {
                    Client_id = 5,
                    Name = "Elver",
                    Surname = "Gacorta",
                    Email = "Elver_gaCorta_ElTerrorDeLasnennas@example.com",
                    Telephone = "QueBuenosEstanLoskebabsDeDurcal",
                    Direction = "Al Lao de un Parque",
                    City = "Durcal",
                    Country = "Japon",
                    Username = "test",
                    Password = "1234"
                }


                );
            modelBuilder.Entity<Supliers>().HasData(
                new Supliers
                {
                    Suplier_id = 1,
                    Name = "Dell Inc.",
                    Direction = "1 Dell Way, Round Rock",
                    Telephone = "+18005555555"
                },
                 new Supliers
                 {
                     Suplier_id = 2,
                     Name = "Apple Inc",
                     Direction = "1 Infinite Loop, Cupertino",
                     Telephone = "+18006565432"
                 },
                  new Supliers
                  {
                      Suplier_id = 3,
                      Name = "Logitech Inc.",
                      Direction = "7600 Gateway Blvd, Newark",
                      Telephone= "+18001234567"
                  }
                );
            modelBuilder.Entity<Categories>().HasData(
                new Categories { 
                    Category_id=1,
                    Name= "Computers"
                },
                new Categories
                 {
                     Category_id = 2,
                     Name = "Smartphones"
                },
                 new Categories
                  {
                      Category_id = 3,
                      Name = "Accesory"
                  }
                );
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    Product_id = 1,
                    Name = "Laptop Dell",
                    Description = "Laptop Dell  8GB RAM",
                    Price = 1200.00M,
                    Category_id = 1,  
                    Suplier_id = 1
                },
            new Products
            {
                Product_id = 2,
                Name = "iPhone 13",
                Description = "Smartphone Apple iPhone 13",
                Price = 1000.00M,
                Category_id = 2,  
                Suplier_id = 2    
            },
            new Products
            {
                Product_id = 3,
                Name = "Monitor Samsung",
                Description = "Monitor Samsung 27'' ",
                Price = 300.00M,
                Category_id = 1,  
                Suplier_id = 1    
            },
            new Products
            {
                Product_id = 4,
                Name = "Teclado Logitech",
                Description = "Keyboard mechanic Logitech",
                Price = 80.00M,
                Category_id = 3,  
                Suplier_id = 3    
            }
                );
        modelBuilder.Entity<DetailsOrders>().HasData(
                  new DetailsOrders
                  {
                      Detail_id = 1,
                      Order_id = 1,
                      Product_id = 1,
                      Quantity = 1,
                      Prize = 1200.00M
                  },
                new DetailsOrders
                {
                    Detail_id = 2,
                    Order_id = 2,
                    Product_id = 2,
                    Quantity = 1,
                    Prize = 1000.00M
                },
                new DetailsOrders
                {
                    Detail_id = 3,
                    Order_id = 3,
                    Product_id = 3,
                    Quantity = 1,
                    Prize = 300.00m
                },
                new DetailsOrders
                {
                    Detail_id = 4,
                    Order_id = 1,
                    Product_id = 4,
                    Quantity = 2,
                    Prize = 80.00m
                }
                );
            modelBuilder.Entity<Orders>().HasData(
                new Orders
                {
                    Order_id = 1,
                    Client_id = 1,
                    Order_date = new DateTime(2024, 5, 1),
                    State = "Processing"
                },
                new Orders
                {
                    Order_id = 2,
                    Client_id = 2,
                    Order_date = new DateTime(2024, 5, 2),
                    State = "Send"
                },
                new Orders
                {
                    Order_id = 3,
                    Client_id = 3,
                    Order_date = new DateTime(2024, 5, 3),
                    State = "Delivered"
                }
                );
           /* modelBuilder.Entity<DetailOrders>().HasData(
                new DetailOrders
                {
                    Detail_id = 1,
                    Order_id = 1,
                    Product_id = 1,
                    Quantity = 1,
                    Prize = 1200.00M
                }, new DetailOrders
                {
                    Detail_id = 2,
                    Order_id = 2,
                    Product_id = 2,
                    Quantity = 1,
                    Prize = 1000.00M
                }, new DetailOrders
                {
                    Detail_id = 3,
                    Order_id = 3,
                    Product_id = 3,
                    Quantity = 1,
                    Prize = 300.00M
                }, new DetailOrders
                {
                    Detail_id = 4,
                    Order_id = 1,
                    Product_id = 4,
                    Quantity = 2,
                    Prize = 80.00M
                });*/
          
        }
        public bool LoginInicio(string Username,string Pass)

        {
            try
            {
                var data = Clients.Any(u=>u.Username==Username && u.Password==Pass);
                
                return data;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            
        }
    }
}
