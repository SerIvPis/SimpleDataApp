using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MDBLibrary;

namespace SimpleDataApp
{
    public partial class Navigation : Form
    {
        private accessDB db;

        public Navigation( )
        {
            InitializeComponent( );
        }

        public Navigation( accessDB _db )
        {
            InitializeComponent( );
            this.db = _db;
        }

        private void btnGoToFillorCancel_Click( object sender, EventArgs e )
        {
            switch (cbxSelectTableForView.SelectedIndex)
            {
                case 0:
                    {
                        new addREGISTRY( db ).Show( );
                        break;
                    }
                case 1:
                    {
                        new addECCO_ATTR( db ).Show( );
                        break;
                    }
                case 2:
                    {
                        new addECCO_CONT( db ).Show( );
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        private void btnConnect_Click( object sender, EventArgs e )
        {
            try
            {
                db.Reload( );
                //Подсоединить DataSet к GridDataView
                dgvCommon.DataSource = db.accessDataSet;

                //Заполнить combobox списком имен таблиц DataSet 
                InitComboBox( db.accessDataSet );
            }
            catch (OleDbException ex)
            {
                MessageBox.Show( $"Ошибка подключения: {ex.Message}" );
            }
        }

        private void InitComboBox( DataSet ds )
        {
            cbxSelectTableForView.Items.Clear( );
            cbxSelectTableForView.Items.AddRange( new string[] {
                ds.Tables[0].TableName,//REGISTRY
                ds.Tables[1].TableName,//ECO_ATTR
                ds.Tables[2].TableName,//ECO_CONT
            } );
            cbxSelectTableForView.SelectedIndex = 0;
        }

        private void cbxSelectTableForView_SelectionChangeCommitted( object sender, EventArgs e )
        {
            //dgvCommon.DataMember = cbxSelectTableForView.SelectedItem.ToString( );
        }

        private void checkBox1_CheckStateChanged( object sender, EventArgs e )
        {
            dgvCommon.ReadOnly = !cbEdit.Checked;
        }

        private void btnForward_Click( object sender, EventArgs e )
        {
           
        }

        private void cbxSelectTableForView_SelectedIndexChanged( object sender, EventArgs e )
        {
            dgvCommon.DataMember = cbxSelectTableForView.SelectedItem.ToString( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            dataGridView1.DataSource = ConvertExcelToDataTableGroupSubGroup( @"d:\test.xlsx" );
        }
        public static DataTable ConvertExcelToDataTableGroupSubGroup( string FileName )
        {

            DataTable dtResult = null;
            int totalSheet = 0; //No of sheets on excel file  
            using (OleDbConnection objConn = new OleDbConnection( "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';" ))
            {
                DataSet excelDs = new DataSet("Excel File");
                DataTable dt = null;
                OleDbDataAdapter excelAdapter = new OleDbDataAdapter( );

                objConn.Open( );
               
                dt = objConn.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );
                foreach (DataRow item in dt.Rows)
                {
                    MessageBox.Show( $"{item[ "TABLE_NAME" ].ToString( )}" );
                }
                OleDbCommand cmd = new OleDbCommand( );
                
                
                //DataTable dt = objConn.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );
                //string sheetName = string.Empty;
                //if (dt != null)
                //{
                //    var tempDataTable = (from dataRow in dt.AsEnumerable( )
                //                         where !dataRow[ "TABLE_NAME" ].ToString( ).Contains( "FilterDatabase" )
                //                         select dataRow).CopyToDataTable( );
                //    dt = tempDataTable;
                //    totalSheet = dt.Rows.Count;

                //    // Sheet from first index
                //    sheetName = dt.Rows[ 1 ][ "TABLE_NAME" ].ToString( );
                //}
                //cmd.Connection = objConn;
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                //oleda = new OleDbDataAdapter( cmd );
                //oleda.Fill( ds, "excelData" );
                //dtResult = ds.Tables[ "excelData" ];
                //objConn.Close( );
                return dtResult; //Returning Dattable  
            }
        }

        static DataSet Parse( string fileName )
        {
            string connectionString = string.Format( "provider=Microsoft.Jet.OLEDB.4.0; data source={0};Extended Properties=Excel 8.0;", fileName );


            DataSet data = new DataSet( );

            foreach (var sheetName in GetExcelSheetNames( connectionString ))
            {
                using (OleDbConnection con = new OleDbConnection( connectionString ))
                {
                    var dataTable = new DataTable( );
                    string query = string.Format( "SELECT * FROM [{0}]", sheetName );
                    con.Open( );
                    OleDbDataAdapter adapter = new OleDbDataAdapter( query, con );
                    adapter.Fill( dataTable );
                    data.Tables.Add( dataTable );
                }
            }

            return data;
        }

        static string[] GetExcelSheetNames( string connectionString )
        {
            OleDbConnection con = null;
            DataTable dt = null;
            con = new OleDbConnection( connectionString );
            con.Open( );
            dt = con.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );

            if (dt == null)
            {
                return null;
            }

            String[] excelSheetNames = new String[ dt.Rows.Count ];
            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                excelSheetNames[ i ] = row[ "TABLE_NAME" ].ToString( );
                i++;
            }

            return excelSheetNames;
        }
    }
}
