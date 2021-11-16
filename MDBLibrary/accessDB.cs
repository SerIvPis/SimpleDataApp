using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace MDBLibrary
{
    public class accessDB
    {
        public OleDbConnection connect { get; private set; }
        public DataSet accessDataSet { get; private set; }
        public OleDbCommandBuilder oleDbREGISTRY { get; set; }
        public OleDbCommandBuilder oleDbECO_ATTR { get; set; }
        public OleDbCommandBuilder oleDbECO_CONT { get; set; }
        public OleDbDataAdapter registryTableAdapter { get; private set; }
        public OleDbDataAdapter eco_attrTableAdapter { get; private set; }
        public OleDbDataAdapter eco_contTableAdapter { get; private set; }
        public string connectString { get; private set; }

        public accessDB( )
        {

        }

        public accessDB( string _connectString )
        {
            connect = new OleDbConnection( _connectString );
            accessDataSet = new DataSet( "MDB" );
            //Создать адаптеры
            InitTableAdapter( );
            //Заполнить данными DataSet
            FillDataSet( );
        }

        private void FillDataSet( )
        {
            accessDataSet.Clear( );
            //projsTableAdapter.Fill( accessDataSet, "PROJS" );
            registryTableAdapter.Fill( accessDataSet, "REGISTRY" );
            eco_attrTableAdapter.Fill( accessDataSet, "ECO_ATTR" );
            eco_contTableAdapter.Fill( accessDataSet, "ECO_CONT" );
        }

        private void InitTableAdapter( )
        {
            //projsTableAdapter = new OleDbDataAdapter( "Select * From PROJS", connectString );
            registryTableAdapter = new OleDbDataAdapter( "Select NAIM, INDE, DESI, DATA, PRIM, FIRM, CODE, NUMB From REGISTRY", connectString ); /*"SELECT CustomerID, CompanyName FROM Customers "*/
            eco_attrTableAdapter = new OleDbDataAdapter( "Select FIRM, DIVI, VYPD, CODE, NUMB, NKIT, CKIT, CREATED, CREATOR From ECO_ATTR", connectString );
            eco_contTableAdapter = new OleDbDataAdapter( "Select OBOZ, IZME From ECO_CONT", connectString );
        }
    }

    
}
