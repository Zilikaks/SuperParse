using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SuperParser.BLL.Services;
using SuperParser.DAL.Entities;

namespace SuperParser
{
    public partial class ParseResultForm : Form
    {
        public string Company { get; private set; }
        private readonly SeleniumService _seleniumService;
        private readonly VacancyService _vacancyService;
        private List<Vacancy> _vacancies;

        string log;
        string pass;

        public ParseResultForm()
        {
            InitializeComponent();
            _seleniumService = new SeleniumService();
            _vacancyService = new VacancyService();
        }

        public void SetCompanyButton_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("Компания", "Выбор компании", "");
            if (!string.IsNullOrEmpty(result))
            {
                Company = result;
                CompanyNameNumber.Text = Company;
            }   
        }

        public Task _readingTask;

        public void StartParsingButton_Click(object sender, EventArgs e)
        {

            var index = CategoryVacancy.SelectedItem.ToString().Substring(0, 2);
            var typeContact = TypeContact.SelectedItem.ToString();
            _seleniumService.OpenSeleniumService();
            if (_readingTask is null || _readingTask.IsCompleted)
                _readingTask = Task.Run(() =>
                {
                    _seleniumService.Login(log, pass);
                    _seleniumService.OpenVacancyAdminPanel();
                    _seleniumService.SetCompany(IndexCompany.Text);
                    _vacancyService.SetCompany(Company);
                    _vacancies = _vacancyService.GetAll();
                    try
                    {
                        _seleniumService.CreateVacancies(_vacancies, index, typeContact, СontactTextBox.Text);
                    }
                    catch (Exception)
                    {

                       
                    }
                });
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if( (textBox1.Text != "") && (textBox2.Text != "") )
            {
                 log = textBox1.Text;
                 pass = textBox2.Text;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button3.Visible = false;
            }
            else MessageBox.Show("Заполните поля");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
