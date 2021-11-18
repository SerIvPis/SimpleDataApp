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
    public partial class addECCO_CONT : Form
    {
        private accessDB db;
        private const string ECCO_CONT = "ECO_CONT";
        private List<ToolTip> listToolTips = new List<ToolTip>( );


        public addECCO_CONT( accessDB _db )
        {
			if (_db is null)
            {
                throw new ArgumentNullException( nameof( _db ) );
            }

            InitializeComponent( );
            this.db = _db;
            InitToolTip( );
        }

        private void btnAddRow_Click( object sender, EventArgs e )
        {
            db.addRowInTable( ECCO_CONT,
                                new Dictionary<string, string>( ) {
                                    {"IZME", tbIZME.Text},
                                    {"OBOZ", tbOBOZ.Text},
                                    {"NOW", dtpDATA.Value.ToShortDateString()},
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
                "1",
                "АБВГ.123456.789 КОД"
            };

            foreach (var item in db.accessDataSet.Tables[ ECCO_CONT ].Columns)
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
            //foreach (var item in gpDesi.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        listToolTips[ index ].SetToolTip( (item as TextBox), $"{PopUpStrings[ index++ ]}" );
            //    }
            //}
        }
    }
}
