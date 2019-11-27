﻿using GestaodeFrota.Data;
using GestaodeFrota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestaodeFrota.Services
{
    public class MotoristaService
    {
        private readonly ApplicationDbContext _context;


        public MotoristaService(ApplicationDbContext context)
        {
            _context = context;
        }
        //Retornando o uma lista de motorista do banco de dados disponiveis
        public List<Motorista> FindAll()
        {
            return _context.Motorista.Where(model => model.Disponivel == true).ToList();
        }

        //Inserindo Um Motorista no banco de dados
        public void Insert(Motorista obj)
        {
            _context.Add(obj);        
            _context.SaveChanges();
        }

    }
}