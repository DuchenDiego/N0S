using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de VENDEDOR
/// </summary>
public class VENDEDOR
{
    //Ingresar Vendedores
    public Boolean IngresarVendedor(string nUsv, string nContv, int nCiempv ,string nImgv)
    {
        VendedorTableAdapter vendedor = new VendedorTableAdapter();
        try
        {
            vendedor.Insert(nUsv, nContv, nCiempv,nImgv);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Modificar Vendedores
    public Boolean ModificarVendedor(string nUsv, string nContv, int nCiempv, string nImgv, int nCiemp)
    {
        VendedorTableAdapter vendedor = new VendedorTableAdapter();
        try
        {
            vendedor.UpdateVendedor(nUsv, nContv, nCiempv, nImgv, nCiemp);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Cambiar Imagen Vendedor
    public Boolean CambiarImagenV(string nImgV, int nCiemp)
    {
        VendedorTableAdapter vendedor = new VendedorTableAdapter();
        try
        {
            vendedor.CambiarImagenV(nImgV, nCiemp);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Obtener Vendedor por nick
    public DSVentaAlquiler.VendedorDataTable ObtenerVendedorporNick(string nNick)
    {
        VendedorTableAdapter vendedor = new VendedorTableAdapter();
        return vendedor.ObtenerVendedorporNick(nNick);
    }
	public VENDEDOR()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}