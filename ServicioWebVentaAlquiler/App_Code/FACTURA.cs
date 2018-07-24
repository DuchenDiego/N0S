using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DSVentaAlquilerTableAdapters;
/// <summary>
/// Descripción breve de FACTURA
/// </summary>
public class FACTURA
{
    //Registro de Factura
    public Boolean RegistrarFactura(int nNumfac,string nCicl,string nNitemp,string nNumaut,double nTotal,string nCodigoc,int nCiemp)
    {
        FacturaTableAdapter factura = new FacturaTableAdapter();
        try
        {
            factura.Insert( nNumfac, nCicl, nNitemp, nNumaut, nTotal, nCodigoc, nCiemp);
            return true;
        }
        catch (Exception ex)
        {
            Console.Write(ex.StackTrace);
            return false;
        }
    }
	public FACTURA()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}