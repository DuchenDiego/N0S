using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de VENTA
/// </summary>
public class VENTA
{
    //Registro de Venta
    public Boolean RegistrarVenta(int nCiemp,int nIdve,int nCicl,DateTime nFech)
    {
        VentaTableAdapter venta = new VentaTableAdapter();
        try
        {
            venta.Insert(nCiemp, nIdve, nCicl, nFech);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Obtener Alquiler por CI cliente
    public DSVentaAlquiler.VentaDataTable ObtenerVentaporCIcliente(int nCicl)
    {
        VentaTableAdapter venta = new VentaTableAdapter();
        return venta.ObtenerVentaporCIcliente(nCicl);
    }
    //Obtener Ventas
    public DSVentaAlquiler.VentaDataTable ObtenerVentas()
    {
        VentaTableAdapter venta = new VentaTableAdapter();
        return venta.GetDataVenta();
    }
	public VENTA()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}