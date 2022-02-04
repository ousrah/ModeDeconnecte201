using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ModeDeconnecte201
{
    static class db
    {
        public static SqlConnection cn = new SqlConnection();
        public static DataSet ds = new DataSet();

        public static SqlCommand com = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static SqlCommandBuilder cb;
        public static void ouvrirConnection()
        {
            if (cn.State != ConnectionState.Open)
            {
                string cs = ConfigurationManager.ConnectionStrings["CabinetMedecinConnectionString"].ConnectionString;
                cn.ConnectionString = cs;
                cn.Open();
            }
        }

        public static void fermerConnection()
        {
            if (cn.State != ConnectionState.Closed)
                cn.Close();
        }

        public static BindingSource remplirListe(string table)
        {
            return remplirListe("select * from " + table, table);
        }
 public static BindingSource remplirListe(string req, string table)
        {
            creerTable(req, table);

            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            bs.DataMember = table;
            return bs;

        }

        public static void creerTable(string table)
        {
            creerTable("select * from " + table, table);
        }
            public static void creerTable(string req, string table)
        {
            ouvrirConnection();
            com.Connection = cn;
            com.CommandText = req;

            da.SelectCommand = com;

            if (ds.Tables.Contains(table))
            {
                ds.EnforceConstraints = false;
                ds.Tables[table].Clear();
            }
            da.Fill(ds, table);
            ds.EnforceConstraints = true;
        }

        public static BindingSource remplirListeRelation(string table, BindingSource bsP, string pk, string fk)
        {
            return remplirListeRelation("select * from " + table, table, bsP, pk, fk);
        }

        public static BindingSource remplirListeRelation(string req, string table, BindingSource bsP, string pk, string fk)
        {
            creerTable(req, table);
            creerRelation(bsP.DataMember, table, pk, fk);
            BindingSource bs = new BindingSource();
            bs.DataSource = bsP;
            bs.DataMember = "fk_" + table + "_" + bsP.DataMember;
            return bs;

        }

        public static void creerRelation(string tableP, string tableF, string pk, string fk)
        {
            DataColumn colPK = ds.Tables[tableP].Columns[pk];
            DataColumn colFK = ds.Tables[tableF].Columns[fk];
            string nomRelation = "fk_" + tableF + "_" + tableP;
            DataRelation rel = new DataRelation(nomRelation, colPK, colFK);
       //     rel.ChildKeyConstraint.DeleteRule = Rule.Cascade;
       //     rel.ChildKeyConstraint.UpdateRule = Rule.Cascade;

            if (!ds.Relations.Contains(nomRelation))
                        ds.Relations.Add(rel);
       }

        public static void MiseAjour(string table)
        {
            ouvrirConnection();
            com = new SqlCommand("select * from " + table, cn);
            da = new SqlDataAdapter(com);
            cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[table]);


        }

    }
}
