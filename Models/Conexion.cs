using Microsoft.EntityFrameworkCore;

namespace webApi.Models{
    class Conexion : DbContext{
        public Conexion(DbContextOptions<Conexion> options) :base (options){

        }
        public DbSet<Clientes> Clientes { get; set;}
    }

    class Conectar{
        private const string cadenaConexion = "server=localhost;database=db_empresa;userid=root;pwd=''";
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var cn = new Conexion(constructor.Options);
            return cn;
        }
    }
}