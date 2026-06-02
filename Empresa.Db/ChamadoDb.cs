using Empresa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
                
                var chamadoNoBanco = ctx.Chamados.FirstOrDefault(c => c.Id == chamadoAtualizado.Id);

                if (chamadoNoBanco != null)
                {
                    
                    chamadoNoBanco.Status = chamadoAtualizado.Status;
                    chamadoNoBanco.Descricao = chamadoAtualizado.Descricao;

                    int linhasAfetadas = ctx.SaveChanges();

                    if (linhasAfetadas == 0)
                    {
                        throw new Exception("O EF executou, mas nenhuma linha foi alterada no banco.");
                    }
                }
                else
                {
                    throw new Exception($"O chamado com ID {chamadoAtualizado.Id} não foi encontrado no banco.");
                }
            }
        }

        public void FinalizarChamado(int idChamado)
        {
            
            if (Sessao.UsuarioLogado.TipoUsuario != 1) 
            {
                throw new Exception("Acesso negado: Somente técnicos podem finalizar chamados.");
            }

            using (var ctx = new AppDbContext())
            {
                var chamado = ctx.Chamados.Find(idChamado);
                if (chamado != null)
                {
                    chamado.Status = "Finalizado";
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
                   
                    return ctx.Chamados.AsNoTracking().ToList();
                }
                else
                {
                    return ctx.Chamados.AsNoTracking().Where(c => c.IdUsuario == usuarioId).ToList();
                }
            }
        }
    }
}
