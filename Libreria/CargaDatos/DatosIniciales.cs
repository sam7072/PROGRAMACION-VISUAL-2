using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo.entidades;


namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListaTipo
        {
            Presupuestos,Iventarios,Prerequisitos
        }



        public Dictionary<ListaTipo, object> Carga()
        {


            //Distribuidores
            //mago de oz
            Distribuidores dis1 = new Distribuidores()
            {
                LibrosD = "Mago de oz",
                PrecioD = 15.00M,
                Edicion = "2001",
                Oferta = "40%",
                Editoriales = "Libreria Cientifica",
                ConfirmacionD = "Rechazada"

            };
            Distribuidores dis2 = new Distribuidores()
            {
                LibrosD = "Mago de oz",
                PrecioD = 20.00M,
                Edicion = "2001",
                Oferta = "50%",
                Editoriales = "Cedisa Libros",
                ConfirmacionD = "Aceptada"

            };


            //El principito
            Distribuidores dis3 = new Distribuidores()
            {
                LibrosD = "El principito",
                PrecioD = 18.00M,
                Edicion = "2007",
                Oferta = "0%",
                Editoriales = "Libreria Española",
                ConfirmacionD = "Rechazada"

            };
            Distribuidores dis4 = new Distribuidores()
            {
                LibrosD = "El principito",
                PrecioD = 25.00M,
                Edicion = "2021",
                Oferta = "10%",
                Editoriales = "Libreria Cientifica",
                ConfirmacionD = "Rechazada"

            };
            Distribuidores dis5 = new Distribuidores()
            {
                LibrosD = "El principito",
                PrecioD = 14.00M,
                Edicion = "2004",
                Oferta = "20%",
                Editoriales = "Cedisa Libros",
                ConfirmacionD = "Aceptada"

            };


            // Viaje al centro de la tierra
            Distribuidores dis6 = new Distribuidores()
            {
                LibrosD = "Viaje al centro de la tierra",
                PrecioD = 15.00M,
                Edicion = "2009",
                Oferta = "0%",
                Editoriales = "Mr.Books",
                ConfirmacionD = "Aceptada"

            };
            Distribuidores dis7 = new Distribuidores()
            {
                LibrosD = "Viaje al centro de la tierra",
                PrecioD = 20.00M,
                Edicion = "2008",
                Oferta = "15%",
                Editoriales = "Cedisa Libros",
                ConfirmacionD = "Rechazado"

            };


            // De la luna a la Tierra
            Distribuidores dis8 = new Distribuidores()
            {
                LibrosD = "De la luna a la Tierra",
                PrecioD = 30.00M,
                Edicion = "2010",
                Oferta = "50%",
                Editoriales = "Libreria Española",
                ConfirmacionD = "Aceptada"

            };
            Distribuidores dis9 = new Distribuidores()
            {
                LibrosD = "De la luna a la Tierra",
                PrecioD = 16.00M,
                Edicion = "2011",
                Oferta = "0%",
                Editoriales = "Libreria Cientifica",
                ConfirmacionD = "Rechazada"

            };



            // Las mil y una noches
            Distribuidores dis10 = new Distribuidores()
            {
                LibrosD = "Las mil y una noches",
                PrecioD = 50.00M,
                Edicion = "2015",
                Oferta = "50%",
                Editoriales = "Libreria Cientifica",
                ConfirmacionD = "Rechazada"

            };
            Distribuidores dis11 = new Distribuidores()
            {
                LibrosD = "Las mil y una noches",
                PrecioD = 30.00M,
                Edicion = "2016",
                Oferta = "30%",
                Editoriales = "Cedisa Libros",
                ConfirmacionD = "Rechazada"

            };
            Distribuidores dis12 = new Distribuidores()
            {
                LibrosD = "Las mil y una noches",
                PrecioD = 25.00M,
                Edicion = "2013",
                Oferta = "10%",
                Editoriales = "Libreria novoLibros",
                ConfirmacionD = "Aceptada"

            };

            List<Distribuidores> ListaDistribuidores = new List<Distribuidores>()
            {
                //mago de oz
                dis1,dis2,
                //el principito
                dis3,dis4,dis5,
                //Viaje al centro de la tierra
                dis6,dis7,
                //De la luna a la tierra
                dis8,dis9,
                //Las mil y una noches
                dis10,dis11,dis12
            };
















            //DemandaLibreria
            //Mago de oz
            DemandaLibreria dem1 = new DemandaLibreria()
            {
                Usuario = "Pedro",
                Libro = "Mago de oz",
                Fechas = new DateTime(2012,12,12),
                ConfirmacionDL = "Aprobada"
            };
            DemandaLibreria dem2 = new DemandaLibreria()
            {
                Usuario = "Maria",
                Libro = "Mago de oz",
                Fechas = new DateTime(2012, 01, 01),
                ConfirmacionDL = "no Aprobada"
            };

            //El principito
            DemandaLibreria dem3 = new DemandaLibreria()
            {
                Usuario = "Juan",
                Libro = "El principito",
                Fechas = new DateTime(2005, 11, 15),
                ConfirmacionDL = "Aprobada"
            };


            //Viaje al centro de la tierra
            DemandaLibreria dem4 = new DemandaLibreria()
            {
                Usuario = "Allan",
                Libro = "Viaje al centro de la tierra",
                Fechas = new DateTime(2009, 05, 06),
                ConfirmacionDL = "no Aprobada"
            };
            DemandaLibreria dem5 = new DemandaLibreria()
            {
                Usuario = "Isabel",
                Libro = "Viaje al centro de la tierra",
                Fechas = new DateTime(2009, 06, 10),
                ConfirmacionDL = "Aprobada"
            };
            DemandaLibreria dem6 = new DemandaLibreria()
            {
                Usuario = "Anthony",
                Libro = "Viaje al centro de la tierra",
                Fechas = new DateTime(2009, 07, 15),
                ConfirmacionDL = "no Aprobada"
            };



            //De la luna a la Tierra
            DemandaLibreria dem7 = new DemandaLibreria()
            {
                Usuario = "Mateo",
                Libro = "De la luna a la Tierra",
                Fechas = new DateTime(2008, 10, 09),
                ConfirmacionDL = "Aprobada"
            };
            DemandaLibreria dem8 = new DemandaLibreria()
            {
                Usuario = "Carlos",
                Libro = "De la luna a la Tierra",
                Fechas = new DateTime(2008, 12, 09),
                ConfirmacionDL = "no Aprobada"
            };




            //Las mil y una Noches
            DemandaLibreria dem9 = new DemandaLibreria()
            {
                Usuario = "Luis",
                Libro = "Las mil y una Noches",
                Fechas = new DateTime(2003, 03, 07),
                ConfirmacionDL = "Aprobada"
            };
            DemandaLibreria dem10 = new DemandaLibreria()
            {
                Usuario = "Federico",
                Libro = "Las mil y una Noches",
                Fechas = new DateTime(2003, 04, 21),
                ConfirmacionDL = "no Aprobada"
            };
            List<DemandaLibreria> ListaDemandaLibreria = new List<DemandaLibreria>()
            {
                //mago de oz
                dem1,dem2,
                //EL principito
                dem3,
                //viaje al centro de la tierra
                dem4,dem5,dem6,
                //de la luna a la tierra
                dem7,dem8,
                //Las mil y una noches
                dem9,dem10
            };










            //InventarioLibro

            //Mago de oz
            InventarioLibro inL1 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 1",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL2 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 2",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL3 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 3",
                EstadoL = "Dañado",
                PrecioL = 10.00M


            };
            InventarioLibro inL4 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 4",
                EstadoL = "Perdido",
                PrecioL = 12.00M


            };
            InventarioLibro inL5 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 5",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL6 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 6",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL7 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 7",
                EstadoL = "Dañado",
                PrecioL = 10.00M


            };
            InventarioLibro inL8 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 8",
                EstadoL = "Perdido",
                PrecioL = 12.00M


            };
            InventarioLibro inL9 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 9",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL10 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 10",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL11 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 11",
                EstadoL = "Dañado",
                PrecioL = 10.00M


            };
            InventarioLibro inL12 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 12",
                EstadoL = "Perdido",
                PrecioL = 12.00M


            };
            InventarioLibro inL13 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 13",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL14 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 14",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL15 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 15",
                EstadoL = "Dañado",
                PrecioL = 10.00M


            };






            //El principito
            InventarioLibro inL16 = new InventarioLibro()
            {
                InventarioL = "El principito 1",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL17 = new InventarioLibro()
            {
                InventarioL = "El principito 2",
                EstadoL = "Regular",
                PrecioL = 17.00M


            };
            InventarioLibro inL18 = new InventarioLibro()
            {
                InventarioL = "El principito 3",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };
            InventarioLibro inL19 = new InventarioLibro()
            {
                InventarioL = "El principito 4",
                EstadoL = "Perdido",
                PrecioL = 17.00M


            };
            InventarioLibro inL20 = new InventarioLibro()
            {
                InventarioL = "El principito 5",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL21 = new InventarioLibro()
            {
                InventarioL = "El principito 6",
                EstadoL = "Regular",
                PrecioL = 17.00M


            };
            InventarioLibro inL22 = new InventarioLibro()
            {
                InventarioL = "El principito 7",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };
            InventarioLibro inL23 = new InventarioLibro()
            {
                InventarioL = "El principito 8",
                EstadoL = "Perdido",
                PrecioL = 17.00M


            };
            InventarioLibro inL24 = new InventarioLibro()
            {
                InventarioL = "El principito 9",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL25 = new InventarioLibro()
            {
                InventarioL = "El principito 10",
                EstadoL = "Regular",
                PrecioL = 17.00M


            };
            InventarioLibro inL26 = new InventarioLibro()
            {
                InventarioL = "El principito 11",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };
            InventarioLibro inL27 = new InventarioLibro()
            {
                InventarioL = "El principito 12",
                EstadoL = "Perdido",
                PrecioL = 17.00M


            };
            InventarioLibro inL28 = new InventarioLibro()
            {
                InventarioL = "El principito 13",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL29 = new InventarioLibro()
            {
                InventarioL = "El principito 14",
                EstadoL = "Regular",
                PrecioL = 17.00M


            };
            InventarioLibro inL30 = new InventarioLibro()
            {
                InventarioL = "El principito 15",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };







            //Viaje al centro de la Tierra
            InventarioLibro inL31 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 1",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL32 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 2",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL33 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 3",
                EstadoL = "Dañado",
                PrecioL = 9.00M


            };
            InventarioLibro inL34 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 4",
                EstadoL = "Perdido",
                PrecioL = 12.00M


            };
            InventarioLibro inL35 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 5",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL36 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 6",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL37 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 7",
                EstadoL = "Dañado",
                PrecioL = 9.00M


            };
            InventarioLibro inL38 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 8",
                EstadoL = "Perdido",
                PrecioL = 12.00M


            };
            InventarioLibro inL39 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 9",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL40 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 10",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL41 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 11",
                EstadoL = "Dañado",
                PrecioL = 9.00M


            };
            InventarioLibro inL42 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 12",
                EstadoL = "Perdido",
                PrecioL = 12.00M


            };
            InventarioLibro inL43 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 13",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL44 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 14",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL45 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 15",
                EstadoL = "Dañado",
                PrecioL = 9.00M


            };
            InventarioLibro inL46 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 16",
                EstadoL = "Perdido",
                PrecioL = 12.00M


            };
            InventarioLibro inL47 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 17",
                EstadoL = "Bueno",
                PrecioL = 15.00M


            };
            InventarioLibro inL48 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 18",
                EstadoL = "Regular",
                PrecioL = 12.00M


            };
            InventarioLibro inL49 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 19",
                EstadoL = "Dañado",
                PrecioL = 9.00M


            };
            InventarioLibro inL50 = new InventarioLibro()
            {
                InventarioL = "Viaje al centro de la Tierra 20",
                EstadoL = "Perdido",
                PrecioL = 12.00M


            };





            //De la Luna a la Tierra
            InventarioLibro inL51 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 1",
                EstadoL = "Bueno",
                PrecioL = 16.00M


            };
            InventarioLibro inL52 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 2",
                EstadoL = "Regular",
                PrecioL = 10.00M


            };
            InventarioLibro inL53 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 3",
                EstadoL = "Dañado",
                PrecioL = 8.00M


            };
            InventarioLibro inL54 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 4",
                EstadoL = "Perdido",
                PrecioL = 10.00M


            };
            InventarioLibro inL55 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 5",
                EstadoL = "Bueno",
                PrecioL = 16.00M


            };
            InventarioLibro inL56 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 6",
                EstadoL = "Regular",
                PrecioL = 10.00M


            };
            InventarioLibro inL57 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 7",
                EstadoL = "Dañado",
                PrecioL = 8.00M


            };
            InventarioLibro inL58 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 8",
                EstadoL = "Perdido",
                PrecioL = 10.00M


            };
            InventarioLibro inL59 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 9",
                EstadoL = "Bueno",
                PrecioL = 16.00M


            };
            InventarioLibro inL60 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 10",
                EstadoL = "Regular",
                PrecioL = 10.00M


            };
            InventarioLibro inL61 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 11",
                EstadoL = "Dañado",
                PrecioL = 8.00M


            };
            InventarioLibro inL62 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 12",
                EstadoL = "Perdido",
                PrecioL = 10.00M


            };
            InventarioLibro inL63 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 13",
                EstadoL = "Bueno",
                PrecioL = 16.00M


            };
            InventarioLibro inL64 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 14",
                EstadoL = "Regular",
                PrecioL = 10.00M


            };
            InventarioLibro inL65 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 15",
                EstadoL = "Dañado",
                PrecioL = 8.00M


            };
            InventarioLibro inL66 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 16",
                EstadoL = "Perdido",
                PrecioL = 10.00M


            };
            InventarioLibro inL67 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 17",
                EstadoL = "Bueno",
                PrecioL = 16.00M


            };
            InventarioLibro inL68 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 18",
                EstadoL = "Regular",
                PrecioL = 10.00M


            };
            InventarioLibro inL69 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 19",
                EstadoL = "Dañado",
                PrecioL = 8.00M


            };
            InventarioLibro inL70 = new InventarioLibro()
            {
                InventarioL = "De la Luna a la Tierra 20",
                EstadoL = "Perdido",
                PrecioL = 10.00M


            };






            //Las mil y una Noches
            InventarioLibro inL71 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 1",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL72 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 2",
                EstadoL = "Regular",
                PrecioL = 18.00M


            };
            InventarioLibro inL73 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 3",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };
            InventarioLibro inL74 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 4",
                EstadoL = "Perdido",
                PrecioL = 18.00M


            };
            InventarioLibro inL75 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 5",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL76 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 6",
                EstadoL = "Regular",
                PrecioL = 18.00M


            };
            InventarioLibro inL77 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 7",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };
            InventarioLibro inL78 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 8",
                EstadoL = "Perdido",
                PrecioL = 18.00M


            };
            InventarioLibro inL79 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 9",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL80 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 10",
                EstadoL = "Regular",
                PrecioL = 18.00M


            };
            InventarioLibro inL81 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 11",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };
            InventarioLibro inL82 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 12",
                EstadoL = "Perdido",
                PrecioL = 18.00M


            };
            InventarioLibro inL83 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 13",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL84 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 14",
                EstadoL = "Regular",
                PrecioL = 18.00M


            };
            InventarioLibro inL85 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 15",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };
            InventarioLibro inL86 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 16",
                EstadoL = "Perdido",
                PrecioL = 18.00M


            };
            InventarioLibro inL87 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 17",
                EstadoL = "Bueno",
                PrecioL = 20.00M


            };
            InventarioLibro inL88 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 18",
                EstadoL = "Regular",
                PrecioL = 18.00M


            };
            InventarioLibro inL89 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 19",
                EstadoL = "Dañado",
                PrecioL = 14.00M


            };
            InventarioLibro inL90 = new InventarioLibro()
            {
                InventarioL = "Las mil y una Noches 20",
                EstadoL = "Perdido",
                PrecioL = 18.00M


            };
            List<InventarioLibro> inventarioLibros = new List<InventarioLibro>()
            {
                //mago de oz
                inL1,inL2,inL3,inL4,inL5,inL6,inL7,inL8,inL9,inL10,inL11,inL12,inL13,inL14,inL15,
                //El principito
                inL16,inL17,inL18,inL19,inL20,inL21,inL22,inL23,inL24,inL25,inL26,inL27,inL28,inL29,inL30,
                //viaje al centro de la tierra
                inL31,inL32,inL33,inL34,inL35,inL36,inL37,inL38,inL39,inL40,inL41,inL42,inL43,inL44,inL45,inL46,inL47,inL48,inL49,inL50,
                //De la luna a la tierra
                inL51,inL52,inL53,inL54,inL55,inL56,inL57,inL58,inL59,inL60,inL61,inL62,inL63,inL64,inL65,inL66,inL67,inL68,inL69,inL70,
                //Las mil y una noche
                inL71,inL72,inL73,inL74,inL75,inL76,inL77,inL78,inL79,inL80,inL81,inL82,inL83,inL84,inL85,inL86,inL87,inL88,inL89,inL90
            };











            //Presupuesto

            // primer libro
            Presupuesto primerLibro = new Presupuesto()
            {
                LibrosP = "mago de oz",
                PrecioP = 15.00M,
                CantidadP = 10,
                DistribuidorP = "Libreria Cientifica",
                Distribuidores = new List<Distribuidores>() { dis1, dis2 },
                DemandaLibrerias = new List<DemandaLibreria>() { dem1, dem2 },
                InventarioLibros = new List<InventarioLibro>() { inL1, inL2, inL3, inL4, inL5, inL6, inL7, inL8, inL9, inL10, inL11, inL12, inL13, inL14, inL15 },
                RegistroLibro = new RegistroLibro()
                {
                    Detalles = "sin ninguna novedad sobre los libros ",
                    FechaIngreso = new DateTime(2022, 01, 05)
                },
                Evaluacion = new Evaluacion()
                {
                    FechaE = new DateTime(2022, 05, 05),
                    Calificaion = "Regular"

                }
                           

            };
            
            
            
            //Segundo libro
            //El principito
            Presupuesto segundoLibro = new Presupuesto()
            {
                LibrosP = "El principito",
                PrecioP = 20.00M,
                CantidadP = 15,
                DistribuidorP = "Cedisa Libros",
                Distribuidores = new List<Distribuidores>() { dis3, dis4, dis5 },
                DemandaLibrerias = new List<DemandaLibreria>() { dem3 },
                InventarioLibros = new List<InventarioLibro>() { inL16, inL17, inL18, inL19, inL20, inL21, inL22, inL23, inL24, inL25, inL26, inL27, inL28, inL29, inL30 },
                RegistroLibro = new RegistroLibro()
                {
                    Detalles = "sin ninguna novedad sobre los libros ",
                    FechaIngreso = new DateTime(2022, 01, 05)
                },
                Evaluacion = new Evaluacion()
                {
                    FechaE = new DateTime(2022, 05, 05),
                    Calificaion = "Regular"

                }


            };



            //tercer libro
            //Viaje al centro de la tierra
            Presupuesto tercerLibro = new Presupuesto()
            {
                LibrosP = "Viaje al centro de la tierra",
                PrecioP = 15.00M,
                CantidadP = 20,
                DistribuidorP = "Mr.books",
                Distribuidores = new List<Distribuidores>() { dis6, dis7 },
                DemandaLibrerias = new List<DemandaLibreria>() { dem4, dem5, dem6 },
                InventarioLibros = new List<InventarioLibro>() { inL31, inL32, inL33, inL34, inL35, inL36, inL37, inL38, inL39, inL40, inL41, inL42, inL43, inL44, inL45, inL46, inL47, inL48, inL49, inL50 },
                RegistroLibro = new RegistroLibro()
                {
                    Detalles = "sin ninguna novedad sobre los libros ",
                    FechaIngreso = new DateTime(2022, 01, 05)
                },
                Evaluacion = new Evaluacion()
                {
                    FechaE = new DateTime(2022, 05, 05),
                    Calificaion = "Regular"

                }


            };




            //cuarto libro
            //De la luna a la tierra
            Presupuesto cuartoLibro = new Presupuesto()
            {
                LibrosP = "De la luna a la tierra",
                PrecioP = 16.00M,
                CantidadP = 20,
                DistribuidorP = "Libreria Española",
                Distribuidores = new List<Distribuidores>() { dis8, dis9 },
                DemandaLibrerias = new List<DemandaLibreria>() { dem7, dem8 },
                InventarioLibros = new List<InventarioLibro>() { inL51, inL52, inL53, inL54, inL55, inL56, inL57, inL58, inL59, inL60, inL61, inL62, inL63, inL64, inL65, inL66, inL67, inL68, inL69, inL70 },
                RegistroLibro = new RegistroLibro()
                {
                    Detalles = "sin ninguna novedad sobre los libros ",
                    FechaIngreso = new DateTime(2022, 01, 05)
                },
                Evaluacion = new Evaluacion()
                {
                    FechaE = new DateTime(2022, 05, 05),
                    Calificaion = "Regular"

                }


            };




            //quinto libro 
            //Las mil y una noche
            Presupuesto quintoLibro = new Presupuesto()
            {
                LibrosP = "Las mil y una noche",
                PrecioP = 20.00M,
                CantidadP = 20,
                DistribuidorP = "Libreria novoLibros",
                Distribuidores = new List<Distribuidores>() { dis10, dis11, dis12 },
                DemandaLibrerias = new List<DemandaLibreria>() { dem9, dem10 },
                InventarioLibros = new List<InventarioLibro>() { inL71, inL72, inL73, inL74, inL75, inL76, inL77, inL78, inL79, inL80, inL81, inL82, inL83, inL84, inL85, inL86, inL87, inL88, inL89, inL90 },
                RegistroLibro = new RegistroLibro()
                {
                    Detalles = "sin ninguna novedad sobre los libros ",
                    FechaIngreso = new DateTime(2022, 01, 05)
                },
                Evaluacion = new Evaluacion()
                {
                    FechaE = new DateTime(2022, 05, 05),
                    Calificaion = "Regular"

                }


            };

            List<Presupuesto> listaPresupuestos = new List<Presupuesto>()
            {
                primerLibro,segundoLibro,tercerLibro,cuartoLibro,quintoLibro
            };




            //inventario

            Inventario inventario1 = new Inventario()
            {
                Pedido= "Pedido 1",
                InicioPedido=new DateTime(2021,01,01),
                LimitePedido=new DateTime(2021,02,01)

            };
            Inventario inventario2 = new Inventario()
            {
                Pedido = "Pedido 2",
                InicioPedido = new DateTime(2021, 03, 01),
                LimitePedido = new DateTime(2021, 04, 01)
            };
            Inventario inventario3 = new Inventario()
            {
                Pedido = "Pedido 3",
                InicioPedido = new DateTime(2021, 05, 01),
                LimitePedido = new DateTime(2021, 06, 01)
            };
            Inventario inventario4 = new Inventario()
            {
                Pedido = "Pedido 4",
                InicioPedido = new DateTime(2021, 07, 01),
                LimitePedido = new DateTime(2021, 08, 01)
            };
            Inventario inventario5 = new Inventario()
            {
                Pedido = "Pedido 5",
                InicioPedido = new DateTime(2021, 09, 01),
                LimitePedido = new DateTime(2021, 10, 01)
            };


            List<Inventario> listaInventarios = new List<Inventario>()
            {
                inventario1, inventario2, inventario3, inventario4, inventario5
            };




            //prerequisito
            //primer libro
            Prerequisito Lib1pre1 = new Prerequisito()
            {
                Inventario= inventario1,
                Presupuesto = primerLibro
            };

            Prerequisito Lib1pre2 = new Prerequisito()
            { 
                Inventario= inventario2,
                Presupuesto= primerLibro
            
            };
            Prerequisito Lib1pre3 = new Prerequisito()
            {
                Inventario = inventario3,
                Presupuesto = primerLibro
            };
            Prerequisito Lib1pre4 = new Prerequisito()
            {
                Inventario = inventario4,
                Presupuesto = primerLibro
            };
            Prerequisito Lib1pre5 = new Prerequisito()
            {
                Inventario = inventario5,
                Presupuesto = primerLibro
            };


            //segundo libro
            Prerequisito Lib2pre1 = new Prerequisito()
            {
                Inventario = inventario1,
                Presupuesto = segundoLibro
            };

            Prerequisito Lib2pre2 = new Prerequisito()
            {
                Inventario = inventario2,
                Presupuesto = segundoLibro

            };
            Prerequisito Lib2pre3 = new Prerequisito()
            {
                Inventario = inventario3,
                Presupuesto = segundoLibro
            };
            Prerequisito Lib2pre4 = new Prerequisito()
            {
                Inventario = inventario4,
                Presupuesto = segundoLibro
            };
            Prerequisito Lib2pre5 = new Prerequisito()
            {
                Inventario = inventario5,
                Presupuesto = segundoLibro
            };



            //tercer libro
            Prerequisito Lib3pre1 = new Prerequisito()
            {
                Inventario = inventario1,
                Presupuesto = tercerLibro
            };

            Prerequisito Lib3pre2 = new Prerequisito()
            {
                Inventario = inventario2,
                Presupuesto = tercerLibro

            };
            Prerequisito Lib3pre3 = new Prerequisito()
            {
                Inventario = inventario3,
                Presupuesto = tercerLibro
            };
            Prerequisito Lib3pre4 = new Prerequisito()
            {
                Inventario = inventario4,
                Presupuesto = tercerLibro
            };
            Prerequisito Lib3pre5 = new Prerequisito()
            {
                Inventario = inventario5,
                Presupuesto = tercerLibro
            };



            //cuarto libro
            Prerequisito Lib4pre1 = new Prerequisito()
            {
                Inventario = inventario1,
                Presupuesto = cuartoLibro
            };

            Prerequisito Lib4pre2 = new Prerequisito()
            {
                Inventario = inventario2,
                Presupuesto = cuartoLibro

            };
            Prerequisito Lib4pre3 = new Prerequisito()
            {
                Inventario = inventario3,
                Presupuesto = cuartoLibro
            };
            Prerequisito Lib4pre4 = new Prerequisito()
            {
                Inventario = inventario4,
                Presupuesto = cuartoLibro
            };
            Prerequisito Lib4pre5 = new Prerequisito()
            {
                Inventario = inventario5,
                Presupuesto = cuartoLibro
            };



            //quinto libro
            Prerequisito Lib5pre1 = new Prerequisito()
            {
                Inventario = inventario1,
                Presupuesto = quintoLibro
            };

            Prerequisito Lib5pre2 = new Prerequisito()
            {
                Inventario = inventario2,
                Presupuesto = quintoLibro

            };
            Prerequisito Lib5pre3 = new Prerequisito()
            {
                Inventario = inventario3,
                Presupuesto = quintoLibro
            };
            Prerequisito Lib5pre4 = new Prerequisito()
            {
                Inventario = inventario4,
                Presupuesto = quintoLibro
            };
            Prerequisito Lib5pre5 = new Prerequisito()
            {
                Inventario = inventario5,
                Presupuesto = quintoLibro
            };



            List<Prerequisito> listaPrerequisitos = new List<Prerequisito>()
            {
                //primerlibro
                Lib1pre1,Lib1pre2,Lib1pre3,Lib1pre4,Lib1pre5,
                //segundolibro
                Lib2pre1,Lib2pre2,Lib2pre3,Lib2pre4,Lib2pre5,
                //tercerlibro
                Lib3pre1,Lib3pre2,Lib3pre3,Lib3pre4,Lib3pre5,
                //cuartolibro
                Lib4pre1,Lib4pre2,Lib4pre3,Lib4pre4,Lib4pre5,
                //quintolibro
                Lib5pre1,Lib5pre2,Lib5pre3,Lib5pre4,Lib5pre5

            };

            //diccionario contiene todas las tablas
            Dictionary<ListaTipo, object> dicListasDatos = new Dictionary<ListaTipo, object>()
            {
                { ListaTipo.Prerequisitos, listaPrerequisitos },
                {ListaTipo.Iventarios,listaInventarios },
                {ListaTipo.Presupuestos,listaPresupuestos }

            };



            return dicListasDatos;
        }
    }
}
