using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de EMPLEADOS
/// </summary>
public class EMPLEADOS
{
    //Obtener Empleados
    public DSVentaAlquiler.EmpleadoDataTable ObtenerEmpleado(){
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        return empleado.GetDataCustomEmpleado();
    }
    //Obtener Empleado Seleccionado
    public DSVentaAlquiler.EmpleadoDataTable ObtenerEmpleadoSeleccionado(int nIdemp)
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        return empleado.SeleccionEmpleado(nIdemp);
    }
    //Obtener Empleados Habilitados
    public DSVentaAlquiler.EmpleadoDataTable ObtenerEmpleadosHabilitados()
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        return empleado.ObtenerEmpleadosHabilitados();
    }
    //Obtener Empleados Deshabilitados
    public DSVentaAlquiler.EmpleadoDataTable ObtenerEmpleadosDeshabilitados()
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        return empleado.ObtenerEmpleadosDeshabilitados();
    }
    //Busqueda Empleados Habilitados
    public DSVentaAlquiler.EmpleadoDataTable BusquedaEmpleadosHabilitados(string nParam,string nParam2)
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        return empleado.BusquedaEmpleadosHabilitados(nParam,nParam2);
    }
    //Busqueda Empleados Deshabilitados
    public DSVentaAlquiler.EmpleadoDataTable BusquedaEmpleadosDeshabilitados(string nParam,string nParam2)
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        return empleado.BusquedaEmpleadosDeshabilitados(nParam,nParam2);
    }
    //Busqueda Empleados General
    public DSVentaAlquiler.EmpleadoDataTable BusquedaEmpleados(string nParam,string nParam2)
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        return empleado.BusquedaEmpleadosGeneral(nParam,nParam2);
    }
    //Registro de Empleados
    public Boolean IngresarEmpleado(int nCiEmpl, string nNombre, string nApellidop, string nApellidom,DateTime nFechanac,string nEmail, string nCel,string nEstado,string nLat,string nOcup,int nCiadmin,int nIdsuc)
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        try
        {
            empleado.Insert(nCiEmpl,nNombre,nApellidop,nApellidom,nFechanac,nEmail,nCel,nEstado,nLat,nOcup,nCiadmin,nIdsuc);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Modificacion de Empleados
    public Boolean ModificarEmpleado(int nCiEmpl, string nNombre, string nApellidop, string nApellidom, string nFechanac, string nEmail, string nCel, string nEstado, string nLat, string nOcup, int nCiadmin, int nIdsuc,int nIdemp)
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        try{
            empleado.UpdateEmpleado(nCiEmpl,  nNombre,  nApellidop, nApellidom, nFechanac,  nEmail,  nCel,  nEstado, nLat, nOcup, nCiadmin,nIdsuc,nIdemp);
            return true;
            }
        catch(Exception ex)
        {
                Console.Write(ex.StackTrace);
                return false;
                }
    }
    //Baja de Empleados
    public Boolean BajaEmpleado(int nCiemp)
    {
        EmpleadoTableAdapter empleado = new EmpleadoTableAdapter();
        try
        {
            empleado.BajaEmpleado(nCiemp);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
	public EMPLEADOS()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}