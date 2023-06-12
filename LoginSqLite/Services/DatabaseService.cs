using PCLExt.FileStorage.Folders;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSqLite.Services
{
    public class DatabaseService
    {
        public SQLiteAsyncConnection connection;

        public SQLiteAsyncConnection GetConnection()
        {
            //localizar a pasta raiz do app
            var folder = new LocalRootFolder();

            //Definir o nome do banco de dados
            //Criamos o arquivo caso ele não exista
            var file = folder.CreateFile("oraculo",
                PCLExt.FileStorage.
                CreationCollisionOption.
                OpenIfExists);

            //Retornar conexão com o banco de dados
            return connection = new
                SQLiteAsyncConnection(file.Path);
        }
    }
}
