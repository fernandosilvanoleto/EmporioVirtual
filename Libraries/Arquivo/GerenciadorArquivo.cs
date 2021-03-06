﻿using EmporioVirtual.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmporioVirtual.Libraries.Arquivo
{
    public class GerenciadorArquivo
    {
        public static string CadastrarImagemProduto(IFormFile file)
        {
            //Armazenar imagem em uma pasta
            var NomeArquivo = Path.GetFileName(file.FileName);

            var Caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/temp", NomeArquivo);

            using (var stream = new FileStream(Caminho, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return Path.Combine("/uploads/temp", NomeArquivo).Replace("\\", "/");

        }

        public static bool ExcluirImagemProduto(string caminho)
        {
            //Deletar imagem na pasta
            string Caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", caminho.TrimStart('/'));

            if (File.Exists(Caminho))
            {
                //DELETAR ARQUIVO
                File.Delete(Caminho);

                return true;
            }
            else
            {
                return false;
            }

        }

        public static List<Imagem> MoverImagensProduto(List<string> listacaminhotemp, int produto_id)
        {
            /*
             * Criar a pasta para cada produto
             */
            var CaminhoDefinitivoPastaProduto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", produto_id.ToString());

            if (!Directory.Exists(CaminhoDefinitivoPastaProduto))
            {
                Directory.CreateDirectory(CaminhoDefinitivoPastaProduto);
            }

            /*
             * Mover a Imagem da pasta temp para a Pasta definitiva
             */
            List<Imagem> ListaDeImagens = new List<Imagem>();
            foreach (var caminho_temp in listacaminhotemp)
            {
                if (!string.IsNullOrEmpty(caminho_temp))
                {
                    var NomeArquivo = Path.GetFileName(caminho_temp);

                    // isso para atualizar produto com imagem
                    var CaminhoDef = Path.Combine("/uploads", produto_id.ToString(), NomeArquivo).Replace("\\", "/");

                    if (CaminhoDef != caminho_temp)
                    {
                        var CaminhoAbsolutoTemp = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/temp", NomeArquivo);
                        var CaminhoAbsolutoDef = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", produto_id.ToString(), NomeArquivo);

                        if (File.Exists(CaminhoAbsolutoTemp))
                        {
                            //DELETE ARQUIVO NO CAMINHO DE DESTINO
                            if (File.Exists(CaminhoAbsolutoDef))
                            {
                                File.Delete(CaminhoAbsolutoDef);
                            }
                            //COPIA ARQUVO DE PASTA TEMPORÁRIA PARA DESTINO
                            File.Copy(CaminhoAbsolutoTemp, CaminhoAbsolutoDef);

                            // DELETA ARQUIVO DA PASTA TEMPORÁRIA
                            if (File.Exists(CaminhoAbsolutoDef))
                            {
                                File.Delete(CaminhoAbsolutoTemp);
                            }

                            ListaDeImagens.Add(new Imagem() { Caminho = Path.Combine("/uploads", produto_id.ToString(), NomeArquivo).Replace("\\", "/"), ProdutoId = produto_id });
                        
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        ListaDeImagens.Add(new Imagem() { Caminho = Path.Combine("/uploads", produto_id.ToString(), NomeArquivo).Replace("\\", "/"), ProdutoId = produto_id });
                    }
                }
            }

            return ListaDeImagens;
        }

        public static void ExcluirImagensDeProduto(List<Imagem> ListaImagens)
        {
            int ProdutoId = 0;
            foreach (var imagem in ListaImagens)
            {
                ProdutoId = imagem.ProdutoId;
                ExcluirImagemProduto(imagem.Caminho);
            }

            var PastaProduto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", ProdutoId.ToString());

            if (Directory.Exists(PastaProduto))
            {
                Directory.Delete(PastaProduto);
            }
        }
    }
}
