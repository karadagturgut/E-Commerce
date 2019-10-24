using CommerceApp.DataAccess.Concreate.EfCore;
using CommerceApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommerceApp.DataAccess.Concreate
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
           
        }

        private static Category[] Categories ={
            new Category() {CategoryName="Cep Telefonu"},
            new Category() {CategoryName="Elektonik"},
            new Category() {CategoryName="Bilgisayar"}
            };

        private static Product[] Products = {

            new Product(){ProductName="Samsung Galaxy A30", ImageURL="1.jpg", Price=1899},
            new Product(){ProductName="IPhone 8S", ImageURL="2.jpg", Price=6599},
            new Product(){ProductName="IPhone 7", ImageURL="3.jpg", Price=5799},
            new Product(){ProductName="Braun 7AX425B Ütü", ImageURL="4.jpg", Price=1259},
            new Product(){ProductName="LG L5-2", ImageURL="5.jpg", Price=359},
        };

    }
}
