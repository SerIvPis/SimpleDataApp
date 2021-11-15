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
        // Датасет уровня формы
        private DataSet accessDataSet ;

        // Построители команд уровня формы
        private OleDbCommandBuilder oleDbREGISTRY;

        // Адаптеры данных (для каждой таблицы)
        private OleDbDataAdapter registryTableAdapter;

        // Строка соединения уровня формы
        private string connectString;
        
        public addREGISTRY( )
        {
            InitializeComponent( );
            dtpDATA.Value = DateTime.Now;
        }

        //Передача данных формы Navigation через контструктор
        public addREGISTRY( DataSet _accessDataSet,
                           OleDbDataAdapter _registryTableAdapter,
                           string _connectString )
        {
            if (_accessDataSet is null)
            {
                throw new ArgumentNullException( nameof( _accessDataSet ) );
            }

            if (_registryTableAdapter is null)
            {
                throw new ArgumentNullException( nameof( _registryTableAdapter ) );
            }

            if (string.IsNullOrEmpty( _connectString ))
            {
                throw new ArgumentException( $"'{nameof( _connectString )}' cannot be null or empty.", nameof( _connectString ) );
            }
            InitializeComponent( );
            dtpDATA.Value = DateTime.Now;
            this.accessDataSet = _accessDataSet;
            this.registryTableAdapter = _registryTableAdapter;
            this.connectString = _connectString;

            //TODO: Передача данных между главное и вторичной формой. Альтернатива static полям формы
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
            OleDbConnection connect = new OleDbConnection( connectString );
            OleDbCommand cmd = new OleDbCommand( "INSERT INTO REGISTRY" +
                "(NAIM, INDE, DESI, DATA, PRIM, FIRM, CODE, NUMB)" +
                " Values (?, ?, ?, ?, ?, ?, ?, ?)", connect );
               

            //объявляем объект класса OleDbParameter и добавляем к команде cmd

            CreateParameterString(  cmd, "@NAIM", tbNaim.Text, OleDbType.LongVarChar );
            CreateParameterString(  cmd, "@INDE", tbINDE.Text, OleDbType.LongVarChar );
            CreateParameterString(  cmd, "@DESI", tbDESI.Text, OleDbType.LongVarChar );
            CreateParameterString(  cmd, "@DATA", dtpDATA.Value.ToShortDateString(), OleDbType.LongVarChar );
            CreateParameterString(  cmd, "@PRIM", tbPRIM.Text, OleDbType.LongVarChar );
            CreateParameterString(  cmd, "@FIRM", tbFIRM.Text, OleDbType.LongVarChar );
            CreateParameterString(  cmd, "@CODE", tbCODE.Text, OleDbType.LongVarChar );
            CreateParameterString(  cmd, "@NUMB", tbNUMB.Text, OleDbType.LongVarChar );

            using (connect)
            {
                try
                {
                    connect.Open( );
                    cmd.ExecuteNonQuery( );
                    connect.Close( );
            }
                catch (OleDbException oe)
                {
                    MessageBox.Show( $"Ошибка вставки в таблицу REGISTRY: {oe.Message}" );
                    throw;
                }

            }
           

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
    }
}
