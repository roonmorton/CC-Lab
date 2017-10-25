using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class Paciente : DB
    {
        public void GrabarModificar(
            string idPaciente,
            string nombres,
            string apellidos,
            string fechaNacimiento,
            string telefono,
            string direccion
            )
        {
            try
            {
                ejecutarSP("SpGrabarModificarPaciente",null,
                    Parametro("@pIdpaciente",idPaciente),
                    Parametro("@pnombre",nombres),
                    Parametro("@Papellidos",apellidos),
                    Parametro("@pfechaNacimiento",fechaNacimiento),
                    Parametro("@Ptelefono",telefono),
                    Parametro("@Pdireccion",direccion),
                    Parametro("@Pusuario",Globals.usuario)
                    );
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void eliminar(string idPaciente)
        {
            try
            {
                ejecutarSP("SpEliminarPaciente",null,Parametro("@PidPaciente",idPaciente));
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataTable buscar(string nombres,string apellidos)
        {
            try
            {
                return consultarTabla(@"SELECT IDPACIENTE, NOMBRES,APELLIDOS,FECHANACIMIENTO,TELEFONO,DIRECCION FROM PACIENTE WHERE NOMBRES LIKE '%" + nombres + "%' OR APELLIDOS LIKE '%"+apellidos +"%'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable seleccionarPaciente(string idPaciente)
        {
            try
            {
                return consultarTabla(@"SELECT (NOMBRES + ' ' + APELLIDOS) NOMBRES, FECHANACIMIENTO,TELEFONO,DIRECCION, (2017 - YEAR(FECHANACIMIENTO)) EDAD FROM PACIENTE WHERE IDPACIENTE = "+ idPaciente);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
