using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de SUCURSALES
/// </summary>
public class SUCURSALES
{
    //Registro de Sucursal
    public Boolean IngresarSucursal(string nDireccion, string nZona, string nTelefono, int nCantVehiculos, int nCantMaxVehiculos, int nCiAdmin,string nEstado){
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        try{
            sucursal.Insert(nDireccion,nZona,nTelefono,nCantVehiculos,nCantMaxVehiculos,nCiAdmin,nEstado);
            return true;
            }
        catch(Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Obtener Sucursal Seleccionada
    public DSVentaAlquiler.SucursalDataTable ObtenerSucursalSeleccionada(int nidsuc)
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        return sucursal.SeleccionSucursal(nidsuc);
    }
    //Obtener Sucursales
    public DSVentaAlquiler.SucursalDataTable ObtenerSucursal()
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        return sucursal.GetDataSucursal();
    }
    //Obtener Sucursales habilitadas
    public DSVentaAlquiler.SucursalDataTable ObtenerSucursalesHabilitadas()
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        return sucursal.ObtenerSucursalesHabilitadas();
    }
    //Obtener Direccion Sucursales
    /*public DSVentaAlquiler.SucursalDataTable ObtenerDirecZonaSuc()
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        return sucursal.ObtenerSucursalesDir();
    }*/
    //Obtener Id Sucursal por Direccion
    public DSVentaAlquiler.SucursalDataTable ObtenerIdSucDir(string nDir)
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        return sucursal.ObtenerIdSucDir(nDir);
    }
    //Modificacion de Sucursales
    public Boolean ModificarSucursal(string nDireccion, string nZona, string nTelefono, int nCantVehiculos, int nCantMaxVehiculos, int nCiAdmin,string nEstado,int nIdSucSec)
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        try
        {
            sucursal.UpdateSucursal(nDireccion, nZona, nTelefono, nCantVehiculos, nCantMaxVehiculos, nCiAdmin,nEstado, nIdSucSec);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Baja de Sucursales
    public Boolean BajaSucursal(int nIdSucSec)
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        try
        {
            sucursal.BajaSucursal(nIdSucSec);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Añadir Vehiculos Sucursal
    public Boolean ModificarVehicSuc(int nCantv,int nIdsuc)
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        try
        {
            sucursal.ModificarVehiculosSucursal(nCantv,nIdsuc);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Disminucion Vehiculo Sucursal
    public Boolean DisminucionCantidadVehic(int nIdsuc)
    {
        SucursalTableAdapter sucursal = new SucursalTableAdapter();
        try
        {
            sucursal.DisminucionCantidadVehic(nIdsuc);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
	public SUCURSALES()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}