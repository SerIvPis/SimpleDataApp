using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MDBLibrary;
using System.Configuration;


namespace SimpleDataApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            accessDB db = new accessDB( ConfigurationManager.ConnectionStrings[ "OleDbWork" ].ConnectionString );
            //accessDB db = new accessDB( ConfigurationManager.ConnectionStrings[ "OleDb" ].ConnectionString );

            Application.Run( new Navigation( db ) );
        }

    }
}
