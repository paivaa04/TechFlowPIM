using System;
using System.Collections.Generic;
using System.Linq;
using Empresa.Models;

namespace Empresa.Db
{
    public class ChamadoDb
    {
        public void Create(Chamado chamado)
        {
            
            if (string.IsNullOrWhiteSpace(chamado.Assunto) || string.IsNullOrWhiteSpace(chamado.Descricao) || string.IsNullOrWhiteSpace(chamado.Setor))
            {
                throw new Exception("Backend rejeitou: Assunto, Setor e Descrição são obrigatórios para abrir um chamado.");
            }

            using (var ctx = new AppDbContext())
            {
                
                chamado.DataAbertura = DateTime.Now;
                chamado.Status = "Em Aberto";
                chamado.Prioridade = false; 

               
                chamado.IdUsuario = Sessao.UsuarioLogado.Id;


                ctx.Chamados.Add(chamado);
                ctx.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var ctx = new AppDbContext())
            {
                var chamado = ctx.Chamados.Find(id);
                if (chamado != null)
                {
                    ctx.Chamados.Remove(chamado);
                    ctx.SaveChanges();
                }
            }
        }

        public void Alterar(Chamado chamadoAtualizado)
        {
            using (var ctx = new AppDbContext())
            {
                var chamado = ctx.Chamados.Find(chamadoAtualizado.Id);
                if (chamado != null)
                {
                    
                    chamado.Status = chamadoAtualizado.Status;
                    chamado.Descricao = chamadoAtualizado.Descricao;



                    ctx.SaveChanges();
                }
            }
        }

        public List<Chamado> Listar()
        {
            int tipoUsuario = Sessao.UsuarioLogado.TipoUsuario;
            int usuarioId = Sessao.UsuarioLogado.Id;

            using (var ctx = new AppDbContext())
            {
                if (tipoUsuario == LoginDb.TipoUsuario.Tecnico)
                {
                   
                    return ctx.Chamados.ToList();
                }
                else
                {
                    
                    return ctx.Chamados.Where(c => c.IdUsuario == usuarioId).ToList();
                }
            }
        }
    }
}