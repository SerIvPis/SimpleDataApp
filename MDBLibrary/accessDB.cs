using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Text;

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
            connectString = _connectString ?? throw new ArgumentNullException( nameof( _connectString ) );
            connect = new OleDbConnection( _connectString );
            accessDataSet = new DataSet( "MDB" );
            //Создать адаптеры
            InitTableAdapter( );
            //Заполнить данными таблицы в DataSet
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
            registryTableAdapter = new OleDbDataAdapter( "Select NAIM, INDE, DESI, DATA, PRIM, FIRM, CODE, NUMB From REGISTRY", connectString ); 
            eco_attrTableAdapter = new OleDbDataAdapter( "Select FIRM, DIVI, VYPD, CODE, NUMB, NKIT, CKIT, CREATED, CREATOR From ECO_ATTR", connectString );
            eco_contTableAdapter = new OleDbDataAdapter( "Select OBOZ, IZME From ECO_CONT", connectString );
        }

        //Перезагрузка данных из БД
        public void Reload( )
        {
            //Создать адаптеры
            InitTableAdapter( );
            //Заполнить данными таблицы в DataSet
            FillDataSet( );
        }

        //Метод добавляет строку в заданную таблицу
        public void addRowInTable(string tableName, Dictionary<string, string> keyValues  )
        {
            
            OleDbCommand cmd = new OleDbCommand( CreateSqlString( tableName, keyValues ), connect );

            //объявляем объект класса OleDbParameter и добавляем к команде cmd
            foreach (var item in keyValues.ToList())
            {
                CreateParameterString( cmd, $"@{item.Key}", item.Value, OleDbType.LongVarChar );
            }
          
            try
            {
                connect.Open( );
                cmd.ExecuteNonQuery( );
            }
            catch (OleDbException oe)
            {
                //MessageBox.Show( $"Ошибка вставки в таблицу REGISTRY: {oe.Message}" );
                throw;
            }
            finally
            {
                connect.Close( );
            }

        }

         
        /// <summary>
        /// Сгенерировать строку запроса sql 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        private string CreateSqlString( string tableName, Dictionary<string, string> keyValues )
        {
            //("INSERT INTO REGISTRY" +
            //    "(NAIM, INDE, DESI, DATA, PRIM, FIRM, CODE, NUMB)" +
            //    " Values (?, ?, ?, ?, ?, ?, ?, ?)

           // "INSERT INTO REGISTRY  (NAIM,INDE,DESI,DATA,PRIM,FIRM,CODE,NUMB) Values(?,?,?,?,?,?,?,?)"
            StringBuilder strBilder = new StringBuilder( $"INSERT INTO {tableName}  (" );
            foreach (string key in keyValues.Keys)
            {
                strBilder.Append( $"{key}" );
                if (key != keyValues.Keys.Last<string>())
                {
                    strBilder.Append( ", " );
                }
            }
            //strBilder.Remove( strBilder.ToString().Length-1 , 1 );
            strBilder.Append( ")" );
            strBilder.Append( " Values(" );

            foreach (string key in keyValues.Keys)
            {
                strBilder.Append( $"?" );
                if (key != keyValues.Keys.Last<string>( ))
                {
                    strBilder.Append( ", " );
                }
            }
            //strBilder.Remove( strBilder.Length - 1, 1 );
            strBilder.Append( ")" );

            return strBilder.ToString();
        }

      

        /// <summary>
        /// Создание строкового параметра и присоединение к команде
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="_name"></param>
        /// <param name="_value"></param>
        /// <param name="_oleType"></param>
        private void CreateParameterString( OleDbCommand cmd, string _name, string _value, OleDbType _oleType )
        {
            if (cmd == null)
            {
                throw new ArgumentNullException( nameof( cmd ) );
            }

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
