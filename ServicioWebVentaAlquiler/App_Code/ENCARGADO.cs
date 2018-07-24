using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de ENCARGADO
/// </summary>
public class ENCARGADO
{
    //Ingresar Encargados
    public Boolean IngresarEncargado(string nUse, string nConte, int nCiempe, string nImgE)
    {
        EncargadoAlquilerTableAdapter encargado = new EncargadoAlquilerTableAdapter();
        try
        {
            encargado.Insert(nUse, nConte, nCiempe, nImgE);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Modificar Encargados
    public Boolean ModificarEncargado(string nUse, string nConte, int nCiempe, string nImgE,int nCiemp)
    {
        EncargadoAlquilerTableAdapter encargado = new EncargadoAlquilerTableAdapter();
        try
        {
            encargado.UpdateEncargadoAlquiler(nUse, nConte, nCiempe, nImgE,nCiemp);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Cambiar Imagen Encargado
    public Boolean CambiarImagenE(string nImg,int nCiemp)
    {
        EncargadoAlquilerTableAdapter encargado = new EncargadoAlquilerTableAdapter();
        try
        {
            encargado.CambiarImagenE(nImg,nCiemp);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
    //Obtener Encargado por nick
    public DSVentaAlquiler.EncargadoAlquilerDataTable ObtenerEncargadoporNick(string nNick)
    {
        EncargadoAlquilerTableAdapter encargado = new EncargadoAlquilerTableAdapter();
        return encargado.ObtenerEncargadoporNick(nNick);
    }
	public ENCARGADO()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}