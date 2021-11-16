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

        public addECCO_ATTR( accessDB _db )
        {
            InitializeComponent( );
            this.db = _db;
        }
    }
}
