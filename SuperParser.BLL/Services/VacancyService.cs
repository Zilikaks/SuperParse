using HtmlAgilityPack;
using SuperParser.BLL.Settings;
using SuperParser.DAL;
using SuperParser.DAL.DataLoaders;
using SuperParser.DAL.Entities;
using SuperParser.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperParser.BLL.Services
{
    public class VacancyService
    {
        private IParserSettings _settings;
        private readonly RootLoader _rootLoader;
        private readonly PagesCollection<Root> _pages;

        public VacancyService()
        {
            UpdateSettings(string.Empty);
            _rootLoader = new RootLoader();
            _pages = new PagesCollection<Root>(_rootLoader, _settings);
        }

        private void UpdateSettings(string companyName)
        {
            _settings = new VacancyParserSettings
            {
                BaseUrl = $"https://api.hh.ru/vacancies?area=16&search_field=company_name&text={companyName}&per_page=100",
                Pagination = "&page=",
                StartPage = 0,
                EndPage = 7
            };
        }

        public void SetCompany(string companyName)
        {
            UpdateSettings(companyName);
            _pages.SetSettings(_settings);
        }

        public List<Vacancy> GetAll()
        {
            var result = new List<Vacancy>();
            foreach (var root in _pages)
                foreach (var link in root.Refs)
                {
                    var vacancy = _rootLoader.GetVacancyAsync(link.Url).GetAwaiter().GetResult();
                    result.Add(ParseDescription(vacancy));
                }
            
            return result;
        }

        

        private Vacancy ParseDescription(Vacancy vacancy)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(vacancy.Description);
            try
            {

                var headers = doc.DocumentNode.SelectNodes("//ul/preceding-sibling::p[1]").Select(_ => _.InnerText);
                var content = doc.DocumentNode.SelectNodes("//ul").Select(_ => _.InnerText);
                var dict = headers.Zip(content, (h, c) => new { h, c }).ToDictionary(_ => _.h, _ => _.c);



                foreach (var kp in dict)
                {
                    if (new[] { "обяз", "Responsibilit", "задач", "занима", "предстоит", "Responsibilities", "stack", "Main activities", "duties" }.Any(_ => kp.Key.ToLower().IndexOf(_) != -1))
                        vacancy.Responsebilities = kp.Value;//обязанности
                    else if (new[] { "требов", "ideal candidate", "Qualifications", "You are a great candidate for this position", "Required ", "have experience", "Our expectations", "важн", "ожидан", "ожидаем", "жела", "хотим", " плюс", "пригод", "requirement ", "skill" }.Any(_ => kp.Key.ToLower().IndexOf(_) != -1))
                        vacancy.Requirements = kp.Value;//требования
                    else if (new[] { "услов", "гарант", "предл", "возмож", "We offer", "benefits" }.Any(_ => kp.Key.ToLower().IndexOf(_) != -1))
                        vacancy.Offers = kp.Value;//условия
                }

                return vacancy;
            }
            catch
            {
                return vacancy;
            }
        }
       

    }
}
