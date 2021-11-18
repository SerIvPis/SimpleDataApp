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
        private const string REGISTRY = "REGISTRY";
        private List<ToolTip> listToolTips = new List<ToolTip>( );

        public addREGISTRY( )
        {
            InitializeComponent( );
        }

        //Передача данных формы Navigation через контструктор
        public addREGISTRY( accessDB _db )
        {
            if (_db is null)
            {
                throw new ArgumentNullException( nameof( _db ) );
            }

            InitializeComponent( );
            db = _db;
            InitToolTip( );
            InitComboBox( );
            dtpDATA.Value = DateTime.Now;
            
        }

        private void InitComboBox( )
        {
            //Хеш таблица для удаления дублежей данных
            HashSet<string> resultList = new HashSet<string>( );

            //Запоняем DESI
            foreach (var item in db.accessDataSet.Tables[ 0 ].Rows)
            {
                resultList.Add((item as DataRow)[ "DESI" ].ToString());
            }
            cbDESI.Items.AddRange( resultList.OrderBy(p=>p).ToArray( ) );
            cbDESI.SelectedIndex = 1;


            //Запоняем INDE
            resultList.Clear( );
            foreach (var item in db.accessDataSet.Tables[ 0 ].Rows)
            {
                resultList.Add( (item as DataRow)[ "INDE" ].ToString( ) );
            }
            cbINDE.Items.AddRange( resultList.OrderBy( p => p ).ToArray( ) );
            cbINDE.SelectedIndex = 1;


            //Запоняем FIRM
            resultList.Clear( );
            foreach (var item in db.accessDataSet.Tables[ 0 ].Rows)
            {
                resultList.Add( (item as DataRow)[ "FIRM" ].ToString( ) );
            }
            cbFIRM.Items.AddRange( resultList.OrderBy( p => p ).ToArray( ) );
            cbFIRM.SelectedIndex = 1;


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
            db.addRowInTable( REGISTRY,
                                new Dictionary<string, string>( ) {
                                    {"NAIM", tbNaim.Text},
                                    {"INDE", cbINDE.Text},
                                    //{"INDE", tbINDE.Text},
                                    {"DESI", cbDESI.Text},
                                    //{"DESI", tbDESI.Text},
                                    {"DATA", dtpDATA.Value.ToShortDateString()},
                                    {"PRIM", tbPRIM.Text},
                                    {"FIRM", cbFIRM.Text},
                                    //{"FIRM", tbFIRM.Text},
                                    {"CODE", tbCODE.Text},
                                    {"NUMB", tbNUMB.Text}
                                } );
        }

        private void InitToolTip( )
        {
            //Список подсказок
            List<string> PopUpStrings = new List<string>
            {
                "Краткое пояснение",
                "Иванов",
                "ШРС-С",
                "Кабель",
                "ШИВА",
                "789",
                "123456"
            };

            foreach (var item in db.accessDataSet.Tables[ REGISTRY ].Columns)
            {
                ToolTip ttCurrent = new ToolTip( this.components );
                ttCurrent.InitialDelay = 100;
                ttCurrent.AutoPopDelay = 10000;
                ttCurrent.ReshowDelay = 100;
                ttCurrent.ShowAlways = true;
                ttCurrent.ToolTipTitle = "Пример:";
                listToolTips.Add( ttCurrent );
            }

            int index = 0;
            foreach (var item in gpTemplet.Controls)
            {
                if (item is TextBox)
                {
                    listToolTips[ index ].SetToolTip( (item as TextBox), $"{PopUpStrings[ index++ ]}" );
                }
            }
            foreach (var item in gpDesi.Controls)
            {
                if (item is TextBox)
                {
                    listToolTips[ index ].SetToolTip( (item as TextBox), $"{PopUpStrings[ index++ ]}" );
                }
            }

        }
    }
}
