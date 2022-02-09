using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modelo;

namespace consola
{
    public class DBLibreriaBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, Memoria }
        static DBLibreria db;

        public static DBLibreria Crear()
        {
            string dbtipo = ConfigurationManager.AppSettings[DBTipo];
            string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;

            DbContextOptions<DBLibreria> contextOptions;

            switch (dbtipo)
            {
                case "SqlServer":
                    contextOptions = new DbContextOptionsBuilder<DBLibreria>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case "Postgres":
                    contextOptions = new DbContextOptionsBuilder<DBLibreria>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                case "Mysql":
                    contextOptions = new DbContextOptionsBuilder<DBLibreria>()
                        .UseMySQL(conn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<DBLibreria>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            db = new DBLibreria(contextOptions);

            return db;
        }
    }
}
