using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormulaOneDll;

namespace FormulaOneCrudFormProject
{
    public partial class FormMain : Form
    {
        // N.B. usiamo una BindingList perché è sensibile al cambiamento
        //      se avessimo usato una semplice List, al momento dell'aggiornamento
        //      dei dati occorrerebbe ricaricare i dati manualmente
        BindingList<Team> teams;
        DbTools db;
        SerializableBindingList<Team> teamsRes;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            db = new DbTools();
            teams = new BindingList<Team>(db.LoadTeams());
            listBoxTeam.DataSource = teams;
            // listBoxTeam.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team t = new Team(999, "Test", "Test di test", new Country("IT", "Italy"), "Ferrari", "Giaison", "Test chassis", null, null);
            teams.Add(t);

            teamsRes = new SerializableBindingList<Team>();
            // probabilmente errore nella trasmissione dei dati
            teams = teamsRes;

            DbTools.SerializeToCsv(teamsRes, @".\Teams.csv");
            /*****  NON VA  *****/
        }

        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxTeam.SelectedIndex;
            lblId.Text = (teams[index].Id).ToString();
            lblNome.Text = teams[index].Name;
            lblFullTeamName.Text = teams[index].FullTeamName;
            lblCountry.Text = (teams[index].Country).ToString();
            lblPowerUnit.Text = teams[index].PowerUnit;
            lblTechnicalChief.Text = teams[index].TechnicalChief;
            lblChassis.Text = teams[index].Chassis;
            lblExtFirstDriver.Text = teams[index].ExtFirstDriver;
            lblExtSecondDriver.Text = teams[index].ExtSecondDriver;
        }
    }
}
