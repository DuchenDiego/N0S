using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    ////***************************SUCURSALES***********************************************////
    //Obtener Sucursal Por Id
    [WebMethod]
    public DSVentaAlquiler.SucursalDataTable obtenersucursalporid(int nIdsuc)
    {
        SUCURSALES sucursal = new SUCURSALES();
        return sucursal.ObtenerSucursalSeleccionada(nIdsuc);
    }
    //Obtener Sucursales
    [WebMethod]
    public DSVentaAlquiler.SucursalDataTable obtenersucursales()
    {
       SUCURSALES sucursal = new SUCURSALES();
        return sucursal.ObtenerSucursal();
    }
    //Obtener Sucursales Habilitadas
    [WebMethod]
    public DSVentaAlquiler.SucursalDataTable obtenersucursaleshabilitadas()
    {
        SUCURSALES sucursal = new SUCURSALES();
        return sucursal.ObtenerSucursalesHabilitadas();
    }
    //Obtener Zona y Direc de Sucursal
    /*[WebMethod]
    public DSVentaAlquiler.SucursalDataTable obtenerdireczonasuc()
    {
        SUCURSALES sucursal = new SUCURSALES();
        return sucursal.ObtenerDirecZonaSuc();
    }*/
    //Obtener Id Sucursal por Direccion
    [WebMethod]
    public DSVentaAlquiler.SucursalDataTable obteneridsucdir(string ndir)
    {
        SUCURSALES sucursal = new SUCURSALES();
        return sucursal.ObtenerIdSucDir(ndir);
    }
    //Ingresar Sucursales
    [WebMethod]
    public Boolean ingresarsucursal(string ndireccion, string nzona, string ntelefono, int ncantvehiculos, int ncantmaxvehiculos, int nciadmin,string nestado)
    {
        SUCURSALES sucursal = new SUCURSALES();
        Boolean resultado = sucursal.IngresarSucursal(ndireccion,nzona,ntelefono,ncantvehiculos,ncantmaxvehiculos,nciadmin,nestado);
        return resultado;
    }
    //Modificar Sucursales
    [WebMethod]
    public Boolean modifsucursal(string ndireccion, string nzona, string ntelefono, int ncantvehiculos, int ncantmaxvehiculos, int nciadmin,string nestado, int nidsucsec)
    {
        SUCURSALES sucursal = new SUCURSALES();
        Boolean resultado = sucursal.ModificarSucursal(ndireccion, nzona, ntelefono, ncantvehiculos, ncantmaxvehiculos, nciadmin,nestado,nidsucsec);
        return resultado;
    }
    //Baja Sucursales
    [WebMethod]
    public Boolean bajasucursal(int nidsucsec)
    {
        SUCURSALES sucursal = new SUCURSALES();
        Boolean resultado = sucursal.BajaSucursal(nidsucsec);
        return resultado;
    }
    //Añadir Vehiculos Sucursal
    [WebMethod]
    public Boolean modificarcantvehicsuc(int ncantve,int nidsuc)
    {
        SUCURSALES sucursal = new SUCURSALES();
        Boolean resultado = sucursal.ModificarVehicSuc(ncantve, nidsuc);
        return resultado;
    }
    //Disminucion Vehiculo Sucursal
    [WebMethod]
    public Boolean disminucionvehiculosuc(int nidsuc)
    {
        SUCURSALES sucursal = new SUCURSALES();
        Boolean resultado = sucursal.DisminucionCantidadVehic(nidsuc);
        return resultado;
    }
    ////***************************EMPLEADOS***********************************************////
    //Obtener Empleado Por Id
    [WebMethod]
    public DSVentaAlquiler.EmpleadoDataTable obtenerempleadoporid(int nidemp)
    {
        EMPLEADOS empleado = new EMPLEADOS();
        return empleado.ObtenerEmpleadoSeleccionado(nidemp);
    }
    //Obtener Empleados
    [WebMethod]
    public DSVentaAlquiler.EmpleadoDataTable obtenerempleados()
    {
        EMPLEADOS empleado = new EMPLEADOS();
        return empleado.ObtenerEmpleado();
    }
    //Obtener Empleados Habilitados
    [WebMethod]
    public DSVentaAlquiler.EmpleadoDataTable obtenerempleadoshabilitados()
    {
        EMPLEADOS empleado = new EMPLEADOS();
        return empleado.ObtenerEmpleadosHabilitados();
    }
    //Obtener Empleados Deshabilitados
    [WebMethod]
    public DSVentaAlquiler.EmpleadoDataTable obtenerempleadosdeshabilitados()
    {
        EMPLEADOS empleado = new EMPLEADOS();
        return empleado.ObtenerEmpleadosDeshabilitados();
    }
    //Ingresar Empleados
    [WebMethod]
    public Boolean ingresarempleado(int nciempl, string nnombre, string napellidop, string napellidom,DateTime nfechanac,string nemail, string ncel,string nestado,string nlat,string nocup,int nciadmin,int nidsuc)
    {
        EMPLEADOS empleado = new EMPLEADOS();
        Boolean resultado = empleado.IngresarEmpleado(nciempl,nnombre,napellidop,napellidom,nfechanac,nemail,ncel,nestado,nlat,nocup,nciadmin,nidsuc);
        return resultado;
    }
    //Ingresar Encargados
    [WebMethod]
    public Boolean ingresarencargado(string nuse, string nconte, int nciempe,string nimge)
    {
        ENCARGADO encargado = new ENCARGADO();
        Boolean resultado = encargado.IngresarEncargado(nuse, nconte, nciempe, nimge);
        return resultado;
    }
    //Ingresar Vendedores
    [WebMethod]
    public Boolean ingresarvendedor(string nusv, string ncontv, int nciempv, string nimgv)
    {
        VENDEDOR vendedor = new VENDEDOR();
        Boolean resultado = vendedor.IngresarVendedor(nusv, ncontv, nciempv, nimgv);
        return resultado;
    }
    //Modificar Encargados
    [WebMethod]
    public Boolean modificarencargado(string nuse, string nconte, int nciempe, string nimge,int nciemp)
    {
        ENCARGADO encargado = new ENCARGADO();
        Boolean resultado = encargado.ModificarEncargado(nuse, nconte, nciempe, nimge,nciemp);
        return resultado;
    }
    //Modificar Vendedores
    [WebMethod]
    public Boolean modificarvendedor(string nusv, string ncontv, int nciempv, string nimgv,int nciemp)
    {
        VENDEDOR vendedor = new VENDEDOR();
        Boolean resultado = vendedor.ModificarVendedor(nusv, ncontv, nciempv, nimgv, nciemp);
        return resultado;
    }
    //Cambiar Imagen Vendedor
    [WebMethod]
    public Boolean  cambiarimagenv(string nimgv,int nciemp)
    {
        VENDEDOR vendedor = new VENDEDOR();
        Boolean resultado = vendedor.CambiarImagenV(nimgv, nciemp);
        return resultado;
    }
    //Cambiar Imagen Encargado
    [WebMethod]
    public Boolean cambiarimagene(string nimge, int nciemp)
    {
        ENCARGADO encargado = new ENCARGADO();
        Boolean resultado = encargado.CambiarImagenE(nimge, nciemp);
        return resultado;
    }
    //Obtener Encargado por Nick
    [WebMethod]
    public DSVentaAlquiler.EncargadoAlquilerDataTable obtenerencargadopornick(string nnick)
    {
        ENCARGADO encargado = new ENCARGADO();
        return encargado.ObtenerEncargadoporNick(nnick);
    }
    //Obtener Vendedor por Nick
    [WebMethod]
    public DSVentaAlquiler.VendedorDataTable obtenervendedorpornick(string nnick)
    {
        VENDEDOR vendedor = new VENDEDOR();
        return vendedor.ObtenerVendedorporNick(nnick);
    }
    //Modificar Empleados
    [WebMethod]
    public Boolean modifempleado(int nciempl, string nnombre, string napellidop, string napellidom, string nfechanac, string nemail, string ncel, string nestado, string nlat, string nocup, int nciadmin, int nidsuc, int nidemp)
    {
        EMPLEADOS empleado = new EMPLEADOS();
        Boolean resultado = empleado.ModificarEmpleado(nciempl, nnombre, napellidop, napellidom, nfechanac, nemail, ncel, nestado, nlat, nocup, nciadmin, nidsuc, nidemp);
        return resultado;
    }
    //Baja Empleados
    [WebMethod]
    public Boolean bajaempleado(int nidemp)
    {
        EMPLEADOS empleado = new EMPLEADOS();
        Boolean resultado = empleado.BajaEmpleado(nidemp);
        return resultado;
    }
    //Busqueda Empleados 
    [WebMethod]
    public DSVentaAlquiler.EmpleadoDataTable busquedaempleados(string nparam, string nparam2)
    {
        EMPLEADOS empleado = new EMPLEADOS();
        return empleado.BusquedaEmpleados(nparam, nparam2);
    }
    //Busqueda Empleados Habilitados
    [WebMethod]
    public DSVentaAlquiler.EmpleadoDataTable busquedaempleadoshabilitados(string nparam,string nparam2)
    {
        EMPLEADOS empleado = new EMPLEADOS();
        return empleado.BusquedaEmpleadosHabilitados(nparam,nparam2);
    }
    //Busqueda Empleados Deshabilitados
    [WebMethod]
    public DSVentaAlquiler.EmpleadoDataTable busquedaempleadosdeshabilitados(string nparam,string nparam2)
    {
        EMPLEADOS empleado = new EMPLEADOS();
        return empleado.BusquedaEmpleadosDeshabilitados(nparam,nparam2);
    }
    ////***************************VEHICULOS***********************************************////
    //Obtener Vehiculos
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable obtenervehiculoss()
    {
        VEHICULOS vehiculo = new VEHICULOS();
        return vehiculo.ObtenerVehiculos();
    }
    //Obtener Vehiculos habilitados
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable obtenervehiculoshabilitados()
    {
        VEHICULOS vehiculo = new VEHICULOS();
        return vehiculo.ObtenerVehiculosHabilitados();
    }
    //Obtener Vehiculos Alquiler habilitados
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable obtenervehiculosalquilerhabilitados()
    {
        VEHICULOS vehiculo = new VEHICULOS();
        return vehiculo.ObtenerVehiculosAlquilerHabilitados();
    }
    //Obtener Vehiculos Venta habilitados
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable obtenervehiculosventahabilitados()
    {
        VEHICULOS vehiculo = new VEHICULOS();
        return vehiculo.ObtenerVehiculosVentaHabilitados();
    }
    //Obtener Vehiculos deshabilitados
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable obtenervehiculosdeshabilitados()
    {
        VEHICULOS vehiculo = new VEHICULOS();
        return vehiculo.ObtenerVehiculosDeshabilitados();
    }
    //Obtener Vehiculo por Id
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable obtenervehiculoporid(int nidve)
    {
        VEHICULOS vehiculo = new VEHICULOS();
        return vehiculo.ObtenerVehiculoPorId(nidve);
    }
    //Registrar Vehiculos
    [WebMethod]
    public Boolean ingresarvehiculo(double ncostoventa, double ncostoalquiler, string nurlmod, string ndimensiones, string ntransmis, int ncant, string nmmg, string nmodelo, string nsegur, string nmotor, string nmarca, string nasientos, int nciadmin, int nidsuc, string nelqovent, string nestado)
    {
        VEHICULOS vehiculo = new VEHICULOS();
        Boolean resultado = vehiculo.IngresarVehiculo( ncostoventa,  ncostoalquiler,  nurlmod,  ndimensiones,  ntransmis,  ncant,  nmmg,  nmodelo,  nsegur,  nmotor,  nmarca,  nasientos,  nciadmin,  nidsuc,  nelqovent,  nestado);
        return resultado;
    }
    //Modificar Cantidad Vehiculos 
    [WebMethod]
    public Boolean modificarcantidadvehiculos(int ncantve, int nidve)
    {
        VEHICULOS vehiculos = new VEHICULOS();
        Boolean resultado = vehiculos.ModifCantVehiculos(ncantve, nidve);
        return resultado;
    }
    //Baja Vehiculos
    [WebMethod]
    public Boolean bajavehiculo(int nidve)
    {
        VEHICULOS vehiculos = new VEHICULOS();
        Boolean resultado = vehiculos.BajaVehiculo(nidve);
        return resultado;
    }
    //Disminucion Vehiculo Alquiler
    [WebMethod]
    public Boolean disminucionvehiculoalquiler(int nidve)
    {
        VEHICULOS vehiculos = new VEHICULOS();
        Boolean resultado = vehiculos.DisminucionVehiculoAlquiler(nidve);
        return resultado;
    }
    //Aumento Vehiculo Alquiler
    [WebMethod]
    public Boolean aumentovehiculoalquiler(int nidve)
    {
        VEHICULOS vehiculos = new VEHICULOS();
        Boolean resultado = vehiculos.AumentoVehiculoAlquiler(nidve);
        return resultado;
    }
    //Disminucion Vehiculo Venta
    [WebMethod]
    public Boolean disminucionvehiculoventa(int nidve)
    {
        VEHICULOS vehiculos = new VEHICULOS();
        Boolean resultado = vehiculos.DisminucionVehiculoVenta(nidve);
        return resultado;
    }
    //Busqueda Empleados 
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable busquedavehiculos(string nparam, string nparam2)
    {
        VEHICULOS vehiculos = new VEHICULOS();
        return vehiculos.BusquedaVehiculos(nparam, nparam2);
    }
    //Busqueda Empleados Habilitados
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable busquedavehiculoshabilitados(string nparam, string nparam2)
    {
        VEHICULOS vehiculos = new VEHICULOS();
        return vehiculos.BusquedaVehiculosHabilitados(nparam, nparam2);
    }
    //Busqueda Empleados Deshabilitados
    [WebMethod]
    public DSVentaAlquiler.VehiculoDataTable busquedavehiculosdeshabilitados(string nparam, string nparam2)
    {
        VEHICULOS vehiculos = new VEHICULOS();
        return vehiculos.BusquedaVehiculosDeshabilitados(nparam, nparam2);
    }
    //************************CLIENTE*********************//
    //Registrar Cliente
    [WebMethod]
    public Boolean ingresarcliente(int ncicl, string nnombre, string napp, string napm, string ncel, string nemail, string ndir, string ncuentab)
    {
        CLIENTE cliente = new CLIENTE();
        Boolean resultado = cliente.IngresaCliente(ncicl, nnombre, napp, napm, ncel, nemail, ndir, ncuentab);
        return resultado;
    }
    //Obtener Cliente por Ci
    [WebMethod]
    public DSVentaAlquiler.ClienteDataTable obtenerclienteporid(int nidcl)
    {
        CLIENTE cliente = new CLIENTE();
        return cliente.ObtenerClienteporCI(nidcl);
    }
    //******************Alquiler************************************///
    //Registrar Alquiler
    [WebMethod]
    public Boolean ingresaralquiler(DateTime nfechi, DateTime nfechf, DateTime nfecha, int ntotala, int nplazoa, int nciemp, int ncicl, int nid, string nest)
    {
        ALQUILER alquiler = new ALQUILER();
        Boolean resultado = alquiler.RegistrarAlquiler(nfechi, nfechf, nfecha, ntotala, nplazoa, nciemp, ncicl, nid, nest);
        return resultado;
    }
    //Obtener alquiler por CI cliente
    [WebMethod]
    public DSVentaAlquiler.AlquilerDataTable obteneralquilerporcicliente(int ncicl)
    {
        ALQUILER alquiler = new ALQUILER();
        return alquiler.ObtenerAlquilerporCIcliente(ncicl);
    }
    //Obtener alquileres pendientes
    [WebMethod]
    public DSVentaAlquiler.AlquilerDataTable obteneralquileres()
    {
        ALQUILER alquiler = new ALQUILER();
        return alquiler.ObtenerAlquileres();
    }
    //Devolver Alquiler
    [WebMethod]
    public Boolean devolveralquiler(int ncicl)
    {
        ALQUILER alquiler = new ALQUILER();
        Boolean resultado = alquiler.DevolverAlquiler(ncicl);
        return resultado;
    }
    ///******************VENTA************************************///
    /////Registrar Venta
    [WebMethod]
    public Boolean ingresarventa(int nciemp, int nidve, int ncicl, DateTime nfech)
    {
        VENTA venta = new VENTA();
        Boolean resultado = venta.RegistrarVenta(nciemp, nidve, ncicl, nfech);
        return resultado;
    }
    //Obtener venta por CI cliente
    [WebMethod]
    public DSVentaAlquiler.VentaDataTable obtenerventaporcicliente(int ncicl)
    {
        VENTA venta = new VENTA();
        return venta.ObtenerVentaporCIcliente(ncicl);
    }
    //Obtener ventas
    [WebMethod]
    public DSVentaAlquiler.VentaDataTable obtenerventas()
    {
        VENTA venta = new VENTA();
        return venta.ObtenerVentas();
    }
    //*************************FACTURA***********************************///
    /////Registrar Factura
    [WebMethod]
    public Boolean registrarfactura(int nnumfac, string ncicl, string nnitemp, string nnumaut, double ntotal, string ncodigoc, int nciemp)
    {
        FACTURA factura = new FACTURA();
        Boolean resultado = factura.RegistrarFactura(nnumfac, ncicl, nnitemp, nnumaut, ntotal, ncodigoc, nciemp);
        return resultado;
    }
    [WebMethod]
    public string HelloWorld() {
        return "Hola a todos";
    }
    
}