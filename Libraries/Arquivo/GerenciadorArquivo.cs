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
            } else
            {
                return false;
            }

        }

        public static List<string> MoverImagensProduto(List<string> listacaminhotemp, string produto_id)
        {
            /*
             * Criar a pasta para cada produto
             */
            var CaminhoDefinitivoPastaProduto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", produto_id);

            if (!Directory.Exists(CaminhoDefinitivoPastaProduto))
            {
                Directory.CreateDirectory(CaminhoDefinitivoPastaProduto);
            }

            /*
             * Mover a Imagem da pasta temp para a Pasta definitiva
             */
            List<string> ListaCaminhoDef = new List<string>();
            foreach (var caminho_temp in listacaminhotemp)
            {
                if (string.IsNullOrEmpty(caminho_temp))
                {
                    var NomeArquivo = Path.GetFileName(caminho_temp);
                    var CaminhoAbsolutoTemp = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", caminho_temp);
                    var CaminhoAbsolutoDef = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", produto_id, NomeArquivo);

                    if (File.Exists(CaminhoAbsolutoTemp))
                    {
                        //MOVER
                        File.Copy(CaminhoAbsolutoTemp, CaminhoAbsolutoDef);
                        if (File.Exists(CaminhoAbsolutoDef))
                        {
                            File.Delete(CaminhoAbsolutoTemp);
                        }
                        ListaCaminhoDef.Add(Path.Combine("/uploads", produto_id, NomeArquivo).Replace("\\", "/"));
                    }
                    else
                    {
                        return null;
                    }
                }                
            }

            return ListaCaminhoDef;
        }
    }
}
