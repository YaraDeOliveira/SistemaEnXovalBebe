using Microsoft.EntityFrameworkCore;
using SistemaEnxoval.Context;
using SistemaEnxoval.Interfaces;
using SistemaEnxoval.Model;
using SistemaEnxoval.Repositories;

namespace SistemaEnxoval.Services
{
    public class SeedingService
    {
        private readonly DataContext _data;

        public SeedingService(DataContext data)
        {
            _data = data;
        }

        public void Seed()
        {
            if (_data.Items.Any())
            {
                return;
            }

            var list = new List<ItemRepository>()
            {
                new ItemRepository ("Body Manga Longa", 6, "RN"),
                new ItemRepository ("Body Manga Curta", 6, "RN"),
                new ItemRepository ("Calça", 8, "RN"),
                new ItemRepository ("Macacão com pé", 5, "RN"),
                new ItemRepository ("Meia", 5, "RN"),
                new ItemRepository ("Saída Maternidade", 1, "RN"),
                new ItemRepository ("Manta leve", 2, "RN"),
                new ItemRepository ("Macacão Soft", 5, "RN"),
                new ItemRepository ("Gorro", 2, "RN"),
                new ItemRepository ("Luva", 2, "RN"),
                new ItemRepository ("Sapato", 1, "RN"),


                new ItemRepository ("Body Manga Longa", 4, "3 meses"),
                new ItemRepository ("Body Manga Curta", 4, "3 meses"),
                new ItemRepository ("Calça", 4, "3 meses"),
                new ItemRepository ("Macacão com pé", 4, "3 meses"),
                new ItemRepository ("Meia", 4, "3 meses"),
                new ItemRepository ("Short / Saia", 1, "3 meses"),
                new ItemRepository ("Macacão Soft", 3, "3 meses"),
                new ItemRepository ("Macacão de Manga Curta", 3, "3 meses"),
                new ItemRepository ("Luva", 1, "3 meses"),
                new ItemRepository ("Sapato", 2, "3 meses"),

                new ItemRepository ("Body Manga Longa", 6, "6 meses"),
                new ItemRepository ("Body Manga Curta", 6, "6 meses"),
                new ItemRepository ("Calça", 2, "6 meses"),
                new ItemRepository ("Macacão com pé", 4, "6 meses"),
                new ItemRepository ("Meia", 4, "6 meses"),
                new ItemRepository ("Short / Saia", 4, "6 meses"),
                new ItemRepository ("Roupa de Passeio", 2, "6 meses"),
                new ItemRepository ("Macacão de Manga Curta", 3, "6 meses"),
                new ItemRepository ("Boné / Chapéu", 1, "6 meses"),
                new ItemRepository ("Sapato", 2, "6 meses"),


                new ItemRepository ("Body Manga Longa", 2, "9 meses"),
                new ItemRepository ("Body Manga Curta", 2, "9 meses"),
                new ItemRepository ("Calça", 4, "9 meses"),
                new ItemRepository ("Macacão Soft ou Plush", 4, "9 meses"),
                new ItemRepository ("Meia", 4, "9 meses"),
                new ItemRepository ("Short / Saia", 4, "9 meses"),
                new ItemRepository ("Roupa de Passeio", 2, "9 meses"),
                new ItemRepository ("Macacão de Manga Curta", 3, "9 meses"),
                new ItemRepository ("Boné / Chapéu", 1, "9 meses"),
                new ItemRepository ("Sapato", 2, "9 meses"),
                new ItemRepository ("Jaqueta", 2, "9 meses"),
                new ItemRepository ("Camiseta", 4, "9 meses"),
                new ItemRepository ("Camiseta Manga Longa", 4, "9 meses"),

                new ItemRepository ("Body Manga Longa", 1, "12 meses"),
                new ItemRepository ("Body Manga Curta", 1, "12 meses"),
                new ItemRepository ("Calça", 4, "12 meses"),
                new ItemRepository ("Macacão Soft ou Plush", 4, "12 meses"),
                new ItemRepository ("Macacão Pijama", 4, "12 meses"),
                new ItemRepository ("Meia", 6, "12 meses"),
                new ItemRepository ("Short / Saia", 4, "12 meses"),
                new ItemRepository ("Roupa de Passeio", 2, "12 meses"),
                new ItemRepository ("Blusa", 2, "12 meses"),
                new ItemRepository ("Boné / Chapéu", 1, "12 meses"),
                new ItemRepository ("Tênis", 2, "12 meses"),
                new ItemRepository ("Crocks ou Chinelo", 1, "12 meses"),
                new ItemRepository ("Jaqueta", 2, "12 meses"),
                new ItemRepository ("Camiseta", 4, "12 meses"),
                new ItemRepository ("Camiseta Manga Longa", 3, "12 meses"),

            };

            _data.Items.AddRange(list);
            _data.SaveChanges();

        }



    }
}
