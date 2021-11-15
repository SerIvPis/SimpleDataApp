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

namespace SimpleDataApp
{
    public partial class Navigation : Form
    {
        // Датасет уровня формы
        public DataSet accessDataSet = new DataSet( "MDB" );

        // Построители команд уровня формы
        public OleDbCommandBuilder oleDbPROJS;
        public OleDbCommandBuilder oleDbREGISTRY;
        public OleDbCommandBuilder oleDbECO_ATTR;
        public OleDbCommandBuilder oleDbECO_CONT;

        // Адаптеры данных (для каждой таблицы)
        public OleDbDataAdapter projsTableAdapter;
        public OleDbDataAdapter registryTableAdapter;
        public OleDbDataAdapter eco_attrTableAdapter;
        public OleDbDataAdapter eco_contTableAdapter;

        // Строка соединения уровня формы
        public string connectString ;


        public Navigation( )
        {
            InitializeComponent( );
        }

        private void btnGoToFillorCancel_Click( object sender, EventArgs e )
        {
              new addREGISTRY( ).Show();
            
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        private void btnConnect_Click( object sender, EventArgs e )
        {
            // Создать строку подсоединения
            connectString = ConfigurationManager.ConnectionStrings[ "OleDb" ].ConnectionString;
            if (connectString != null)
            {
                try
                {
                    //Создать адаптеры
                    InitTableAdapter( );

                    //Заполнить данными DataSet
                    FillDataSet( );

                    //Подсоединить DataSet к GridDataView
                    dgvCommon.DataSource = accessDataSet;

                    //Заполнить combobox списком имен таблиц DataSet 
                    InitComboBox( );
                    


                    /*
                        DataSet ds = new DataSet( "MDB" );
                        OleDbDataAdapter adapter = new OleDbDataAdapter( "Select * From PROJS", connectString );
                        OleDbCommandBuilder comBuilder = new OleDbCommandBuilder( adapter );
                        
                        int count = adapter.Fill( ds, "PROJS" );
                        dgvCommon.DataSource = ds.Tables[ "PROJS" ];

                        // Create the SelectCommand.
                        OleDbCommand command = new OleDbCommand( "SELECT CustomerID FROM Customers " +
                            "WHERE Country = ? AND City = ?"  );

                        command.Parameters.Add( "Country", OleDbType.VarChar, 15 );
                        command.Parameters.Add( "City", OleDbType.VarChar, 15 );

                        adapter.InsertCommand = command;
                        //MessageBox.Show( count.ToString() );

                    */
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show( $"Ошибка подключения: {ex.Message}" );
                    throw;
                }
            }
        }

        private void InitComboBox( )
        {
            cbxSelectTableForView.Items.AddRange( new string[] { accessDataSet.Tables[0].TableName,
                accessDataSet.Tables[1].TableName,
                accessDataSet.Tables[2].TableName,
                accessDataSet.Tables[3].TableName
            } );
            cbxSelectTableForView.SelectedIndex = 0;
        }

        private void FillDataSet( )
        {
            projsTableAdapter.Fill( accessDataSet, "PROJS" );
            registryTableAdapter.Fill( accessDataSet, "REGISTRY" );
            eco_attrTableAdapter.Fill( accessDataSet, "ECO_ATTR" );
            eco_contTableAdapter.Fill( accessDataSet, "ECO_CONT" );
        }

        private void InitTableAdapter( )
        {
            projsTableAdapter = new OleDbDataAdapter( "Select * From PROJS", connectString );
            registryTableAdapter = new OleDbDataAdapter( "Select * From REGISTRY", connectString );
            eco_attrTableAdapter = new OleDbDataAdapter( "Select * From ECO_ATTR", connectString );
            eco_contTableAdapter = new OleDbDataAdapter( "Select * From ECO_CONT", connectString );
        }

        private void cbxSelectTableForView_SelectionChangeCommitted( object sender, EventArgs e )
        {
            dgvCommon.DataMember = cbxSelectTableForView.SelectedItem.ToString( );
        }
    }
}
