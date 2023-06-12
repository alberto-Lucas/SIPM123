using LoginSqLite.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSqLite.Services
{
    public class UsuarioService : IDataStore<Usuario>
    {
        private DatabaseService databaseService;
        private SQLiteAsyncConnection conexao;

        public UsuarioService()
        {
            databaseService = new DatabaseService();
            conexao = databaseService.GetConnection();

            //Mapear classe para criacao da tabela
            conexao.CreateTableAsync<Usuario>().Wait();
        }

        public async Task<bool> AddAsync(Usuario value)
        {
            await conexao.InsertAsync(value);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Usuario value)
        {
            await conexao.UpdateAsync(value);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(Usuario value)
        {
            await conexao.DeleteAsync(value);
            return await Task.FromResult(true);
        }

        public async Task<List<Usuario>> GetAllAsync()
        {
            return await
                conexao.Table<Usuario>().
                OrderByDescending(x => x.Nome).
                ToListAsync();
        }

        public async Task<Usuario> GetByIdAsync(int value)
        {
            return await conexao.FindAsync<Usuario>(value);
        }

        public async Task<Usuario> GetLoginAsync(string value)
        {
            return await conexao.Table<Usuario>().
                FirstOrDefaultAsync(x => x.Email == value);
        }

    }
}
