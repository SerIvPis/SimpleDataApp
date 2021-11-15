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
        public addREGISTRY( )
        {
            InitializeComponent( );
            dateTimePicker1.Value = DateTime.Now;
        }

        public addREGISTRY( DataSet accessDataSet, OleDbDataAdapter registryTableAdapter, string connectString)
        {
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

        private void button1_Click( object sender, EventArgs e )
        {
            OleDbCommand cmd = new OleDbCommand( "Insert into REGISTRY" +
                "(NAIM, INDE, DESI, DATA, PRIM, FIRM, CODE, NUMB)" +
                " Values (@ID,@FIO,@Grupa)", new OleDbConnection( Navigation.connectString) );
            //объявляем объект класса SqlParameter
            SqlParameter param = new SqlParameter( );
            //задаем имя параметра
            param.ParameterName = "@ID";
            //задаем значение параметра
            param.Value = 10;
            //задаем тип параметра
            param.SqlDbType = SqlDbType.Int;
            //передаем параметр объекту класса SqlCommand
            cmd.Parameters.Add( param );
            //переопределяем объект класса SqlParameter
            param = new SqlParameter( );
            //задаем имя параметра
            param.ParameterName = "@FIO";
            //задаем значение параметра
            param.Value = "Иванов Иван Иванович";
            //задаем тип параметра
            param.SqlDbType = SqlDbType.Text;
            //передаем параметр объекту класса SqlCommand
            cmd.Parameters.Add( param );
            //переопределяем объект класса SqlParameter
            param = new SqlParameter( );
            //задаем имя параметра
            param.ParameterName = "@Grupa";
            //задаем значение параметра
            param.Value = "4-2";
            //задаем тип параметра
            param.SqlDbType = SqlDbType.Text;
            //передаем параметр объекту класса SqlCommand
            cmd.Parameters.Add( param );
            Console.WriteLine( "Вставляем запись" );
            try
            {
                cmd.ExecuteNonQuery( );
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
