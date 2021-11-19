using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDBLibrary;

namespace SimpleDataApp

{
    public partial class addECCO_ATTR : Form
    {
        private accessDB db;
        private const string ECCO_ATTR = "ECO_ATTR";
        private List<ToolTip> listToolTips = new List<ToolTip>( );

        public addECCO_ATTR( accessDB _db )
        {
            if (_db is null)
            {
                throw new ArgumentNullException( nameof( _db ) );
            }

            InitializeComponent( );
            this.db = _db;
            InitToolTip( );
            InitComboBox( );
            dtpDATA.Value = DateTime.Now;
        }

        private void InitComboBox( )
        {
            FillComboBox(cbCODE,"CODE" );
            FillComboBox(cbDIVI,"DIVI" );
            FillComboBox(cbCREATOR,"CREATOR" );
            FillComboBox(cbFIRM,"FIRM" );
        }

        /// <summary>
        /// Заполнение списка комбобокс уникальными 
        /// значениями именновоного столбца
        /// </summary>
        /// <param name="_cb"></param>
        /// <param name="_nameColomn"></param>
        private void FillComboBox(ComboBox _cb , string _nameColomn)
        {
            string defaultValue = "<Пусто>";
            //Хеш таблица для удаления дублежей данных
            HashSet<string> resultList = new HashSet<string>( );

            foreach (var item in db.accessDataSet.Tables[ ECCO_ATTR ].Rows)
            {
                resultList.Add( (item as DataRow)[ _nameColomn ].ToString( ) );
            }
            _cb.Items.Add( defaultValue );
            _cb.Items.AddRange( resultList.OrderBy( p => p ).ToArray( ) );
            _cb.SelectedIndex = 0;
        }

        private void btnAdd_Click( object sender, EventArgs e )
        {
            db.addRowInTable( ECCO_ATTR,
                               new Dictionary<string, string>( ) {
                                    {"DIVI", cbDIVI.Text},
                                    {"VYPD", tbVYPD.Text},
                                    {"CREATED", dtpDATA.Value.ToShortDateString()},
                                    {"NKIT", tbNKIT.Text},
                                    {"FIRM", cbFIRM.Text},
                                    {"CODE", cbCODE.Text},
                                    {"NUMB", tbNUMB.Text},
                                    {"CKIT", tbCKIT.Text}
                               } );
            
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
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
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

        private void InitToolTip( )
        {
            //
            List<string> PopUpStrings = new List<string>
            {
                "Иванов В.В.",
                "CKIT",
                "NKIT",
                "VIPD",
                "DIVI",
                "ШИВА",
                "123456",
                "789"
            };
            
            foreach (var item in db.accessDataSet.Tables[ ECCO_ATTR ].Columns)
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
                    listToolTips[ index].SetToolTip((item as TextBox), $"{PopUpStrings[index++]}") ;
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
