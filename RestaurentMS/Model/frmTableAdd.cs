﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentMS.Model
{
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)  //Insert
            {
                qry = "Insert into tables Values(@Name)";
            }
            else //Update
            {
                qry = "Update tables Set tName = @Name where tID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully..");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }
    }
}
