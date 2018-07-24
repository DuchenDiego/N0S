using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de ALQUILER
/// </summary>
public class ALQUILER
{
    //Registro de Alquiler
    public Boolean RegistrarAlquiler(DateTime nFechi,DateTime nFechf,DateTime nFecha,int nTotala,int nPlazoa,int nCiemp,int nCicl,int nId,string nEst)
    {
        AlquilerTableAdapter alquiler = new AlquilerTableAdapter();
        try
        {
            alquiler.Insert(nFechi,nFechf,nFecha,nTotala,nPlazoa,nCiemp,nCicl,nId,nEst);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Obtener Alquiler por CI cliente
    public DSVentaAlquiler.AlquilerDataTable ObtenerAlquilerporCIcliente(int nCicl)
    {
        AlquilerTableAdapter alquiler = new AlquilerTableAdapter();
        return alquiler.ObtenerAlquilerporCIcliente(nCicl);
    }
    //Obtener Alquileres 
    public DSVentaAlquiler.AlquilerDataTable ObtenerAlquileres()
    {
        AlquilerTableAdapter alquiler = new AlquilerTableAdapter();
        return alquiler.GetDataAquiler();
    }
    //Registro de Alquiler
    public Boolean DevolverAlquiler(int nCicl)
    {
        AlquilerTableAdapter alquiler = new AlquilerTableAdapter();
        try
        {
            alquiler.AlquilerDevuelto(nCicl);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
	public ALQUILER()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}