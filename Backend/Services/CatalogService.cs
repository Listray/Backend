﻿using Backend.Data;
using Backend.Models;
using Backend.Services.Interfaces;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly string _curentCatalog;
        private readonly ApplicationDbContext _context;

        public CatalogService(string curentCatalog, ApplicationDbContext context)
        {
            _context = context;
            _curentCatalog = curentCatalog;
        }

        public IdList GetCatalogs(string ownerId)
        {
            IdList result = new IdList();
            /*

            */
            return result;
        }

        public IdList GetMessages(string ownerId)
        {
            IdList result = new IdList();
            /*

            */
            return result;
        }

        public void DeleteCatalog(string id)
        {
            /*
             * рекурсивно удалять всех сынков и вложенные документы
             */
        }

        public void DeleteMessage(string id)
        {

        }

        public void CreateCatalog(string ownerId, string name)
        {

        }

        public void CreateMessage(string ownerId, string name, string text)
        {

        }
    }
}