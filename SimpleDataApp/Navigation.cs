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
                throw;
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
            dgvCommon.DataMember = cbxSelectTableForView.SelectedItem.ToString( );
        }

        private void checkBox1_CheckStateChanged( object sender, EventArgs e )
        {
            dgvCommon.ReadOnly = !cbEdit.Checked;
        }

        private void btnForward_Click( object sender, EventArgs e )
        {
           
        }
    }
}
