﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TPFinal
{
    public partial class Form_Joueurs : Form
    {
        private OracleConnection oracon = null;
        private MaConnection cConnection = null;
        private DataSet dataSetJoueur = new DataSet();
        public Form callBackForm = null;
        private string equipe { get; set; }
        private bool currval { get; set; }
        private string commandeSQL { get; set; }

        public Form_Joueurs(OracleConnection connectionoracle, MaConnection maBelleConnection, string equipeEnCours)
        {
            InitializeComponent();
            oracon = connectionoracle;
            cConnection = maBelleConnection;
            equipe = equipeEnCours;
            currval = false;
            commandeSQL = null;
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e) // Ouvre la form d'ajout de joueur
        {
            Form_Ajouter_Joueur aJ = new Form_Ajouter_Joueur(oracon, cConnection);
            aJ.callBackForm = this;
            aJ.Text = "Ajout de joueur";
            aJ.Location = this.Location;
            this.Hide(); // Cache la fenêtre actuelle
            aJ.ShowDialog();

            if (!currval)
                commandeSQL = "SELECT MAX(numjoueur) from joueur ";
            else
                commandeSQL = "SELECT Seq_num_joueur.currval from dual";

            OracleCommand oraCommande = new OracleCommand(commandeSQL, oracon);
            oraCommande.CommandType = CommandType.Text;
            try
            {
                OracleDataReader oraReader = oraCommande.ExecuteReader();
                while (oraReader.Read())
                    aJ.numeroJoueurs = (oraReader.GetInt32(0) + 1).ToString();
                oraReader.Close();

            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (aJ.ShowDialog() == DialogResult.OK)
            {
                string sql = "insert into joueur" +
                             "(nomjoueur, prenomjoueur, datanaissance, numeromaillot, nomequipe, positionjoueur)" +
                             "VALUES(:Nomjoueurs, :PrenomJoueurs, :datenaissance, :numeromaillot, :equipejoueur, :positionjoueur)";
                currval = true;
                try
                {
                    OracleCommand oraAjout = new OracleCommand(sql, oracon);

                    OracleParameter OraParaNomjoueurs = new OracleParameter(":Nomjoueurs", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamPrenomjoueurs = new OracleParameter(":Prenomjoueurs", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamdatenaissance = new OracleParameter(":datenaissance", OracleDbType.Date);
                    OracleParameter OraParanumeromaillot = new OracleParameter(":numeromaillot", OracleDbType.Int32);
                    OracleParameter OraParaequipejoueurs = new OracleParameter(":equipejoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParpositionjoueur = new OracleParameter(":positionjoueur", OracleDbType.Varchar2, 40);

                    OraParaNomjoueurs.Value = aJ.nomJoueurs;
                    OraParamPrenomjoueurs.Value = aJ.prenomJoueurs;
                    OraParamdatenaissance.Value = DateTime.Parse(aJ.DDN);
                    OraParanumeromaillot.Value = aJ.maillot;
                    OraParaequipejoueurs.Value = aJ.Equipe;
                    OraParpositionjoueur.Value = aJ.Position;

                    oraAjout.Parameters.Add(OraParaNomjoueurs);
                    oraAjout.Parameters.Add(OraParamPrenomjoueurs);
                    oraAjout.Parameters.Add(OraParamdatenaissance);
                    oraAjout.Parameters.Add(OraParanumeromaillot);
                    oraAjout.Parameters.Add(OraParaequipejoueurs);
                    oraAjout.Parameters.Add(OraParpositionjoueur);

                    oraAjout.ExecuteNonQuery();
                    RemplirFormulaire();
                }
                catch (OracleException ex) // Erreur "child exists"
                {
                    if (ex.Number == 2292)
                        MessageBox.Show("Le joueur ne doit pas avoir de statistique dans les matchs", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void RemplirFormulaire()
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT * FROM Joueur WHERE nomequipe=:NomEquipe";
            oraSelect.Parameters.Add(new OracleParameter(":NomEquipe", equipe));
            using (OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect))
            {
                if (dataSetJoueur.Tables.Contains("Joueur"))
                {
                    dataSetJoueur.Tables["Joueur"].Clear();
                }

                oraAdapter.Fill(dataSetJoueur, "Joueur");
            }

            UpdateLinkTB();
        }
        private void UpdateLinkTB()
        {
            UnbindTB();
            TB_NumJoueur.DataBindings.Add("Text", dataSetJoueur, "Joueur.NumeroJoueur");
            TB_NomJoueur.DataBindings.Add("Text", dataSetJoueur, "Joueur.NomJoueur");
            TB_PrenomJoueur.DataBindings.Add("Text", dataSetJoueur, "Joueur.PrenomJoueur");
            DTP_DateNaissance.DataBindings.Add("Text", dataSetJoueur, "Joueur.DateNaissance");
            TB_NumMaillot.DataBindings.Add("Text", dataSetJoueur, "Joueur.NumeroMaillot");
            CB_EquipeJoueur.DataBindings.Add("SelectedItem", dataSetJoueur, "Joueur.nomequipe");
            CB_PosJoueur.DataBindings.Add("SelectedItem", dataSetJoueur, "Joueur.PositionJoueur");
        }
        private void UnbindTB()
        {
            TB_NumJoueur.DataBindings.Clear();
            TB_NumJoueur.Clear();
            TB_NomJoueur.DataBindings.Clear();
            TB_NomJoueur.Clear();
            TB_PrenomJoueur.DataBindings.Clear();
            TB_PrenomJoueur.Clear();
            DTP_DateNaissance.DataBindings.Clear();
            DTP_DateNaissance.Value = DateTime.Now;
            TB_NumMaillot.DataBindings.Clear();
            TB_NumMaillot.Clear();
            CB_EquipeJoueur.DataBindings.Clear();
            CB_EquipeJoueur.ResetText();
            CB_PosJoueur.DataBindings.Clear();
            CB_PosJoueur.ResetText();
        }

        private void updateControls()
        {
            if (TB_NumJoueur.Text == "")
            {
                BTN_Modifier.Enabled = false;
                BTN_Debut.Enabled = false;
                BTN_Fin.Enabled = false;
                BTN_Precedent.Enabled = false;
                BTN_Suivant.Enabled = false;
                BTN_Effacer.Enabled = false;
            }
            else
            {
                BTN_Modifier.Enabled = true;
                BTN_Debut.Enabled = true;
                BTN_Fin.Enabled = true;
                BTN_Precedent.Enabled = true;
                BTN_Suivant.Enabled = true;
                BTN_Effacer.Enabled = true;
            }
        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSetJoueur, "Joueur"].Position = 0;
        }

        private void BTN_Fin_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSetJoueur, "Joueur"].Position = this.BindingContext[dataSetJoueur, "Joueur"].Count - 1;
        }

        private void BTN_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSetJoueur, "Joueur"].Position--;
        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSetJoueur, "Joueur"].Position++;
        }

        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment effacer cette entrée ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) ;
            {
                try
                {
                    OracleParameter paramNomEquipe = new OracleParameter(":numjoueur", OracleDbType.Int32);
                    paramNomEquipe.Value = TB_NumJoueur.Text;
                    string sql = "Delete from joueur Where numerojoueur =:numjoueur";
                    OracleCommand oraDelete = new OracleCommand(sql, oracon);
                    oraDelete.Parameters.Add(paramNomEquipe);
                    oraDelete.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    if (ex.Number == 2292) // Erreur "child exists"
                        MessageBox.Show("Vous ne pouvez pas effacer des joueurs avec des matchs", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Form_Ajouter_Joueur aj = new Form_Ajouter_Joueur(oracon, cConnection);
            aj.callBackForm = this;
            aj.Text = "Modification du joueur";
            aj.numeroJoueurs = TB_NumJoueur.Text;
            aj.nomJoueurs = TB_NomJoueur.Text;
            aj.prenomJoueurs = TB_PrenomJoueur.Text;
            aj.DDN = DTP_DateNaissance.Value.ToString();
            aj.maillot = TB_NumMaillot.Text;
            aj.Equipe = CB_EquipeJoueur.SelectedItem.ToString();
            aj.Position = CB_PosJoueur.SelectedItem.ToString();
            aj.Location = this.Location;
            aj.BTN_Ajouter.Text = "Modifier";
            this.Hide();

            if (aj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "Update joueur set Nomjoueur =:Nomjoueurs, Prenomjoueur =:Prenomjoueur, datenaissance =:datenaissance, numeromaillot =:numeromaillot, nomequipe =:equipejoueur , positionjoueur=:positionjoueur" +
                             "where numerojoueur =:numerojoueurs";
                try
                {

                    OracleCommand oraAjout = new OracleCommand(sql, oracon);

                    OracleParameter OraParaNomjoueurs = new OracleParameter(":Nomjoueurs", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamPrenomjoueurs = new OracleParameter(":Prenomjoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamdatenaissance = new OracleParameter(":datenaissance", OracleDbType.Date);  //Ajout
                    OracleParameter OraParanumeromaillot = new OracleParameter(":numeromaillot", OracleDbType.Int32);
                    OracleParameter OraParaequipejoueurs = new OracleParameter(":equipejoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParpositionjoueur = new OracleParameter(":positionjoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParnumerojoueurs = new OracleParameter(":numerojoueurs", OracleDbType.Int32);

                    OraParaNomjoueurs.Value = aj.nomJoueurs;
                    OraParamPrenomjoueurs.Value = aj.prenomJoueurs;
                    OraParamdatenaissance.Value = DateTime.Parse(aj.DDN);
                    OraParanumeromaillot.Value = aj.maillot;
                    OraParaequipejoueurs.Value = aj.Equipe;
                    OraParpositionjoueur.Value = aj.Position;
                    OraParnumerojoueurs.Value = aj.numeroJoueurs;

                    oraAjout.Parameters.Add(OraParaNomjoueurs);
                    oraAjout.Parameters.Add(OraParamPrenomjoueurs);
                    oraAjout.Parameters.Add(OraParamdatenaissance);
                    oraAjout.Parameters.Add(OraParanumeromaillot);
                    oraAjout.Parameters.Add(OraParaequipejoueurs);
                    oraAjout.Parameters.Add(OraParpositionjoueur);
                    oraAjout.Parameters.Add(OraParnumerojoueurs);

                    oraAjout.ExecuteNonQuery();

                    RemplirFormulaire();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void Form_Joueurs_Load(object sender, EventArgs e)
        {
            OracleCommand oraSelect = oracon.CreateCommand();
            oraSelect.CommandText = "SELECT NomEquipe FROM Equipe";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_EquipeJoueur.Items.Add(oraReader.GetString(0));
                }
            }

            MiseAJourFormulaire();
        }

        private void MiseAJourFormulaire()
        {
            RemplirFormulaire();
            updateControls();
        }

        private void Form_Joueurs_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void BTN_Fermer_Click(object sender, EventArgs e)
        {

        }
    }
}
