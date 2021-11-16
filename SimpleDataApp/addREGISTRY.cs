using MDBLibrary;
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

namespace SimpleDataApp
{
    public partial class addREGISTRY : Form
    {
        private accessDB db;
        
        public addREGISTRY( )
        {
            InitializeComponent( );
            ttCODE.SetToolTip( tbCODE, "Поле CODE" );
            ttDESI.SetToolTip( tbDESI, "Поле DESI" );
            ttFIRM.SetToolTip( tbFIRM, "Поле FIRM" );
            ttINDE.SetToolTip( tbCODE, "Поле INDE" );
            ttNUMB.SetToolTip( tbNUMB, "Поле NUMB" );
            ttPRIM.SetToolTip( tbPRIM, "Поле PRIM" );
            dtpDATA.Value = DateTime.Now;
        }

        //Передача данных формы Navigation через контструктор
        public addREGISTRY( accessDB _db )
        {
            if (_db is null)
            {
                throw new ArgumentNullException( nameof( _db ) );
            }

            InitializeComponent( );
            dtpDATA.Value = DateTime.Now;
            db = _db;
        }

        private void btnClear_Click( object sender, EventArgs e )
        {
            foreach (var item in gpTemplet.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear( );
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
            foreach (var item in gpDesi.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear( );
                }
            }
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        private void btnAddRow_Click( object sender, EventArgs e )
        {
            #region MyRegion
            /*//OleDbConnection connect = new OleDbConnection( connectString );
            OleDbCommand cmd = new OleDbCommand( "INSERT INTO REGISTRY" +
                "(NAIM, INDE, DESI, DATA, PRIM, FIRM, CODE, NUMB)" +
                " Values (?, ?, ?, ?, ?, ?, ?, ?)", db.connect );


            //объявляем объект класса OleDbParameter и добавляем к команде cmd

            CreateParameterString( cmd, "@NAIM", tbNaim.Text, OleDbType.LongVarChar );
            CreateParameterString( cmd, "@INDE", tbINDE.Text, OleDbType.LongVarChar );
            CreateParameterString( cmd, "@DESI", tbDESI.Text, OleDbType.LongVarChar );
            CreateParameterString( cmd, "@DATA", dtpDATA.Value.ToShortDateString( ), OleDbType.LongVarChar );
            CreateParameterString( cmd, "@PRIM", tbPRIM.Text, OleDbType.LongVarChar );
            CreateParameterString( cmd, "@FIRM", tbFIRM.Text, OleDbType.LongVarChar );
            CreateParameterString( cmd, "@CODE", tbCODE.Text, OleDbType.LongVarChar );
            CreateParameterString( cmd, "@NUMB", tbNUMB.Text, OleDbType.LongVarChar );

            using (db.connect)
            {
                try
                {
                    db.connect.Open( );
                    cmd.ExecuteNonQuery( );
                    db.connect.Close( );
                }
                catch (OleDbException oe)
                {
                    MessageBox.Show( $"Ошибка вставки в таблицу REGISTRY: {oe.Message}" );
                    throw;
                }

            }*/
            #endregion

            db.addRowInTable( "REGISTRY",
                                new Dictionary<string, string>( ) {
                                    {"NAIM", tbNaim.Text},
                                    {"INDE", tbINDE.Text},
                                    {"DESI", tbDESI.Text},
                                    {"DATA", dtpDATA.Value.ToShortDateString()},
                                    {"PRIM", tbPRIM.Text},
                                    {"FIRM", tbFIRM.Text},
                                    {"CODE", tbCODE.Text},
                                    {"NUMB", tbNUMB.Text}
                                } );
        }

        /// <summary>
        /// Создание строкового параметра и присоединение к команде
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="_name"></param>
        /// <param name="_value"></param>
        /// <param name="_oleType"></param>
        private void CreateParameterString( OleDbCommand cmd, string _name, string _value, OleDbType _oleType  )
        {
            OleDbParameter param = new OleDbParameter( );
            //задаем имя параметра
            param.ParameterName = _name;
            //задаем значение параметра
            param.Value = _value;
            //задаем тип параметра
            param.OleDbType = _oleType;
            //передаем параметр объекту класса SqlCommand
            cmd.Parameters.Add( param );
        }

        private void contextMenuStrip1_Opening( object sender, CancelEventArgs e )
        {

        }

        private void addREGISTRY_Load( object sender, EventArgs e )
        {
           
        }

        private void ttNUMB_Popup( object sender, PopupEventArgs e )
        {

        }
    }
}
