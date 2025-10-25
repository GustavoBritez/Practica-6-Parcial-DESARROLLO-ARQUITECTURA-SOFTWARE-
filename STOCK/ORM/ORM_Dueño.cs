using BE;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace ORM
{
    public class ORM_Dueño
    {
        private Access acceso = new Access();
        
        // Para manejar los dueños en memoria y comprarar cambios antes de enviarlos a la base de datos
        private List<DueñoBE> listaDueños = new List<DueñoBE>();

        /// Generamos un constructor para inicializar la lista de dueños dentro de una BLL y utilizar los metodos de ORM
        public ORM_Dueño()
        {
            listaDueños = Obtener_Dueños_ORM();
        }

        /// Devuelve la lista de dueños en memoria y la usamos para cargar la grilla
        public List<DueñoBE> Cargar_Dueños_Grilla()
        {
            return Obtener_Dueños_ORM();
        }

        // / Devuelve la lista de dueños en memoria y la usamos para cargar la grilla
        public List<DueñoBE> Obtener_Dueños_ORM()
        {
            List<DueñoBE> listaDueños_1 = new List<DueñoBE>();
            DataTable dt = new DataTable();

            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ACCION", "OBTENER")
            };

            dt = acceso.Leer("SP_DUEÑO_CRUD",sp);

            foreach( DataRow dr in dt.Rows)
            {                 
                DueñoBE mapeoDueño = new DueñoBE( Convert.ToInt32 ( dr["Id_Dueño"] ) , dr["Nombre"].ToString() , dr["Telefono"].ToString() , dr["Mail"].ToString() );
                listaDueños_1.Add( mapeoDueño );
            }

            return listaDueños_1;
        } 
        
        ///  ABM
        public void Alta_Dueño(DueñoBE duenio)
        {
            try
            {

                if (this.listaDueños.Count == 0)
                { 
                    duenio.Id_Admin = 1;

                    SqlParameter[] sp = new SqlParameter[]
                    {
                                new SqlParameter("@ACCION", "AGREGAR"),
                                new SqlParameter ("@ID_DUEÑO", SqlDbType.Int ) { Value = duenio.Id_Admin },
                                new SqlParameter ("@NOMBRE", SqlDbType.VarChar ) { Value = duenio.Nombre },
                                new SqlParameter ("@TELEFONO", SqlDbType.VarChar ) { Value = duenio.Telefono },
                                new SqlParameter ("@MAIL", SqlDbType.VarChar ){ Value = duenio.Mail }
                    };
                    acceso.Escribir("SP_DUEÑO_CRUD", sp);
                }
                else
                {
                    var id = this.listaDueños.Max(d => d.Id_Admin + 1);
                    duenio.Id_Admin = id;

                    SqlParameter[] sp = new SqlParameter[]
                    {
                                new SqlParameter("@ACCION", "AGREGAR"),
                                new SqlParameter ("@ID_DUEÑO", SqlDbType.Int ) { Value = duenio.Id_Admin },
                                new SqlParameter ("@NOMBRE", SqlDbType.VarChar ) { Value = duenio.Nombre },
                                new SqlParameter ("@TELEFONO", SqlDbType.VarChar ) { Value = duenio.Telefono },
                                new SqlParameter ("@MAIL", SqlDbType.VarChar ){ Value = duenio.Mail }
                    };
                    acceso.Escribir("SP_DUEÑO_CRUD", sp);
                }
            }
            catch(Exception ex )
            {
                throw new Exception( ex.ToString() );   
            }
            finally
            {
  
                this.listaDueños = Obtener_Dueños_ORM();
            }
        }

        public void Modificar_Dueño(DueñoBE duenio )
        {

            try
            {
                DueñoBE duenio_sinmodificar = this.listaDueños.FirstOrDefault(d => d.Id_Admin == duenio.Id_Admin);

                duenio_sinmodificar.Nombre = duenio.Nombre;
                duenio_sinmodificar.Telefono = duenio.Telefono;
                duenio_sinmodificar.Mail = duenio.Mail;

                SqlParameter[] sp = new SqlParameter[]
                {
                new SqlParameter("@ACCION", "MODIFICAR"),
                new SqlParameter ("@ID_DUEÑO", SqlDbType.Int ) { Value = duenio_sinmodificar.Id_Admin },
                new SqlParameter ("@NOMBRE", SqlDbType.VarChar ) { Value = duenio_sinmodificar.Nombre },
                new SqlParameter ("@TELEFONO", SqlDbType.VarChar ) { Value = duenio_sinmodificar.Telefono },
                new SqlParameter ("@MAIL", SqlDbType.VarChar ){ Value = duenio_sinmodificar.Mail }
                };
                acceso.Escribir("SP_DUEÑO_CRUD", sp);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                this.listaDueños = Obtener_Dueños_ORM();
            }
        }

        public void Bajar_dueño( int id_dueño )
        {
            try
            {
                SqlParameter[] sp = new SqlParameter[]
{
                new SqlParameter("@ACCION", "ELIMINAR"),
                new SqlParameter ("@ID_DUEÑO", SqlDbType.Int ) { Value = id_dueño }
};
                acceso.Escribir("SP_DUEÑO_CRUD", sp);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                this.listaDueños = Obtener_Dueños_ORM();
            }
        }   
    }       
}

