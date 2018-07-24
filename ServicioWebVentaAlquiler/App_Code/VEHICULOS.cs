using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de VEHICULOS
/// </summary>
public class VEHICULOS
{
    //Registro de Sucursal
    public Boolean IngresarVehiculo(double nCostoventa,double nCostoalquiler,string nUrlmod,string nDimensiones,string nTransmis,int nCant,string nImg,string nModelo,string nSegur,string nMotor,string nMarca,string nAsientos,int nCiadmin,int nIdsuc,string nAlqovent,string nEstado)
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        try
        {
            vehiculo.Insert(nCostoventa, nCostoalquiler, nUrlmod, nDimensiones, nTransmis, nCant, nImg, nModelo, nSegur, nMotor, nMarca, nAsientos,nCiadmin, nIdsuc, nAlqovent, nEstado);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Obtener Vehiculos
    public DSVentaAlquiler.VehiculoDataTable ObtenerVehiculos()
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        return vehiculo.GetDataVehiculo();
    }
    //Obtener Vehiculos habilitados
    public DSVentaAlquiler.VehiculoDataTable ObtenerVehiculosHabilitados()
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        return vehiculo.ObtenerVehiculosHabilitados();
    }
    //Obtener Vehiculos Alquiler habilitados
    public DSVentaAlquiler.VehiculoDataTable ObtenerVehiculosAlquilerHabilitados()
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        return vehiculo.ObtenerVehiculosAlquilerHabilitados();
    }
    //Obtener Vehiculos Alquiler habilitados
    public DSVentaAlquiler.VehiculoDataTable ObtenerVehiculosVentaHabilitados()
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        return vehiculo.ObtenerVehiculosVentaHabilitados();
    }
    //Obtener Vehiculos Deshabilitados
    public DSVentaAlquiler.VehiculoDataTable ObtenerVehiculosDeshabilitados()
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        return vehiculo.ObtenerVehiculosDeshabilitados();
    }
    //Modificar Cantidad Vehiculos 
    public Boolean ModifCantVehiculos(int nCantv, int nIdve)
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        try
        {
            vehiculo.ModificarCantidad(nCantv, nIdve);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Baja de Vehiculos
    public Boolean BajaVehiculo(int nIdve)
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        try
        {
            vehiculo.BajaVehiculo(nIdve);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Disminucion Vehiculo Alquiler
    public Boolean DisminucionVehiculoAlquiler(int nIdve)
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        try
        {
            vehiculo.DisminucionVehiculoAlquiler(nIdve);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Aumento Vehiculo Alquiler
    public Boolean AumentoVehiculoAlquiler(int nIdve)
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        try
        {
            vehiculo.AumentoVehiculoAlquiler(nIdve);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Disminucion Vehiculo Venta
    public Boolean DisminucionVehiculoVenta(int nIdve)
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        try
        {
            vehiculo.DisminucionVehiculoVenta(nIdve);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Obtener Vehiculo por id
    public DSVentaAlquiler.VehiculoDataTable ObtenerVehiculoPorId(int nIdve)
    {
        VehiculoTableAdapter vehiculo = new VehiculoTableAdapter();
        return vehiculo.SeleccionVehiculo(nIdve);
    }
    //Busqueda Vehiculos Habilitados
    public DSVentaAlquiler.VehiculoDataTable BusquedaVehiculosHabilitados(string nParam, string nParam2)
    {
        VehiculoTableAdapter Vehiculos = new VehiculoTableAdapter();
        return Vehiculos.BusquedaVehiculosHabilitados(nParam, nParam2);
    }
    //Busqueda Vehiculos Deshabilitados
    public DSVentaAlquiler.VehiculoDataTable BusquedaVehiculosDeshabilitados(string nParam, string nParam2)
    {
        VehiculoTableAdapter Vehiculos = new VehiculoTableAdapter();
        return Vehiculos.BusquedaVehiculosDeshabilitados(nParam, nParam2);
    }
    //Busqueda Vehiculos General
    public DSVentaAlquiler.VehiculoDataTable BusquedaVehiculos(string nParam, string nParam2)
    {
        VehiculoTableAdapter Vehiculos = new VehiculoTableAdapter();
        return Vehiculos.BusquedaVehiculosGeneral(nParam, nParam2);
    }
	public VEHICULOS()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
    
}