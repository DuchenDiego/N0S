using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de CLIENTE
/// </summary>
public class CLIENTE
{
    //Obtener Cliente por CI
    public DSVentaAlquiler.ClienteDataTable ObtenerClienteporCI(int nCicl)
    {
        ClienteTableAdapter cliente = new ClienteTableAdapter();
        return cliente.ObtenerClientepoCI(nCicl);
    }
    //Insertar Cliente
    public Boolean IngresaCliente(int nCicl,string nNombre,string nApp,string nApm,string nCel,string nEmail,string nDir,string nCuentab)
    {
        ClienteTableAdapter cliente = new ClienteTableAdapter();
        try
        {
            cliente.Insert( nCicl, nNombre, nApp, nApm, nCel, nEmail, nDir, nCuentab);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
	public CLIENTE()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}