﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestaodeFrota.Models
{
    public class Oficina
    {
        public int Id { get; set; }
        [Display(Name = "Nome da Oficina")]
        public string NomeOficina { get; set; }
        [Display(Name = "Endereço da Oicina  ")]
        public string Endereco { get; set; }


        public ICollection<Manutencao> Manutencao { get; set; } = new List<Manutencao>();

        public Oficina()
        {
        }

        public Oficina(int id, string nomeOficina, string endereco)
        {
            this.Id = id;
            this.NomeOficina = nomeOficina;
            this.Endereco = endereco;
        }

        public void AddManutencao(Manutencao mt)
        {
            Manutencao.Add(mt);
        }

        public void RemoveManutencao(Manutencao mt)
        {
            Manutencao.Remove(mt);
        }


    }
}