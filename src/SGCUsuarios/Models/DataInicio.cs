using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SGC.Models
{
    public class DataInicio
    {
        /*public static void AgregarData(IApplicationBuilder ab)
        {
            AppDbContext context = ab.ApplicationServices.GetRequiredService<AppDbContext>();
            if (!context.ClasificacionDoc.Any())
            {
                context.ClasificacionDoc.AddRange(ClasificacionDocIniciales.Select(c => c.Value));
            }
            if (!context.Documentos.Any())
            {
                context.AddRange
                    (
                        new Documentos { Documento = "Manual de Organizacion", Prioridad = true, ClasificacionDoc = ClasificacionDocIniciales["Manual"] },
                        new Documentos { Documento = "Manual de Oficina", Prioridad = true, ClasificacionDoc = ClasificacionDocIniciales["Manual"] },
                        new Documentos { Documento = "Oferta de Empleo", Prioridad = true, ClasificacionDoc = ClasificacionDocIniciales["Formulario"] },
                        new Documentos { Documento = "Contrato de Servicio", Prioridad = true, ClasificacionDoc = ClasificacionDocIniciales["Formulario"] },
                        new Documentos { Documento = "Compra de Escritorios", Prioridad = false, ClasificacionDoc = ClasificacionDocIniciales["Factura"] },
                        new Documentos { Documento = "Aviso de Cambios", Prioridad = false, ClasificacionDoc = ClasificacionDocIniciales["Carta"] }
                    );
            }
            context.SaveChanges();
        }//fin AgregarData

        //referencia a la clase dominio ClasificacionDoc
        public static Dictionary<string, ClasificacionDoc> clasificaciondocinicioales;
        public static Dictionary<string, ClasificacionDoc> ClasificacionDocIniciales
        {
            get
            {
                if (clasificaciondocinicioales == null)
                {
                    var listadoClasificacion = new ClasificacionDoc[]
                    {
                        new ClasificacionDoc { Clasificacion ="Carta"},
                        new ClasificacionDoc { Clasificacion ="Formulario"},
                        new ClasificacionDoc { Clasificacion ="Presupuesto"},
                        new ClasificacionDoc { Clasificacion ="Factura"},
                        new ClasificacionDoc { Clasificacion ="Manual"},
                    };
                    clasificaciondocinicioales = new Dictionary<string, ClasificacionDoc>();

                    foreach (ClasificacionDoc clasdocini in listadoClasificacion)
                    {
                        clasificaciondocinicioales.Add(clasdocini.Clasificacion, clasdocini);
                    }//fin foreach
                }
                return clasificaciondocinicioales;
            }//fin get
        }//fin de diccionario de clasificacion de documentos


        /* public static void AgregarDataE(IApplicationBuilder ab)
         {
             AppDbContext context = ab.ApplicationServices.GetRequiredService<AppDbContext>();
             if (!context.Cargos.Any())
             {
                 context.Cargos.AddRange(CargosIniciales.Select(c => c.Value));
             }

             if (!context.Departamentos.Any())
             {
                 context.Departamentos.AddRange(DepartamentosIniciales.Select(c => c.Value));
             }

             if (!context.Empleado.Any())//err
             {
                 context.AddRange
                     (
                         new Empleado { Nombre = "Carlos", Apellido = "Solis", Genero = "Masculino", Domicilio = "Cojutepeque", Telefono = "2648-4514", CargosEmpleado = CargosIniciales["Desarrollador"], Departamentos = DepartamentosIniciales["Tecnologia"] },
                         new Empleado { Nombre = "Christopher", Apellido = "Olmedo", Genero = "Masculino", Domicilio = "Ilopango", Telefono = "2564-1564", CargosEmpleado = CargosIniciales["Programador"], Departamentos = DepartamentosIniciales["Tecnologia"] },
                         new Empleado { Nombre = "Franklin", Apellido = "Bermudez", Genero = "Masculino", Domicilio = "Apopa", Telefono = "2282-364", CargosEmpleado = CargosIniciales["DBA"], Departamentos = DepartamentosIniciales["Tecnologia"] },
                         new Empleado { Nombre = "Roberto", Apellido = "Chavez", Genero = "Masculino", Domicilio = "Soyapango", Telefono = "2364-0964", CargosEmpleado = CargosIniciales["DBA Junior"], Departamentos = DepartamentosIniciales["Tecnologia"] },
                         new Empleado { Nombre = "Javier", Apellido = "Oliva", Genero = "Masculino", Domicilio = "Ayutuxtepeque", Telefono = "2193-2736", CargosEmpleado = CargosIniciales["Gerente"], Departamentos = DepartamentosIniciales["Administracion"] },
                         new Empleado { Nombre = "Sonia", Apellido = "Pineda", Genero = "Femenino", Domicilio = "San Salvador", Telefono = "2564-1564", CargosEmpleado = CargosIniciales["Secretaria"], Departamentos = DepartamentosIniciales["Administracion"] }
                     );
             }
             context.SaveChanges();
         }//fin AgregarDataE

         //referencia a la clase dominio Cargos
         public static Dictionary<string, Cargos> cargosinicioales;
         public static Dictionary<string, Cargos> CargosIniciales
         {
             get
             {
                 if (cargosinicioales == null)
                 {
                     var listadoCargos = new Cargos[]
                     {
                         new Cargos { Cargo ="Desarrollador"},
                         new Cargos { Cargo ="Programador"},
                         new Cargos { Cargo ="DBA"},
                         new Cargos { Cargo ="DBA Junior"},
                         new Cargos { Cargo ="Secretaria"},
                         new Cargos { Cargo ="Gerente"},
                     };
                     cargosinicioales = new Dictionary<string, Cargos>();

                     foreach (Cargos cargoemp in listadoCargos)
                     {
                         cargosinicioales.Add(cargoemp.Cargo, cargoemp);//err
                     }//fin foreach
                 }
                 return cargosinicioales;
             }//fin get
         }//fin de diccionario de clasificacion de cargos


         //referencia a la clase dominio Departamentos
         public static Dictionary<string, Departamentos> departamentosiniciales;
         public static Dictionary<string, Departamentos> DepartamentosIniciales
         {
             get
             {
                 if (departamentosiniciales == null)
                 {
                     var listadoDepartamentos = new Departamentos[]
                     {
                         new Departamentos { Departamento ="Tecnologia"},
                         new Departamentos { Departamento ="Administracion"},
                         new Departamentos { Departamento ="Mercadotecnia"},
                         new Departamentos { Departamento ="Contabilidad"}
                     };
                     departamentosiniciales = new Dictionary<string, Departamentos>();

                     foreach (Departamentos departamentoemp in listadoDepartamentos)
                     {
                         departamentosiniciales.Add(departamentoemp.Departamento, departamentoemp);//err
                     }//fin foreach
                 }
                 return departamentosiniciales;
             }//fin get
         }//fin de diccionario de clasificacion de departamentos*/


        public static void AgregarDataU(IApplicationBuilder ab)
        {
            AppDbContext context = ab.ApplicationServices.GetRequiredService<AppDbContext>();
            if (!context.Niveles.Any())
            {
                context.Niveles.AddRange(NivelesIniciales.Select(c => c.Value));
            }

            /* if (!context.Empleado.Any())
             {
                 context.Empleado.Any(Empleado.Select(c => c.Value));
             }*/

            if (!context.Usuarios.Any())
            {
                context.AddRange
                    (
                        new Usuarios { NombreUsuario = "Carlos", ApellidosUsuario = "Solis", CuentaUsuario = "adminsgc", ClaveUsuario = "123admin", EstadoUsuario = true, NivelUsuario = NivelesIniciales["Administrador"] },
                        new Usuarios { NombreUsuario = "Franklin", ApellidosUsuario = "Bermudez", CuentaUsuario = "dbasgc", ClaveUsuario = "123dba", EstadoUsuario = true, NivelUsuario = NivelesIniciales["Administrador"] },
                        new Usuarios { NombreUsuario = "Christopher", ApellidosUsuario = "Olmedo", CuentaUsuario = "progsgc", ClaveUsuario = "123prog", EstadoUsuario = true, NivelUsuario = NivelesIniciales["Usuario"] },
                        new Usuarios { NombreUsuario = "Roberto", ApellidosUsuario = "Chavez", CuentaUsuario = "dbajrsgc", ClaveUsuario = "123dbajr", EstadoUsuario = true, NivelUsuario = NivelesIniciales["Usuario"] },
                        new Usuarios { NombreUsuario = "Javier", ApellidosUsuario = "Oliva", CuentaUsuario = "ggsgc", ClaveUsuario = "123ggsgc", EstadoUsuario = true, NivelUsuario = NivelesIniciales["Administrador"] },
                        new Usuarios { NombreUsuario = "Sonia", ApellidosUsuario = "Pineda", CuentaUsuario = "secrsgc", ClaveUsuario = "123secr", EstadoUsuario = true, NivelUsuario = NivelesIniciales["Usuario"] }
                        );
            }
            context.SaveChanges();
        }//fin AgregarDataU

        //referencia a la clase dominio Niveles
        public static Dictionary<string, Niveles> nivelesiniciales;
        public static Dictionary<string, Niveles> NivelesIniciales
        {
            get
            {
                if (nivelesiniciales == null)
                {
                    var listadoNiveles = new Niveles[]
                    {
                        new Niveles { Nivel ="Administrador"},
                        new Niveles { Nivel ="Usuario"}
                    };
                    nivelesiniciales = new Dictionary<string, Niveles>();

                    foreach (Niveles nivelusu in listadoNiveles)//err
                    {
                        nivelesiniciales.Add(nivelusu.Nivel, nivelusu);//err
                    }//fin foreach
                }
                return nivelesiniciales;
            }//fin get
        }//fin de diccionario de clasificacion de niveles


    }
}

